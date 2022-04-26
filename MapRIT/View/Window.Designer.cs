namespace MapRIT
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GMapCanvas = new GMap.NET.WindowsForms.GMapControl();
            this.GbSettings = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.LblVehicleName = new System.Windows.Forms.Label();
            this.TxtVehicleName = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblLongitude = new System.Windows.Forms.Label();
            this.LblLatitude = new System.Windows.Forms.Label();
            this.TxtLongitude = new System.Windows.Forms.TextBox();
            this.TxtLatitude = new System.Windows.Forms.TextBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnHideSettings = new System.Windows.Forms.Button();
            this.GbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GMapCanvas
            // 
            this.GMapCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GMapCanvas.Bearing = 0F;
            this.GMapCanvas.CanDragMap = true;
            this.GMapCanvas.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapCanvas.GrayScaleMode = false;
            this.GMapCanvas.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapCanvas.LevelsKeepInMemory = 5;
            this.GMapCanvas.Location = new System.Drawing.Point(0, 0);
            this.GMapCanvas.MarkersEnabled = true;
            this.GMapCanvas.MaxZoom = 2;
            this.GMapCanvas.MinZoom = 2;
            this.GMapCanvas.MouseWheelZoomEnabled = true;
            this.GMapCanvas.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapCanvas.Name = "GMapCanvas";
            this.GMapCanvas.NegativeMode = false;
            this.GMapCanvas.PolygonsEnabled = true;
            this.GMapCanvas.RetryLoadTile = 0;
            this.GMapCanvas.RoutesEnabled = true;
            this.GMapCanvas.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapCanvas.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapCanvas.ShowTileGridLines = false;
            this.GMapCanvas.Size = new System.Drawing.Size(1073, 577);
            this.GMapCanvas.TabIndex = 0;
            this.GMapCanvas.Zoom = 0D;
            this.GMapCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GMapCanvas_MouseClick);
            this.GMapCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GMapCanvas_MouseDown);
            this.GMapCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GMapCanvas_MouseUp);
            // 
            // GbSettings
            // 
            this.GbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GbSettings.Controls.Add(this.BtnUpdate);
            this.GbSettings.Controls.Add(this.BtnDelete);
            this.GbSettings.Controls.Add(this.BtnRefresh);
            this.GbSettings.Controls.Add(this.MainDataGridView);
            this.GbSettings.Controls.Add(this.LblVehicleName);
            this.GbSettings.Controls.Add(this.TxtVehicleName);
            this.GbSettings.Controls.Add(this.BtnEnter);
            this.GbSettings.Controls.Add(this.LblLongitude);
            this.GbSettings.Controls.Add(this.LblLatitude);
            this.GbSettings.Controls.Add(this.TxtLongitude);
            this.GbSettings.Controls.Add(this.TxtLatitude);
            this.GbSettings.Location = new System.Drawing.Point(627, 0);
            this.GbSettings.Name = "GbSettings";
            this.GbSettings.Size = new System.Drawing.Size(446, 450);
            this.GbSettings.TabIndex = 1;
            this.GbSettings.TabStop = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdate.Location = new System.Drawing.Point(354, 407);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(80, 28);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Сохранить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.Location = new System.Drawing.Point(181, 407);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 28);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRefresh.Location = new System.Drawing.Point(6, 407);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(80, 28);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Обновить";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(6, 217);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.Size = new System.Drawing.Size(428, 184);
            this.MainDataGridView.TabIndex = 7;
            this.MainDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataGridView_CellClick);
            // 
            // LblVehicleName
            // 
            this.LblVehicleName.AutoSize = true;
            this.LblVehicleName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblVehicleName.Location = new System.Drawing.Point(94, 16);
            this.LblVehicleName.Name = "LblVehicleName";
            this.LblVehicleName.Size = new System.Drawing.Size(64, 30);
            this.LblVehicleName.TabIndex = 6;
            this.LblVehicleName.Text = "Имя \r\nтранспорта";
            this.LblVehicleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtVehicleName
            // 
            this.TxtVehicleName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtVehicleName.Location = new System.Drawing.Point(159, 24);
            this.TxtVehicleName.Name = "TxtVehicleName";
            this.TxtVehicleName.Size = new System.Drawing.Size(121, 22);
            this.TxtVehicleName.TabIndex = 5;
            this.TxtVehicleName.Tag = "50";
            this.TxtVehicleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.Location = new System.Drawing.Point(159, 155);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(121, 43);
            this.BtnEnter.TabIndex = 4;
            this.BtnEnter.Text = "Добавить точку на карту";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblLongitude
            // 
            this.LblLongitude.AutoSize = true;
            this.LblLongitude.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLongitude.Location = new System.Drawing.Point(105, 119);
            this.LblLongitude.Name = "LblLongitude";
            this.LblLongitude.Size = new System.Drawing.Size(48, 15);
            this.LblLongitude.TabIndex = 3;
            this.LblLongitude.Text = "Широта";
            // 
            // LblLatitude
            // 
            this.LblLatitude.AutoSize = true;
            this.LblLatitude.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLatitude.Location = new System.Drawing.Point(105, 73);
            this.LblLatitude.Name = "LblLatitude";
            this.LblLatitude.Size = new System.Drawing.Size(48, 15);
            this.LblLatitude.TabIndex = 2;
            this.LblLatitude.Text = "Долгота";
            // 
            // TxtLongitude
            // 
            this.TxtLongitude.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLongitude.Location = new System.Drawing.Point(159, 112);
            this.TxtLongitude.Name = "TxtLongitude";
            this.TxtLongitude.Size = new System.Drawing.Size(121, 22);
            this.TxtLongitude.TabIndex = 1;
            this.TxtLongitude.Tag = "50";
            this.TxtLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtLatitude
            // 
            this.TxtLatitude.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLatitude.Location = new System.Drawing.Point(159, 70);
            this.TxtLatitude.Name = "TxtLatitude";
            this.TxtLatitude.Size = new System.Drawing.Size(121, 22);
            this.TxtLatitude.TabIndex = 0;
            this.TxtLatitude.Tag = "50";
            this.TxtLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUndo
            // 
            this.BtnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUndo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUndo.Location = new System.Drawing.Point(962, 538);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(99, 28);
            this.BtnUndo.TabIndex = 2;
            this.BtnUndo.Text = "Показать ввод";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnHideSettings
            // 
            this.BtnHideSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHideSettings.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHideSettings.Location = new System.Drawing.Point(962, 538);
            this.BtnHideSettings.Name = "BtnHideSettings";
            this.BtnHideSettings.Size = new System.Drawing.Size(99, 28);
            this.BtnHideSettings.TabIndex = 3;
            this.BtnHideSettings.Text = "Убрать ввод";
            this.BtnHideSettings.UseVisualStyleBackColor = true;
            this.BtnHideSettings.Click += new System.EventHandler(this.BtnHideSettings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 578);
            this.Controls.Add(this.BtnHideSettings);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.GbSettings);
            this.Controls.Add(this.GMapCanvas);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map&Points";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.GbSettings.ResumeLayout(false);
            this.GbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbSettings;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblLongitude;
        private System.Windows.Forms.Label LblLatitude;
        private System.Windows.Forms.TextBox TxtLongitude;
        private System.Windows.Forms.TextBox TxtLatitude;
        public GMap.NET.WindowsForms.GMapControl GMapCanvas;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Label LblVehicleName;
        private System.Windows.Forms.TextBox TxtVehicleName;
        public System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnHideSettings;
    }
}

