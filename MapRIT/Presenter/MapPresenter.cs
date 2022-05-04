using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MapRIT.View;
using MapRIT.Model;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MapRIT.Presenter
{
    enum RowState
    {
        Existed,
        New,
        Modifed,
        ModifedNew,
        Deleted
    }

    public class MapPresenter
    {
        DataBase dataBase = new DataBase();

        public string VehicleName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        private readonly IMap _mapView;

        public MapPresenter(IMap mapView)
        {
            _mapView = mapView;
        }

        private PointLatLng AddPoints(MainWindow window)
        {
            Refresh(window.MainDataGridView);

            PointLatLng point = new PointLatLng(Latitude, Longitude);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            GMapOverlay overlay = new GMapOverlay("markers");
            overlay.Markers.Add(marker);
            window.GMapCanvas.Overlays.Add(overlay);

            return window.GMapCanvas.Position = new PointLatLng(Latitude, Longitude);
        }

        private void ReadSingleRow(DataGridView data, IDataRecord record)
        {
            data.Rows.Add
                (
                    record.GetInt32(0),
                    record.GetString(1),
                    record.GetInt32(2),
                    record.GetInt32(3),
                    RowState.ModifedNew
                );
        }

        public void CreateColumns(MainWindow window)
        {
            window.MainDataGridView.Columns.Add("ID", "ID");
            window.MainDataGridView.Columns.Add("Vehicle_Name", "Имя транспрота");
            window.MainDataGridView.Columns.Add("Latitude", "Широта");
            window.MainDataGridView.Columns.Add("Longitude", "Долгота");
            window.MainDataGridView.Columns.Add("Is_New", string.Empty);

            window.MainDataGridView.Columns[4].Visible = false;
        }


        public void Refresh(DataGridView data)
        {
            data.Rows.Clear();

            string queryString = $"SELECT * FROM Vehicles";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.InitConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                ReadSingleRow(data, reader);
            reader.Close();
        }

        public void Update(MainWindow window)
        {
            dataBase.InitConnection();

            for (int i = 0; i < window.MainDataGridView.Rows.Count; ++i)
            {
                var rowState = (RowState)window.MainDataGridView.Rows[i].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(window.MainDataGridView.Rows[i].Cells[0].Value);

                    var delete = $"DELETE FROM Vehicles WHERE ID = {id}";

                    var command = new SqlCommand(delete, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.CloseConnection();
        }

        public void LoadMap(MainWindow window)
        {
            window.GMapCanvas.MapProvider = GMapProviders.GoogleMap;
            window.GMapCanvas.ShowCenter = false;

            window.GMapCanvas.MinZoom = 1;
            window.GMapCanvas.MaxZoom = 20;
            window.GMapCanvas.Zoom = 10;

            window.GMapCanvas.DragButton = MouseButtons.Left;
        }

        public void Add(MainWindow window)
        {
            dataBase.InitConnection();

            VehicleName = _mapView.TextVehicleName;
            Latitude = Convert.ToDouble(_mapView.TextLatitude);
            Longitude = Convert.ToDouble(_mapView.TextLongitude);

            var add = $"INSERT INTO Vehicles (Vehicle_Name, Latitude, Longitude) VALUES ('{VehicleName}', '{Latitude}', '{Longitude}')";

            var command = new SqlCommand(add, dataBase.GetConnection());
            command.ExecuteNonQuery();
            AddPoints(window);
            dataBase.CloseConnection();
        }

        public void Delete(MainWindow window)
        {
            int index = window.MainDataGridView.CurrentCell.RowIndex;

            window.MainDataGridView.Rows[index].Visible = false;

            if (window.MainDataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                window.MainDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            window.MainDataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

            if (window.GMapCanvas.Overlays.Count > 0)
            {
                window.GMapCanvas.Overlays.RemoveAt(0);
                window.GMapCanvas.Refresh();
            }
        }
    }
}