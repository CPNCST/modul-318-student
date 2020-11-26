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
        // Membervariablen 
        Transport transport = new Transport();

        public MainForm()
        {
            InitializeComponent();
        }

        private void verbindungenSuchenBtn_Click(object sender, EventArgs e)
        {
            Form verbindungenSuchenForm = new verbindungenSuchenForm();
            verbindungenSuchenForm.Show();
        }
    }
}
