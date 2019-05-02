namespace Trivago.Forms
{
    partial class ViewHotels
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
            this.RoomsDataGrid = new System.Windows.Forms.DataGridView();
            this.RadioBox = new System.Windows.Forms.GroupBox();
            this.LoadButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReportButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HotelRating = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AnyLabel = new System.Windows.Forms.Label();
            this.AnyRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.QuadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.TripleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.DoubleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.QuadLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TripleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DoubleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.HotelDataGrid = new System.Windows.Forms.DataGridView();
            this.HotelRatingError = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).BeginInit();
            this.RadioBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRatingError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsDataGrid
            // 
            this.RoomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGrid.Location = new System.Drawing.Point(-1, 431);
            this.RoomsDataGrid.Name = "RoomsDataGrid";
            this.RoomsDataGrid.RowTemplate.Height = 24;
            this.RoomsDataGrid.Size = new System.Drawing.Size(641, 166);
            this.RoomsDataGrid.TabIndex = 2;
            this.RoomsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGrid_CellContentClick);
            // 
            // RadioBox
            // 
            this.RadioBox.Controls.Add(this.LoadButton);
            this.RadioBox.Controls.Add(this.ReportButton);
            this.RadioBox.Controls.Add(this.HotelRating);
            this.RadioBox.Controls.Add(this.AnyLabel);
            this.RadioBox.Controls.Add(this.AnyRadio);
            this.RadioBox.Controls.Add(this.QuadRadio);
            this.RadioBox.Controls.Add(this.TripleRadio);
            this.RadioBox.Controls.Add(this.DoubleRadio);
            this.RadioBox.Controls.Add(this.QuadLabel);
            this.RadioBox.Controls.Add(this.TripleLabel);
            this.RadioBox.Controls.Add(this.DoubleLabel);
            this.RadioBox.Controls.Add(this.SingleLabel);
            this.RadioBox.Controls.Add(this.SingleRadio);
            this.RadioBox.ForeColor = System.Drawing.Color.White;
            this.RadioBox.Location = new System.Drawing.Point(0, 274);
            this.RadioBox.Name = "RadioBox";
            this.RadioBox.Size = new System.Drawing.Size(640, 157);
            this.RadioBox.TabIndex = 3;
            this.RadioBox.TabStop = false;
            this.RadioBox.Text = "Room Type";
            // 
            // LoadButton
            // 
            this.LoadButton.Active = true;
            this.LoadButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.LoadButton.BackColor = System.Drawing.Color.White;
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadButton.BorderRadius = 0;
            this.LoadButton.ButtonText = "Load Room Type";
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.DisabledColor = System.Drawing.Color.Gray;
            this.LoadButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LoadButton.Iconimage = null;
            this.LoadButton.Iconimage_right = null;
            this.LoadButton.Iconimage_right_Selected = null;
            this.LoadButton.Iconimage_Selected = null;
            this.LoadButton.IconMarginLeft = 0;
            this.LoadButton.IconMarginRight = 0;
            this.LoadButton.IconRightVisible = true;
            this.LoadButton.IconRightZoom = 0D;
            this.LoadButton.IconVisible = true;
            this.LoadButton.IconZoom = 90D;
            this.LoadButton.IsTab = false;
            this.LoadButton.Location = new System.Drawing.Point(43, 94);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Normalcolor = System.Drawing.Color.White;
            this.LoadButton.OnHovercolor = System.Drawing.Color.White;
            this.LoadButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.LoadButton.selected = true;
            this.LoadButton.Size = new System.Drawing.Size(262, 55);
            this.LoadButton.TabIndex = 32;
            this.LoadButton.Text = "Load Room Type";
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.LoadButton.TextFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Active = true;
            this.ReportButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ReportButton.BackColor = System.Drawing.Color.White;
            this.ReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportButton.BorderRadius = 0;
            this.ReportButton.ButtonText = "Generate Report";
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReportButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReportButton.Iconimage = null;
            this.ReportButton.Iconimage_right = null;
            this.ReportButton.Iconimage_right_Selected = null;
            this.ReportButton.Iconimage_Selected = null;
            this.ReportButton.IconMarginLeft = 0;
            this.ReportButton.IconMarginRight = 0;
            this.ReportButton.IconRightVisible = true;
            this.ReportButton.IconRightZoom = 0D;
            this.ReportButton.IconVisible = true;
            this.ReportButton.IconZoom = 90D;
            this.ReportButton.IsTab = false;
            this.ReportButton.Location = new System.Drawing.Point(904, 94);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Normalcolor = System.Drawing.Color.White;
            this.ReportButton.OnHovercolor = System.Drawing.Color.White;
            this.ReportButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ReportButton.selected = true;
            this.ReportButton.Size = new System.Drawing.Size(262, 55);
            this.ReportButton.TabIndex = 31;
            this.ReportButton.Text = "Generate Report";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ReportButton.TextFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // HotelRating
            // 
            this.HotelRating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelRating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelRating.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.HotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelRating.HintForeColor = System.Drawing.Color.White;
            this.HotelRating.HintText = "Insert Hotel Rating";
            this.HotelRating.isPassword = false;
            this.HotelRating.LineFocusedColor = System.Drawing.Color.Blue;
            this.HotelRating.LineIdleColor = System.Drawing.Color.Gray;
            this.HotelRating.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.HotelRating.LineThickness = 3;
            this.HotelRating.Location = new System.Drawing.Point(949, 27);
            this.HotelRating.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelRating.MaxLength = 32767;
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(349, 41);
            this.HotelRating.TabIndex = 10;
            this.HotelRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AnyLabel
            // 
            this.AnyLabel.AutoSize = true;
            this.AnyLabel.ForeColor = System.Drawing.Color.White;
            this.AnyLabel.Location = new System.Drawing.Point(409, 27);
            this.AnyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnyLabel.Name = "AnyLabel";
            this.AnyLabel.Size = new System.Drawing.Size(32, 17);
            this.AnyLabel.TabIndex = 9;
            this.AnyLabel.Text = "Any";
            // 
            // AnyRadio
            // 
            this.AnyRadio.Checked = false;
            this.AnyRadio.Location = new System.Drawing.Point(413, 64);
            this.AnyRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnyRadio.Name = "AnyRadio";
            this.AnyRadio.OutlineColor = System.Drawing.Color.White;
            this.AnyRadio.RadioColor = System.Drawing.Color.White;
            this.AnyRadio.Size = new System.Drawing.Size(33, 31);
            this.AnyRadio.TabIndex = 8;
            this.AnyRadio.Text = null;
            // 
            // QuadRadio
            // 
            this.QuadRadio.Checked = false;
            this.QuadRadio.Location = new System.Drawing.Point(321, 64);
            this.QuadRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.OutlineColor = System.Drawing.Color.White;
            this.QuadRadio.RadioColor = System.Drawing.Color.White;
            this.QuadRadio.Size = new System.Drawing.Size(33, 31);
            this.QuadRadio.TabIndex = 7;
            this.QuadRadio.Text = null;
            // 
            // TripleRadio
            // 
            this.TripleRadio.Checked = false;
            this.TripleRadio.Location = new System.Drawing.Point(223, 64);
            this.TripleRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TripleRadio.Name = "TripleRadio";
            this.TripleRadio.OutlineColor = System.Drawing.Color.White;
            this.TripleRadio.RadioColor = System.Drawing.Color.White;
            this.TripleRadio.Size = new System.Drawing.Size(33, 31);
            this.TripleRadio.TabIndex = 6;
            this.TripleRadio.Text = null;
            // 
            // DoubleRadio
            // 
            this.DoubleRadio.Checked = false;
            this.DoubleRadio.Location = new System.Drawing.Point(133, 64);
            this.DoubleRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleRadio.Name = "DoubleRadio";
            this.DoubleRadio.OutlineColor = System.Drawing.Color.White;
            this.DoubleRadio.RadioColor = System.Drawing.Color.White;
            this.DoubleRadio.Size = new System.Drawing.Size(33, 31);
            this.DoubleRadio.TabIndex = 5;
            this.DoubleRadio.Text = null;
            // 
            // QuadLabel
            // 
            this.QuadLabel.AutoSize = true;
            this.QuadLabel.ForeColor = System.Drawing.Color.White;
            this.QuadLabel.Location = new System.Drawing.Point(317, 27);
            this.QuadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuadLabel.Name = "QuadLabel";
            this.QuadLabel.Size = new System.Drawing.Size(43, 17);
            this.QuadLabel.TabIndex = 4;
            this.QuadLabel.Text = "Quad";
            // 
            // TripleLabel
            // 
            this.TripleLabel.AutoSize = true;
            this.TripleLabel.ForeColor = System.Drawing.Color.White;
            this.TripleLabel.Location = new System.Drawing.Point(219, 27);
            this.TripleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TripleLabel.Name = "TripleLabel";
            this.TripleLabel.Size = new System.Drawing.Size(44, 17);
            this.TripleLabel.TabIndex = 3;
            this.TripleLabel.Text = "Triple";
            // 
            // DoubleLabel
            // 
            this.DoubleLabel.AutoSize = true;
            this.DoubleLabel.ForeColor = System.Drawing.Color.White;
            this.DoubleLabel.Location = new System.Drawing.Point(116, 27);
            this.DoubleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoubleLabel.Name = "DoubleLabel";
            this.DoubleLabel.Size = new System.Drawing.Size(53, 17);
            this.DoubleLabel.TabIndex = 2;
            this.DoubleLabel.Text = "Double";
            // 
            // SingleLabel
            // 
            this.SingleLabel.AutoSize = true;
            this.SingleLabel.ForeColor = System.Drawing.Color.White;
            this.SingleLabel.Location = new System.Drawing.Point(20, 27);
            this.SingleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SingleLabel.Name = "SingleLabel";
            this.SingleLabel.Size = new System.Drawing.Size(47, 17);
            this.SingleLabel.TabIndex = 1;
            this.SingleLabel.Text = "Single";
            // 
            // SingleRadio
            // 
            this.SingleRadio.Checked = true;
            this.SingleRadio.Location = new System.Drawing.Point(36, 64);
            this.SingleRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleRadio.Name = "SingleRadio";
            this.SingleRadio.OutlineColor = System.Drawing.Color.White;
            this.SingleRadio.RadioColor = System.Drawing.Color.White;
            this.SingleRadio.Size = new System.Drawing.Size(33, 31);
            this.SingleRadio.TabIndex = 0;
            this.SingleRadio.Text = null;
            // 
            // HotelDataGrid
            // 
            this.HotelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelDataGrid.Location = new System.Drawing.Point(2, 53);
            this.HotelDataGrid.Name = "HotelDataGrid";
            this.HotelDataGrid.RowTemplate.Height = 24;
            this.HotelDataGrid.Size = new System.Drawing.Size(638, 220);
            this.HotelDataGrid.TabIndex = 33;
            this.HotelDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HotelDataGrid_CellContentClick);
            // 
            // HotelRatingError
            // 
            this.HotelRatingError.ContainerControl = this;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 23;
            this.bunifuPictureBox2.Image = global::Trivago.Properties.Resources.bk;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(2, 9);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(46, 46);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 73;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(594, 9);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 74;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // ViewHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(644, 594);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuPictureBox2);
            this.Controls.Add(this.HotelDataGrid);
            this.Controls.Add(this.RadioBox);
            this.Controls.Add(this.RoomsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHotels";
            this.Load += new System.EventHandler(this.ViewHotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).EndInit();
            this.RadioBox.ResumeLayout(false);
            this.RadioBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRatingError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RoomsDataGrid;
        private System.Windows.Forms.GroupBox RadioBox;
        private Bunifu.UI.WinForms.BunifuRadioButton QuadRadio;
        private Bunifu.UI.WinForms.BunifuRadioButton TripleRadio;
        private Bunifu.UI.WinForms.BunifuRadioButton DoubleRadio;
        private Bunifu.Framework.UI.BunifuCustomLabel QuadLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel TripleLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel DoubleLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel SingleLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton SingleRadio;
        private System.Windows.Forms.Label AnyLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton AnyRadio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelRating;
        private Bunifu.Framework.UI.BunifuFlatButton ReportButton;
        private Bunifu.Framework.UI.BunifuFlatButton LoadButton;
        private System.Windows.Forms.DataGridView HotelDataGrid;
        private System.Windows.Forms.ErrorProvider HotelRatingError;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}