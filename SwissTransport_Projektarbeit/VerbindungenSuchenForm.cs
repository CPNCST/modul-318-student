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
        string departureDate = null;
        string departureTime = null;
        int isArrival = 0;

        public verbindungenSuchenForm()
        {
            InitializeComponent();
            verbindungenListView.View = View.Details;
        }

        private void verbindungenSuchenBtn_Click(object sender, EventArgs e)
        {
            verbindungenListView.Items.Clear();
            verbindungenListView.Columns.Clear();
            setDepartureDate();
            setDepartureTime();
            isArrivalOrDeparture();
            verbindungenListView.Items.AddRange(GetConnectionsInListView(vonStationCmbBox.Text, zuStationCmbBox.Text));
        }

        private void vonStationCmbBox_TextUpdate(object sender, EventArgs e)
        {
            vonStationCmbBox.Items.Clear();
            vonStationCmbBox.SelectionStart = vonStationCmbBox.Text.Length;

            GetSuggestionFromStation(vonStationCmbBox.Text, vonStationCmbBox);
        }

        private void zuStationCmbBox_TextUpdate(object sender, EventArgs e)
        {
            zuStationCmbBox.Items.Clear();
            zuStationCmbBox.SelectionStart = zuStationCmbBox.Text.Length;

            GetSuggestionFromStation(zuStationCmbBox.Text, zuStationCmbBox);
        }

        private ListViewItem[] GetConnectionsInListView(string vonStation, string zuStation)
        {
            Connections verbindung = _transport.GetConnections(vonStation, zuStation, departureDate, departureTime, isArrival); 

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

            if (listView == null)
            {
                listView[0] = new ListViewItem("Es sind keine Verbindungen vorhanden.");
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

        private void GetSuggestionFromStation(string location, ComboBox cmbStation)
        {
            Stations stations = _transport.GetStations(location);
            List<string> fromStationList = new List<string>();

            foreach (var item in stations.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    fromStationList.Add(item.Name);
                }
            }

            foreach (var item in fromStationList)
            {
                cmbStation.Items.Add(item);
            }
        }

        private void GetSuggestionToStation(string location, ComboBox cmbStation)
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

        private void setDepartureDate()
        {
            departureDate = datetimeDtp.Value.Year + "-" + datetimeDtp.Value.Month + "-" + datetimeDtp.Value.Day;
        }

        private void setDepartureTime()
        {
            departureTime = timeDtp.Value.Hour + ":" + timeDtp.Value.Minute;
        }

        // isArrival = 1 (true) | isArrival = 0 (false) | Standardwert = 0 
        private void isArrivalOrDeparture()
        {
            if (isArrivalRbtn.Checked == true)
            {
                isArrival = 1;
            }
            else if (isDepartureRbtn.Checked == true)
            {
                isArrival = 0;
            }
        }
    }
}
