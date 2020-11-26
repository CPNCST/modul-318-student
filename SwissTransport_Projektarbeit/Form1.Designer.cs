
namespace SwissTransport_Projektarbeit
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.swissTransportAppLbl = new System.Windows.Forms.Label();
            this.MFverbindungenSuchenBtn = new System.Windows.Forms.Button();
            this.MFstationenAbfahrtstafelBtn = new System.Windows.Forms.Button();
            this.MFkarteStationsuebersichtBtn = new System.Windows.Forms.Button();
            this.MFzugverbindungMailenBtn = new System.Windows.Forms.Button();
            this.MFrouteHistorieBtn = new System.Windows.Forms.Button();
            this.MainMenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuGroupBox
            // 
            this.MainMenuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuGroupBox.Controls.Add(this.MFrouteHistorieBtn);
            this.MainMenuGroupBox.Controls.Add(this.MFzugverbindungMailenBtn);
            this.MainMenuGroupBox.Controls.Add(this.MFkarteStationsuebersichtBtn);
            this.MainMenuGroupBox.Controls.Add(this.MFstationenAbfahrtstafelBtn);
            this.MainMenuGroupBox.Controls.Add(this.MFverbindungenSuchenBtn);
            this.MainMenuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuGroupBox.Location = new System.Drawing.Point(12, 104);
            this.MainMenuGroupBox.Name = "MainMenuGroupBox";
            this.MainMenuGroupBox.Size = new System.Drawing.Size(441, 296);
            this.MainMenuGroupBox.TabIndex = 0;
            this.MainMenuGroupBox.TabStop = false;
            this.MainMenuGroupBox.Text = "Main Menu";
            // 
            // swissTransportAppLbl
            // 
            this.swissTransportAppLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swissTransportAppLbl.AutoSize = true;
            this.swissTransportAppLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swissTransportAppLbl.Location = new System.Drawing.Point(91, 39);
            this.swissTransportAppLbl.Name = "swissTransportAppLbl";
            this.swissTransportAppLbl.Size = new System.Drawing.Size(301, 34);
            this.swissTransportAppLbl.TabIndex = 1;
            this.swissTransportAppLbl.Text = "Swiss Transport App";
            // 
            // MFverbindungenSuchenBtn
            // 
            this.MFverbindungenSuchenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFverbindungenSuchenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFverbindungenSuchenBtn.Location = new System.Drawing.Point(7, 32);
            this.MFverbindungenSuchenBtn.Name = "MFverbindungenSuchenBtn";
            this.MFverbindungenSuchenBtn.Size = new System.Drawing.Size(427, 35);
            this.MFverbindungenSuchenBtn.TabIndex = 0;
            this.MFverbindungenSuchenBtn.Text = "Verbindungen Suchen";
            this.MFverbindungenSuchenBtn.UseVisualStyleBackColor = true;
            this.MFverbindungenSuchenBtn.Click += new System.EventHandler(this.verbindungenSuchenBtn_Click);
            // 
            // MFstationenAbfahrtstafelBtn
            // 
            this.MFstationenAbfahrtstafelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFstationenAbfahrtstafelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFstationenAbfahrtstafelBtn.Location = new System.Drawing.Point(6, 76);
            this.MFstationenAbfahrtstafelBtn.Name = "MFstationenAbfahrtstafelBtn";
            this.MFstationenAbfahrtstafelBtn.Size = new System.Drawing.Size(427, 35);
            this.MFstationenAbfahrtstafelBtn.TabIndex = 1;
            this.MFstationenAbfahrtstafelBtn.Text = "Abfahrtstafel Stationen";
            this.MFstationenAbfahrtstafelBtn.UseVisualStyleBackColor = true;
            // 
            // MFkarteStationsuebersichtBtn
            // 
            this.MFkarteStationsuebersichtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFkarteStationsuebersichtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFkarteStationsuebersichtBtn.Location = new System.Drawing.Point(7, 120);
            this.MFkarteStationsuebersichtBtn.Name = "MFkarteStationsuebersichtBtn";
            this.MFkarteStationsuebersichtBtn.Size = new System.Drawing.Size(427, 35);
            this.MFkarteStationsuebersichtBtn.TabIndex = 2;
            this.MFkarteStationsuebersichtBtn.Text = "Karte Stationsübersicht";
            this.MFkarteStationsuebersichtBtn.UseVisualStyleBackColor = true;
            // 
            // MFzugverbindungMailenBtn
            // 
            this.MFzugverbindungMailenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFzugverbindungMailenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFzugverbindungMailenBtn.Location = new System.Drawing.Point(6, 164);
            this.MFzugverbindungMailenBtn.Name = "MFzugverbindungMailenBtn";
            this.MFzugverbindungMailenBtn.Size = new System.Drawing.Size(427, 35);
            this.MFzugverbindungMailenBtn.TabIndex = 3;
            this.MFzugverbindungMailenBtn.Text = "Zugverbindung Mailen";
            this.MFzugverbindungMailenBtn.UseVisualStyleBackColor = true;
            // 
            // MFrouteHistorieBtn
            // 
            this.MFrouteHistorieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFrouteHistorieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFrouteHistorieBtn.Location = new System.Drawing.Point(6, 207);
            this.MFrouteHistorieBtn.Name = "MFrouteHistorieBtn";
            this.MFrouteHistorieBtn.Size = new System.Drawing.Size(428, 38);
            this.MFrouteHistorieBtn.TabIndex = 4;
            this.MFrouteHistorieBtn.Text = "Route Historie";
            this.MFrouteHistorieBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this.swissTransportAppLbl);
            this.Controls.Add(this.MainMenuGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "SwissTransport Main Window";
            this.MainMenuGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainMenuGroupBox;
        private System.Windows.Forms.Label swissTransportAppLbl;
        private System.Windows.Forms.Button MFrouteHistorieBtn;
        private System.Windows.Forms.Button MFzugverbindungMailenBtn;
        private System.Windows.Forms.Button MFkarteStationsuebersichtBtn;
        private System.Windows.Forms.Button MFstationenAbfahrtstafelBtn;
        private System.Windows.Forms.Button MFverbindungenSuchenBtn;
    }
}

