using GMap.NET.WindowsForms;
using MapRIT.Presenter;
using MapRIT.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MapRIT
{
    public partial class MainWindow : Form, IMap
    {
        private MapPresenter _map;
        private GMapMarker _selectedMarker;

        private int _selectedRow;

        public MainWindow()
        {
            InitializeComponent();
            GMapCanvas.MouseUp += GMapCanvas_MouseUp;
            GMapCanvas.MouseDown += GMapCanvas_MouseDown;
            BtnUndo.Visible = false;
        }

        public string TextVehicleName { get => TxtVehicleName.Text; set => TxtVehicleName.Text = value; }
        public string TextLatitude { get => TxtLatitude.Text; set => TxtLatitude.Text = value; }
        public string TextLongitude { get => TxtLongitude.Text; set => TxtLongitude.Text = value; }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _map = new MapPresenter(this);
            _map.LoadMap(this);
            _map.CreateColumns(this);
            _map.Refresh(MainDataGridView);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            _map = new MapPresenter(this);
            _map.Add(this);

            GbSettings.Visible = false;
            BtnUndo.Visible = true;
            BtnHideSettings.Visible = false;
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            GbSettings.Visible = true;
            BtnUndo.Visible = false;
            BtnHideSettings.Visible = true;
        }

        private void BtnHideSettings_Click(object sender, EventArgs e)
        {
            BtnUndo.Visible = true;
            GbSettings.Visible = false;
            BtnHideSettings.Visible = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            _map.Refresh(MainDataGridView);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _map = new MapPresenter(this);
            _map.Update(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _map = new MapPresenter(this);
            _map.Delete(this);
        }

        private void GMapCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _selectedMarker = GMapCanvas.Overlays
                              .SelectMany(o => o.Markers)
                              .FirstOrDefault(m => m.IsMouseOver == true);
        }

        private void GMapCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedMarker is null)
                return;

            var coordinates = GMapCanvas.FromLocalToLatLng(e.X, e.Y);

            _selectedMarker.Position = coordinates;

            _selectedMarker = null;
        }

        private void GMapCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            TxtLatitude.Text = GMapCanvas.FromLocalToLatLng(e.X, e.Y).Lat.ToString("0");
            TxtLongitude.Text = GMapCanvas.FromLocalToLatLng(e.X, e.Y).Lng.ToString("0");
        }

        private void MainDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _map = new MapPresenter(this);
            _selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MainDataGridView.Rows[_selectedRow];

                TxtVehicleName.Text = row.Cells[1].Value.ToString();
                TxtLatitude.Text = row.Cells[2].Value.ToString();
                TxtLongitude.Text = row.Cells[3].Value.ToString();
            }
        }

    }
}