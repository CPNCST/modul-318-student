
namespace SwissTransport_Projektarbeit
{
    partial class verbindungenSuchenForm
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
            this.vonStandortLbl = new System.Windows.Forms.Label();
            this.zuStationLbl = new System.Windows.Forms.Label();
            this.verbindungenSuchenBtn = new System.Windows.Forms.Button();
            this.verbindungenListView = new System.Windows.Forms.ListView();
            this.vonStationCmbBox = new System.Windows.Forms.ComboBox();
            this.zuStationCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vonStandortLbl
            // 
            this.vonStandortLbl.AutoSize = true;
            this.vonStandortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vonStandortLbl.Location = new System.Drawing.Point(12, 9);
            this.vonStandortLbl.Name = "vonStandortLbl";
            this.vonStandortLbl.Size = new System.Drawing.Size(42, 20);
            this.vonStandortLbl.TabIndex = 0;
            this.vonStandortLbl.Text = "Von:";
            // 
            // zuStationLbl
            // 
            this.zuStationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zuStationLbl.AutoSize = true;
            this.zuStationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuStationLbl.Location = new System.Drawing.Point(316, 7);
            this.zuStationLbl.Name = "zuStationLbl";
            this.zuStationLbl.Size = new System.Drawing.Size(32, 20);
            this.zuStationLbl.TabIndex = 2;
            this.zuStationLbl.Text = "Zu:";
            // 
            // verbindungenSuchenBtn
            // 
            this.verbindungenSuchenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verbindungenSuchenBtn.Location = new System.Drawing.Point(198, 48);
            this.verbindungenSuchenBtn.Name = "verbindungenSuchenBtn";
            this.verbindungenSuchenBtn.Size = new System.Drawing.Size(141, 29);
            this.verbindungenSuchenBtn.TabIndex = 4;
            this.verbindungenSuchenBtn.Text = "Suchen";
            this.verbindungenSuchenBtn.UseVisualStyleBackColor = true;
            this.verbindungenSuchenBtn.Click += new System.EventHandler(this.verbindungenSuchenBtn_Click);
            // 
            // verbindungenListView
            // 
            this.verbindungenListView.HideSelection = false;
            this.verbindungenListView.Location = new System.Drawing.Point(12, 101);
            this.verbindungenListView.Name = "verbindungenListView";
            this.verbindungenListView.Size = new System.Drawing.Size(482, 299);
            this.verbindungenListView.TabIndex = 5;
            this.verbindungenListView.UseCompatibleStateImageBehavior = false;
            // 
            // vonStationCmbBox
            // 
            this.vonStationCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vonStationCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vonStationCmbBox.FormattingEnabled = true;
            this.vonStationCmbBox.Location = new System.Drawing.Point(60, 9);
            this.vonStationCmbBox.Name = "vonStationCmbBox";
            this.vonStationCmbBox.Size = new System.Drawing.Size(121, 21);
            this.vonStationCmbBox.TabIndex = 6;
            this.vonStationCmbBox.TextChanged += new System.EventHandler(this.vonStationCmbBox_TextChanged);
            // 
            // zuStationCmbBox
            // 
            this.zuStationCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.zuStationCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.zuStationCmbBox.FormattingEnabled = true;
            this.zuStationCmbBox.Location = new System.Drawing.Point(354, 9);
            this.zuStationCmbBox.Name = "zuStationCmbBox";
            this.zuStationCmbBox.Size = new System.Drawing.Size(121, 21);
            this.zuStationCmbBox.TabIndex = 7;
            this.zuStationCmbBox.TextChanged += new System.EventHandler(this.zuStationCmbBox_TextChanged);
            // 
            // verbindungenSuchenForm
            // 
            this.AcceptButton = this.verbindungenSuchenBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(506, 412);
            this.Controls.Add(this.zuStationCmbBox);
            this.Controls.Add(this.vonStationCmbBox);
            this.Controls.Add(this.verbindungenListView);
            this.Controls.Add(this.verbindungenSuchenBtn);
            this.Controls.Add(this.zuStationLbl);
            this.Controls.Add(this.vonStandortLbl);
            this.Name = "verbindungenSuchenForm";
            this.Text = "Verbindungen Suchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vonStandortLbl;
        private System.Windows.Forms.Label zuStationLbl;
        private System.Windows.Forms.Button verbindungenSuchenBtn;
        private System.Windows.Forms.ListView verbindungenListView;
        private System.Windows.Forms.ComboBox vonStationCmbBox;
        private System.Windows.Forms.ComboBox zuStationCmbBox;
    }
}