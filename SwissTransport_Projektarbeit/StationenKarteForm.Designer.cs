
namespace SwissTransport_Projektarbeit
{
    partial class StationenKarteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapStationNameLbl = new System.Windows.Forms.Label();
            this.mapStationCmbBox = new System.Windows.Forms.ComboBox();
            this.mapSuchenBtn = new System.Windows.Forms.Button();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // mapStationNameLbl
            // 
            this.mapStationNameLbl.AutoSize = true;
            this.mapStationNameLbl.Location = new System.Drawing.Point(13, 13);
            this.mapStationNameLbl.Name = "mapStationNameLbl";
            this.mapStationNameLbl.Size = new System.Drawing.Size(69, 13);
            this.mapStationNameLbl.TabIndex = 0;
            this.mapStationNameLbl.Text = "Stationname:";
            // 
            // mapStationCmbBox
            // 
            this.mapStationCmbBox.FormattingEnabled = true;
            this.mapStationCmbBox.Location = new System.Drawing.Point(89, 13);
            this.mapStationCmbBox.Name = "mapStationCmbBox";
            this.mapStationCmbBox.Size = new System.Drawing.Size(121, 21);
            this.mapStationCmbBox.TabIndex = 3;
            this.mapStationCmbBox.Text = "\"Stationname\"";
            this.mapStationCmbBox.TextUpdate += new System.EventHandler(this.mapStationCmbBox_TextUpdate);
            // 
            // mapSuchenBtn
            // 
            this.mapSuchenBtn.Location = new System.Drawing.Point(217, 10);
            this.mapSuchenBtn.Name = "mapSuchenBtn";
            this.mapSuchenBtn.Size = new System.Drawing.Size(84, 23);
            this.mapSuchenBtn.TabIndex = 4;
            this.mapSuchenBtn.Text = "Suchen";
            this.mapSuchenBtn.UseVisualStyleBackColor = true;
            this.mapSuchenBtn.Click += new System.EventHandler(this.mapSuchenBtn_Click);
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(13, 48);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(550, 432);
            this.gMapControl.TabIndex = 5;
            this.gMapControl.Zoom = 0D;
            // 
            // StationenKarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(575, 492);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.mapSuchenBtn);
            this.Controls.Add(this.mapStationCmbBox);
            this.Controls.Add(this.mapStationNameLbl);
            this.Name = "StationenKarteForm";
            this.Text = "Stationen Karte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapStationNameLbl;
        private System.Windows.Forms.ComboBox mapStationCmbBox;
        private System.Windows.Forms.Button mapSuchenBtn;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}