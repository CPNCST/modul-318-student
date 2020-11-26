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
        Transport transport = new Transport(); 

        public verbindungenSuchenForm()
        {
            InitializeComponent();
        }

        private void verbindungenSuchenBtn_Click(object sender, EventArgs e)
        {
            verbindungenListView.Items.Clear();
            verbindungenListView.Columns.Clear();
            verbindungenListView.View = View.Details;
            verbindungenListView.Items.AddRange(GetConnectionsInListView(vonStationTxtBox.Text, zuStationTxtBox.Text));
        }

        private ListViewItem[] GetConnectionsInListView(string vonStation, string zuStation)
        {
            Connections verbindung = transport.GetConnections(vonStation, zuStation);

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
    }
}
