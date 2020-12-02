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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MFverbindungenSuchenBtn_Click(object sender, EventArgs e)
        {
            Form verbindungenSuchenForm = new verbindungenSuchenForm();
            verbindungenSuchenForm.Show();
        }

        private void MFstationenAbfahrtstafelBtn_Click(object sender, EventArgs e)
        {
            Form abfahrtstafelForm = new AbfahrtstafelForm();
            abfahrtstafelForm.Show();
        }

        private void MFkarteStationsuebersichtBtn_Click(object sender, EventArgs e)
        {
            Form stationenKarteForm = new StationenKarteForm();
            stationenKarteForm.Show();
        }
    }
}
