
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
            this.abfahrtStationTextBox = new System.Windows.Forms.TextBox();
            this.abfahrtStationSuchenBtn = new System.Windows.Forms.Button();
            this.abfahrtStationListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // abfahrtStationTextBox
            // 
            resources.ApplyResources(this.abfahrtStationTextBox, "abfahrtStationTextBox");
            this.abfahrtStationTextBox.Name = "abfahrtStationTextBox";
            // 
            // abfahrtStationSuchenBtn
            // 
            resources.ApplyResources(this.abfahrtStationSuchenBtn, "abfahrtStationSuchenBtn");
            this.abfahrtStationSuchenBtn.Name = "abfahrtStationSuchenBtn";
            this.abfahrtStationSuchenBtn.UseVisualStyleBackColor = true;
            // 
            // abfahrtStationListView
            // 
            resources.ApplyResources(this.abfahrtStationListView, "abfahrtStationListView");
            this.abfahrtStationListView.HideSelection = false;
            this.abfahrtStationListView.Name = "abfahrtStationListView";
            this.abfahrtStationListView.UseCompatibleStateImageBehavior = false;
            // 
            // AbfahrtstafelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.abfahrtStationListView);
            this.Controls.Add(this.abfahrtStationSuchenBtn);
            this.Controls.Add(this.abfahrtStationTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AbfahrtstafelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox abfahrtStationTextBox;
        private System.Windows.Forms.Button abfahrtStationSuchenBtn;
        private System.Windows.Forms.ListView abfahrtStationListView;
    }
}