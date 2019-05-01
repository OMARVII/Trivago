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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHotels));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.HotelDataGrid = new System.Windows.Forms.DataGridView();
            this.RoomsDataGrid = new System.Windows.Forms.DataGridView();
            this.RadioBox = new System.Windows.Forms.GroupBox();
            this.HotelRating = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ReportButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).BeginInit();
            this.RadioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelDataGrid
            // 
            this.HotelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelDataGrid.Location = new System.Drawing.Point(0, 1);
            this.HotelDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HotelDataGrid.Name = "HotelDataGrid";
            this.HotelDataGrid.RowTemplate.Height = 24;
            this.HotelDataGrid.Size = new System.Drawing.Size(738, 186);
            this.HotelDataGrid.TabIndex = 1;
            // 
            // RoomsDataGrid
            // 
            this.RoomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGrid.Location = new System.Drawing.Point(0, 297);
            this.RoomsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomsDataGrid.Name = "RoomsDataGrid";
            this.RoomsDataGrid.RowTemplate.Height = 24;
            this.RoomsDataGrid.Size = new System.Drawing.Size(738, 171);
            this.RoomsDataGrid.TabIndex = 2;
            this.RoomsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGrid_CellContentClick);
            // 
            // RadioBox
            // 
            this.RadioBox.Controls.Add(this.HotelRating);
            this.RadioBox.Controls.Add(this.ReportButton);
            this.RadioBox.Controls.Add(this.LoadButton);
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
            this.RadioBox.Location = new System.Drawing.Point(9, 210);
            this.RadioBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioBox.Name = "RadioBox";
            this.RadioBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioBox.Size = new System.Drawing.Size(729, 81);
            this.RadioBox.TabIndex = 3;
            this.RadioBox.TabStop = false;
            this.RadioBox.Text = "Room Type";
            // 
            // HotelRating
            // 
            this.HotelRating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelRating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelRating.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.HotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelRating.HintForeColor = System.Drawing.Color.Empty;
            this.HotelRating.HintText = "Insert Hotel Rating";
            this.HotelRating.isPassword = false;
            this.HotelRating.LineFocusedColor = System.Drawing.Color.Blue;
            this.HotelRating.LineIdleColor = System.Drawing.Color.Gray;
            this.HotelRating.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.HotelRating.LineThickness = 3;
            this.HotelRating.Location = new System.Drawing.Point(508, 7);
            this.HotelRating.MaxLength = 32767;
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(196, 27);
            this.HotelRating.TabIndex = 10;
            this.HotelRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReportButton.BackgroundImage")));
            this.ReportButton.ButtonText = "Generate Hotels Report";
            this.ReportButton.ButtonTextMarginLeft = 0;
            this.ReportButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ReportButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.ReportButton.DisabledForecolor = System.Drawing.Color.White;
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ReportButton.IconPadding = 10;
            this.ReportButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ReportButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ReportButton.IdleBorderRadius = 1;
            this.ReportButton.IdleBorderThickness = 0;
            this.ReportButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ReportButton.IdleIconLeftImage = null;
            this.ReportButton.IdleIconRightImage = null;
            this.ReportButton.Location = new System.Drawing.Point(508, 40);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportButton.Name = "ReportButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ReportButton.onHoverState = stateProperties1;
            this.ReportButton.Size = new System.Drawing.Size(196, 37);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadButton.BackgroundImage")));
            this.LoadButton.ButtonText = "Load";
            this.LoadButton.ButtonTextMarginLeft = 0;
            this.LoadButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LoadButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.LoadButton.DisabledForecolor = System.Drawing.Color.White;
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoadButton.IconPadding = 10;
            this.LoadButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoadButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LoadButton.IdleBorderRadius = 1;
            this.LoadButton.IdleBorderThickness = 0;
            this.LoadButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LoadButton.IdleIconLeftImage = null;
            this.LoadButton.IdleIconRightImage = null;
            this.LoadButton.Location = new System.Drawing.Point(281, 40);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadButton.Name = "LoadButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.LoadButton.onHoverState = stateProperties2;
            this.LoadButton.Size = new System.Drawing.Size(158, 37);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AnyLabel
            // 
            this.AnyLabel.AutoSize = true;
            this.AnyLabel.Location = new System.Drawing.Point(236, 24);
            this.AnyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnyLabel.Name = "AnyLabel";
            this.AnyLabel.Size = new System.Drawing.Size(25, 13);
            this.AnyLabel.TabIndex = 9;
            this.AnyLabel.Text = "Any";
            // 
            // AnyRadio
            // 
            this.AnyRadio.Checked = false;
            this.AnyRadio.Location = new System.Drawing.Point(238, 49);
            this.AnyRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnyRadio.Name = "AnyRadio";
            this.AnyRadio.OutlineColor = System.Drawing.Color.Purple;
            this.AnyRadio.RadioColor = System.Drawing.Color.Purple;
            this.AnyRadio.Size = new System.Drawing.Size(19, 19);
            this.AnyRadio.TabIndex = 8;
            this.AnyRadio.Text = null;
            // 
            // QuadRadio
            // 
            this.QuadRadio.Checked = false;
            this.QuadRadio.Location = new System.Drawing.Point(186, 49);
            this.QuadRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.OutlineColor = System.Drawing.Color.Purple;
            this.QuadRadio.RadioColor = System.Drawing.Color.Purple;
            this.QuadRadio.Size = new System.Drawing.Size(19, 19);
            this.QuadRadio.TabIndex = 7;
            this.QuadRadio.Text = null;
            // 
            // TripleRadio
            // 
            this.TripleRadio.Checked = false;
            this.TripleRadio.Location = new System.Drawing.Point(130, 49);
            this.TripleRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TripleRadio.Name = "TripleRadio";
            this.TripleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.TripleRadio.RadioColor = System.Drawing.Color.Purple;
            this.TripleRadio.Size = new System.Drawing.Size(19, 19);
            this.TripleRadio.TabIndex = 6;
            this.TripleRadio.Text = null;
            // 
            // DoubleRadio
            // 
            this.DoubleRadio.Checked = false;
            this.DoubleRadio.Location = new System.Drawing.Point(80, 49);
            this.DoubleRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoubleRadio.Name = "DoubleRadio";
            this.DoubleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.DoubleRadio.RadioColor = System.Drawing.Color.Purple;
            this.DoubleRadio.Size = new System.Drawing.Size(19, 19);
            this.DoubleRadio.TabIndex = 5;
            this.DoubleRadio.Text = null;
            // 
            // QuadLabel
            // 
            this.QuadLabel.AutoSize = true;
            this.QuadLabel.Location = new System.Drawing.Point(184, 24);
            this.QuadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuadLabel.Name = "QuadLabel";
            this.QuadLabel.Size = new System.Drawing.Size(33, 13);
            this.QuadLabel.TabIndex = 4;
            this.QuadLabel.Text = "Quad";
            // 
            // TripleLabel
            // 
            this.TripleLabel.AutoSize = true;
            this.TripleLabel.Location = new System.Drawing.Point(128, 24);
            this.TripleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TripleLabel.Name = "TripleLabel";
            this.TripleLabel.Size = new System.Drawing.Size(33, 13);
            this.TripleLabel.TabIndex = 3;
            this.TripleLabel.Text = "Triple";
            // 
            // DoubleLabel
            // 
            this.DoubleLabel.AutoSize = true;
            this.DoubleLabel.Location = new System.Drawing.Point(70, 24);
            this.DoubleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoubleLabel.Name = "DoubleLabel";
            this.DoubleLabel.Size = new System.Drawing.Size(41, 13);
            this.DoubleLabel.TabIndex = 2;
            this.DoubleLabel.Text = "Double";
            // 
            // SingleLabel
            // 
            this.SingleLabel.AutoSize = true;
            this.SingleLabel.Location = new System.Drawing.Point(16, 24);
            this.SingleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SingleLabel.Name = "SingleLabel";
            this.SingleLabel.Size = new System.Drawing.Size(36, 13);
            this.SingleLabel.TabIndex = 1;
            this.SingleLabel.Text = "Single";
            // 
            // SingleRadio
            // 
            this.SingleRadio.Checked = true;
            this.SingleRadio.Location = new System.Drawing.Point(26, 49);
            this.SingleRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SingleRadio.Name = "SingleRadio";
            this.SingleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.SingleRadio.RadioColor = System.Drawing.Color.Purple;
            this.SingleRadio.Size = new System.Drawing.Size(19, 19);
            this.SingleRadio.TabIndex = 0;
            this.SingleRadio.Text = null;
            // 
            // ViewHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 469);
            this.Controls.Add(this.RadioBox);
            this.Controls.Add(this.RoomsDataGrid);
            this.Controls.Add(this.HotelDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewHotels";
            this.Text = "ViewHotels";
            this.Load += new System.EventHandler(this.ViewHotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).EndInit();
            this.RadioBox.ResumeLayout(false);
            this.RadioBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView HotelDataGrid;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoadButton;
        private System.Windows.Forms.Label AnyLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton AnyRadio;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ReportButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelRating;
    }
}