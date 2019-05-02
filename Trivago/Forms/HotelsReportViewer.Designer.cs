namespace Trivago.Forms
{
    partial class HotelsReportViewer
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
            this.ViewHotels = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ViewHotels
            // 
            this.ViewHotels.ActiveViewIndex = -1;
            this.ViewHotels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewHotels.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewHotels.Location = new System.Drawing.Point(0, 0);
            this.ViewHotels.Name = "ViewHotels";
            this.ViewHotels.Size = new System.Drawing.Size(1119, 551);
            this.ViewHotels.TabIndex = 0;
            // 
            // HotelsReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 551);
            this.Controls.Add(this.ViewHotels);
            this.Name = "HotelsReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelsReportViewer";
            this.Load += new System.EventHandler(this.HotelsReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewHotels;
    }
}