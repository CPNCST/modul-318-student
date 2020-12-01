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

namespace SwissTransport_Projektarbeit
{
    public partial class AbfahrtstafelForm : Form
    {
        // Membervariablen 
        Transport _transport = new Transport();

        public AbfahrtstafelForm()
        {
            InitializeComponent();
        }

        private void abfahrtStationSuchenBtn_Click(object sender, EventArgs e)
        {
            abfahrtStationListView.Items.Clear();
            abfahrtStationListView.Columns.Clear();
            abfahrtStationListView.View = View.Details;
            abfahrtStationListView.Items.AddRange(GetStationBoard(abfahrtStationTextBox.Text));
        }

        private ListViewItem[] GetStationBoard(string fromStation)
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

            return stationListView;
        }

        private void AddColumns()
        {
            abfahrtStationListView.Columns.Add("Station Name");
            abfahrtStationListView.Columns.Add("Zu Station");
            abfahrtStationListView.Columns.Add("Abfahrt");

            for (int i = 0; i < abfahrtStationListView.Columns.Count; i++)
            {
                abfahrtStationListView.Columns[i].Width = 90;
            }
        }
    }
}
