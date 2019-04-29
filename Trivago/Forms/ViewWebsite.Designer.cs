namespace Trivago.Forms
{
    partial class ViewWebsite
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWebsite));
            this.dgview = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.view = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.generate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pb2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.ViewWebsiteTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview
            // 
            this.dgview.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgview.ColumnHeadersHeight = 40;
            this.dgview.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.dgview.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgview.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgview.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgview.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgview.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgview.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgview.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgview.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgview.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgview.CurrentTheme.Name = null;
            this.dgview.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgview.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgview.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgview.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgview.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgview.EnableHeadersVisualStyles = false;
            this.dgview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgview.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgview.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgview.HeaderForeColor = System.Drawing.Color.White;
            this.dgview.Location = new System.Drawing.Point(0, 93);
            this.dgview.Name = "dgview";
            this.dgview.RowHeadersVisible = false;
            this.dgview.RowTemplate.Height = 40;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview.Size = new System.Drawing.Size(611, 306);
            this.dgview.TabIndex = 0;
            this.dgview.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // view
            // 
            this.view.ActiveBorderThickness = 1;
            this.view.ActiveCornerRadius = 20;
            this.view.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.view.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.view.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view.BackgroundImage")));
            this.view.ButtonText = "View";
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.view.IdleBorderThickness = 1;
            this.view.IdleCornerRadius = 20;
            this.view.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.view.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.view.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.view.Location = new System.Drawing.Point(97, 439);
            this.view.Margin = new System.Windows.Forms.Padding(5);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(181, 41);
            this.view.TabIndex = 2;
            this.view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuPictureBox1.BorderRadius = 55;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(479, -19);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(110, 110);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(11, 63);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(124, 26);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "View websites";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // generate
            // 
            this.generate.ActiveBorderThickness = 1;
            this.generate.ActiveCornerRadius = 20;
            this.generate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.generate.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.generate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generate.BackgroundImage")));
            this.generate.ButtonText = "Generate report";
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.generate.IdleBorderThickness = 1;
            this.generate.IdleCornerRadius = 20;
            this.generate.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.generate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.generate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.generate.Location = new System.Drawing.Point(308, 439);
            this.generate.Margin = new System.Windows.Forms.Padding(5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(181, 41);
            this.generate.TabIndex = 8;
            this.generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.pb2.BorderRadius = 5;
            this.pb2.Location = new System.Drawing.Point(0, 2);
            this.pb2.MaximumValue = 100;
            this.pb2.Name = "pb2";
            this.pb2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pb2.Size = new System.Drawing.Size(610, 11);
            this.pb2.TabIndex = 9;
            this.pb2.Value = 0;
            // 
            // ViewWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(612, 505);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.dgview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewWebsite";
            this.Load += new System.EventHandler(this.ViewWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgview;
        private Bunifu.Framework.UI.BunifuThinButton2 view;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 generate;
        private Bunifu.Framework.UI.BunifuProgressBar pb2;
        private System.Windows.Forms.Timer ViewWebsiteTimer;
    }
}