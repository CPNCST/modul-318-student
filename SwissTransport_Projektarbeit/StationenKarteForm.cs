using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace SwissTransport_Projektarbeit
{
    public partial class StationenKarteForm : Form
    {
        // Membervariablen 
        Transport _transport = new Transport();
        List<Station> stationList = new List<Station>();

        public StationenKarteForm()
        {
            InitializeComponent();
        }

        private void mapSuchenBtn_Click(object sender, EventArgs e)
        {
            if (mapStationCmbBox.SelectedIndex != -1)
            {
                this.GetLocation(stationList, _transport, mapStationCmbBox.SelectedItem.ToString());
                //gMapControl.Show(GetLocation(stationList, _transport, mapStationCmbBox.SelectedItem.ToString()));
            }
        }

        private void mapStationCmbBox_TextUpdate(object sender, EventArgs e)
        {
            mapStationCmbBox.Items.Clear();
            mapStationCmbBox.SelectionStart = mapStationCmbBox.Text.Length;

            GetSuggestionMapStation(mapStationCmbBox.Text, mapStationCmbBox);
        }

        private void GetSuggestionMapStation(string location, ComboBox cmbStation)
        {
            Stations stations = _transport.GetStations(location);
            List<string> toStationList = new List<string>();

            foreach (var item in stations.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    toStationList.Add(item.Name);
                }
            }

            foreach (var item in toStationList)
            {
                cmbStation.Items.Add(item);
            }
        }

        public void SetToLocation(double x, double y, string stationName)
        {
            gMapControl.Position = new PointLatLng(x, y);
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.CanDragMap = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 18;
            gMapControl.AutoScroll = true;
        }

        private void GetLocation(List<Station> stations, Transport transport, string locationName)
        {
            stations = transport.GetStations(locationName).StationList;
            foreach (Station station in stations)
            {
                if (station.Name == locationName)
                {
                    this.SetToLocation(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate, station.Name.ToString());
                    this.Show();
                }
            }
        }
    }
}
