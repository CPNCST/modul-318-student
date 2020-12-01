using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SwissTransport;

namespace SwissTransport_Projektarbeit
{
    public partial class verbindungenSuchenForm : Form
    {
        // Membervariablen 
        Transport _transport = new Transport(); 

        public verbindungenSuchenForm()
        {
            InitializeComponent();
            verbindungenListView.View = View.Details;
        }

        private void verbindungenSuchenBtn_Click(object sender, EventArgs e)
        {
            verbindungenListView.Items.Clear();
            verbindungenListView.Columns.Clear();
            verbindungenListView.Items.AddRange(GetConnectionsInListView(vonStationCmbBox.Text, zuStationCmbBox.Text));
        }

        private void vonStationCmbBox_TextChanged(object sender, EventArgs e)
        {
            GetFromStation(vonStationCmbBox.Text, vonStationCmbBox);
        }

        private ListViewItem[] GetConnectionsInListView(string vonStation, string zuStation)
        {
            Connections verbindung = _transport.GetConnections(vonStation, zuStation);

            AddColumns();
            ListViewItem[] listView = new ListViewItem[verbindung.ConnectionList.Count];

            for (int i = 0; i < verbindung.ConnectionList.Count; i++)
            {
                listView[i] = new ListViewItem(verbindung.ConnectionList[i].From.Station.Name);
                listView[i].SubItems.Add(verbindung.ConnectionList[i].To.Station.Name);
                listView[i].SubItems.Add(DateTime.Parse(verbindung.ConnectionList[i].From.Departure).ToShortTimeString());
                listView[i].SubItems.Add(DateTime.Parse(verbindung.ConnectionList[i].To.Arrival).ToShortTimeString());
                listView[i].SubItems.Add(TimeSpan.Parse(verbindung.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + " Min");
                listView[i].SubItems.Add(verbindung.ConnectionList[i].From.Platform);
            }

            return listView;
        }

        private void AddColumns()
        {
            verbindungenListView.Columns.Add("Von Station");
            verbindungenListView.Columns.Add("Zu Station");
            verbindungenListView.Columns.Add("Abfahrt");
            verbindungenListView.Columns.Add("Ankunft");
            verbindungenListView.Columns.Add("Dauer");
            verbindungenListView.Columns.Add("Platform");

            for (int i = 0; i < verbindungenListView.Columns.Count; i++)
            {
                verbindungenListView.Columns[i].Width = 75;
            }
        }

        private void GetFromStation(string location, ComboBox cmbVonStation)
        {
            Stations stations = _transport.GetStations(location);
            List<string> stationsList = new List<string>();

            foreach (var item in stations.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    stationsList.Add(item.Name);
                }
            }

            foreach (var item in stationsList)
            {
                cmbVonStation.Items.Add(item);
            }
            //vonStationCmbBox.Update();

            //if (cmbVonStation.Items.Count > 0)
            //{
            //    cmbVonStation.SelectedIndex = 0; // selected index auf Item wo am ähnsten von input ist.
            //}
        }
    }
}
