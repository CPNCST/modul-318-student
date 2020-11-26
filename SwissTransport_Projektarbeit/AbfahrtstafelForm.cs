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
        List<String> stationID = new List<string>();

        public AbfahrtstafelForm()
        {
            InitializeComponent();
        }

        private void abfahrtStationSuchenBtn_Click(object sender, EventArgs e)
        {
            abfahrtStationListView.Items.Clear();
        }

        private ListViewItem[] getStationConnections(string station, string ID)
        {
            StationBoardRoot stationBoard = _transport.GetStationBoard(station, ID);

            ListViewItem[] listView = new ListViewItem[stationBoard.Entries.Count];

            for (int i = 0; i < stationBoard.Entries.Count; i++)
            {
                //listView[i] = new ListViewItem(stationBoard)
            }

            return listView;
        }
    }
}
