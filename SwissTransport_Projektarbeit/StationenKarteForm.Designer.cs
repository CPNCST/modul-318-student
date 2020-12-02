
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
            this.mapStationTxtbox = new System.Windows.Forms.TextBox();
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
            // mapStationTxtbox
            // 
            this.mapStationTxtbox.Location = new System.Drawing.Point(89, 13);
            this.mapStationTxtbox.Name = "mapStationTxtbox";
            this.mapStationTxtbox.Size = new System.Drawing.Size(113, 20);
            this.mapStationTxtbox.TabIndex = 1;
            this.mapStationTxtbox.Text = "\"Stationname\"";
            // 
            // StationenKarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(558, 471);
            this.Controls.Add(this.mapStationTxtbox);
            this.Controls.Add(this.mapStationNameLbl);
            this.Name = "StationenKarteForm";
            this.Text = "Stationen Karte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapStationNameLbl;
        private System.Windows.Forms.TextBox mapStationTxtbox;
    }
}