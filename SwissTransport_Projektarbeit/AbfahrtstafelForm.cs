using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using SwissTransport;

namespace SwissTransport_Projektarbeit
{
    public partial class AbfahrtstafelForm : Form
    {
        // Membervariablen 
        Transport _transport = new Transport();

        public AbfahrtstafelForm()
        {
            InitializeComponent();
            abfahrtStationListView.View = View.Details;
        }

        private void positionFindenBtn_Click(object sender, EventArgs e)
        {

        }

        private void abfahrtStationSuchenBtn_Click(object sender, EventArgs e)
        {
            abfahrtStationListView.Items.Clear();
            abfahrtStationListView.Columns.Clear();
            abfahrtStationListView.Items.AddRange(GetStationBoard(abfahrtStationCmbBox.Text));
        }

        private void abfahrtStationCmbBox_TextUpdate(object sender, EventArgs e)
        {
            abfahrtStationCmbBox.Items.Clear();
            abfahrtStationCmbBox.SelectionStart = abfahrtStationCmbBox.Text.Length;

            if (abfahrtStationCmbBox.Text.Length >= 3)
            {
                GetSuggestionStation(abfahrtStationCmbBox.Text, abfahrtStationCmbBox);
            }
        }

        public ListViewItem[] GetStationBoard(string fromStation)
        {
            Stations stations = new Stations();
            stations = _transport.GetStations(fromStation);
            string stationID = stations.StationList.First().Id;
            StationBoardRoot stationBoard = null;

            try
            {
                stationBoard = _transport.GetStationBoard(fromStation, stationID);
            }
            catch (Exception ex)
            {
                ListViewItem[] listViewError = new ListViewItem[1];
                listViewError[0] = new ListViewItem("FEHLER");
                listViewError[0].SubItems.Add(ex.Message);
                
                return listViewError;
            }

            AddColumns();
            ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
            int i = 0; 
            
            foreach (StationBoard item in stationBoard.Entries)
            {
                stationListView[i] = new ListViewItem(item.To); // Zu Station
                stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString()); // Abfahrt 
                stationListView[i].SubItems.Add(item.Name); // Zuginformation
                i++;
            }

            if (stationListView == null)
            {
                stationListView[0] = new ListViewItem("Es ist keine Abfahrtstafel vorhanden.");
            }

            return stationListView;
        }

        private void AddColumns()
        {
            abfahrtStationListView.Columns.Add("Zu Station");
            abfahrtStationListView.Columns.Add("Abfahrt");
            abfahrtStationListView.Columns.Add("ZugInformation");

            for (int i = 0; i < abfahrtStationListView.Columns.Count; i++)
            {
                abfahrtStationListView.Columns[i].Width = 90;
            }
        }

        private void GetSuggestionStation(string location, ComboBox cmbStation)
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
                cmbStation.Items.Add(item);
            }

            if (cmbStation.Items.Count > 0)
            {
                //cmbStation.SelectedItem = location;
            }
        }
    }
}
