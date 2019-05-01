namespace Trivago.Forms
{
    partial class ViewCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.usersDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.reportBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowCustomTheming = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.usersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.usersDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.usersDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.usersDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.usersDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.usersDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.usersDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.usersDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.usersDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.usersDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.usersDataGrid.CurrentTheme.Name = null;
            this.usersDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.usersDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.usersDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.usersDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.usersDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.usersDataGrid.EnableHeadersVisualStyles = false;
            this.usersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.usersDataGrid.HeaderBackColor = System.Drawing.Color.SteelBlue;
            this.usersDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.usersDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.usersDataGrid.Location = new System.Drawing.Point(16, 43);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowHeadersVisible = false;
            this.usersDataGrid.RowTemplate.Height = 40;
            this.usersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGrid.Size = new System.Drawing.Size(610, 228);
            this.usersDataGrid.TabIndex = 3;
            this.usersDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // reportBTN
            // 
            this.reportBTN.Active = true;
            this.reportBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.reportBTN.BackColor = System.Drawing.Color.White;
            this.reportBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportBTN.BorderRadius = 0;
            this.reportBTN.ButtonText = "Generate Report";
            this.reportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBTN.DisabledColor = System.Drawing.Color.Gray;
            this.reportBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.reportBTN.Iconimage = null;
            this.reportBTN.Iconimage_right = null;
            this.reportBTN.Iconimage_right_Selected = null;
            this.reportBTN.Iconimage_Selected = null;
            this.reportBTN.IconMarginLeft = 0;
            this.reportBTN.IconMarginRight = 0;
            this.reportBTN.IconRightVisible = true;
            this.reportBTN.IconRightZoom = 0D;
            this.reportBTN.IconVisible = true;
            this.reportBTN.IconZoom = 90D;
            this.reportBTN.IsTab = false;
            this.reportBTN.Location = new System.Drawing.Point(247, 275);
            this.reportBTN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reportBTN.Name = "reportBTN";
            this.reportBTN.Normalcolor = System.Drawing.Color.White;
            this.reportBTN.OnHovercolor = System.Drawing.Color.White;
            this.reportBTN.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.reportBTN.selected = true;
            this.reportBTN.Size = new System.Drawing.Size(165, 45);
            this.reportBTN.TabIndex = 30;
            this.reportBTN.Text = "Generate Report";
            this.reportBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportBTN.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.reportBTN.TextFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBTN.Click += new System.EventHandler(this.reportBTN_Click_1);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(19, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(157, 25);
            this.bunifuLabel1.TabIndex = 32;
            this.bunifuLabel1.Text = "View Customers";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(589, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 31;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(642, 326);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.reportBTN);
            this.Controls.Add(this.usersDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCustomers";
            this.Load += new System.EventHandler(this.ViewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView usersDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton reportBTN;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}