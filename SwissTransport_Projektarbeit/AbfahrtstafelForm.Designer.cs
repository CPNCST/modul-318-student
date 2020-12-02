
namespace SwissTransport_Projektarbeit
{
    partial class AbfahrtstafelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbfahrtstafelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.abfahrtStationSuchenBtn = new System.Windows.Forms.Button();
            this.abfahrtStationListView = new System.Windows.Forms.ListView();
            this.abfahrtStationCmbBox = new System.Windows.Forms.ComboBox();
            this.positionFindenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // abfahrtStationSuchenBtn
            // 
            resources.ApplyResources(this.abfahrtStationSuchenBtn, "abfahrtStationSuchenBtn");
            this.abfahrtStationSuchenBtn.Name = "abfahrtStationSuchenBtn";
            this.abfahrtStationSuchenBtn.UseVisualStyleBackColor = true;
            this.abfahrtStationSuchenBtn.Click += new System.EventHandler(this.abfahrtStationSuchenBtn_Click);
            // 
            // abfahrtStationListView
            // 
            resources.ApplyResources(this.abfahrtStationListView, "abfahrtStationListView");
            this.abfahrtStationListView.HideSelection = false;
            this.abfahrtStationListView.Name = "abfahrtStationListView";
            this.abfahrtStationListView.UseCompatibleStateImageBehavior = false;
            // 
            // abfahrtStationCmbBox
            // 
            this.abfahrtStationCmbBox.FormattingEnabled = true;
            resources.ApplyResources(this.abfahrtStationCmbBox, "abfahrtStationCmbBox");
            this.abfahrtStationCmbBox.Name = "abfahrtStationCmbBox";
            this.abfahrtStationCmbBox.TextUpdate += new System.EventHandler(this.abfahrtStationCmbBox_TextUpdate);
            // 
            // positionFindenBtn
            // 
            resources.ApplyResources(this.positionFindenBtn, "positionFindenBtn");
            this.positionFindenBtn.Name = "positionFindenBtn";
            this.positionFindenBtn.UseVisualStyleBackColor = true;
            this.positionFindenBtn.Click += new System.EventHandler(this.positionFindenBtn_Click);
            // 
            // AbfahrtstafelForm
            // 
            this.AcceptButton = this.abfahrtStationSuchenBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.positionFindenBtn);
            this.Controls.Add(this.abfahrtStationCmbBox);
            this.Controls.Add(this.abfahrtStationListView);
            this.Controls.Add(this.abfahrtStationSuchenBtn);
            this.Controls.Add(this.label1);
            this.Name = "AbfahrtstafelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button abfahrtStationSuchenBtn;
        private System.Windows.Forms.ListView abfahrtStationListView;
        private System.Windows.Forms.ComboBox abfahrtStationCmbBox;
        private System.Windows.Forms.Button positionFindenBtn;
    }
}