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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.HotelDataGrid = new System.Windows.Forms.DataGridView();
            this.RoomsDataGrid = new System.Windows.Forms.DataGridView();
            this.RadioBox = new System.Windows.Forms.GroupBox();
            this.QuadRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.TripleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.DoubleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.QuadLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TripleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DoubleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SingleRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AnyRadio = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.AnyLabel = new System.Windows.Forms.Label();
            this.ReportButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).BeginInit();
            this.RadioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelDataGrid
            // 
            this.HotelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelDataGrid.Location = new System.Drawing.Point(0, 1);
            this.HotelDataGrid.Name = "HotelDataGrid";
            this.HotelDataGrid.RowTemplate.Height = 24;
            this.HotelDataGrid.Size = new System.Drawing.Size(984, 229);
            this.HotelDataGrid.TabIndex = 1;
            // 
            // RoomsDataGrid
            // 
            this.RoomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGrid.Location = new System.Drawing.Point(0, 365);
            this.RoomsDataGrid.Name = "RoomsDataGrid";
            this.RoomsDataGrid.RowTemplate.Height = 24;
            this.RoomsDataGrid.Size = new System.Drawing.Size(984, 211);
            this.RoomsDataGrid.TabIndex = 2;
            // 
            // RadioBox
            // 
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
            this.RadioBox.Location = new System.Drawing.Point(12, 259);
            this.RadioBox.Name = "RadioBox";
            this.RadioBox.Size = new System.Drawing.Size(972, 100);
            this.RadioBox.TabIndex = 3;
            this.RadioBox.TabStop = false;
            this.RadioBox.Text = "Room Type";
            // 
            // QuadRadio
            // 
            this.QuadRadio.Checked = false;
            this.QuadRadio.Location = new System.Drawing.Point(248, 60);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.OutlineColor = System.Drawing.Color.Purple;
            this.QuadRadio.RadioColor = System.Drawing.Color.Purple;
            this.QuadRadio.Size = new System.Drawing.Size(25, 25);
            this.QuadRadio.TabIndex = 7;
            this.QuadRadio.Text = null;
            // 
            // TripleRadio
            // 
            this.TripleRadio.Checked = false;
            this.TripleRadio.Location = new System.Drawing.Point(174, 60);
            this.TripleRadio.Name = "TripleRadio";
            this.TripleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.TripleRadio.RadioColor = System.Drawing.Color.Purple;
            this.TripleRadio.Size = new System.Drawing.Size(25, 25);
            this.TripleRadio.TabIndex = 6;
            this.TripleRadio.Text = null;
            // 
            // DoubleRadio
            // 
            this.DoubleRadio.Checked = false;
            this.DoubleRadio.Location = new System.Drawing.Point(107, 60);
            this.DoubleRadio.Name = "DoubleRadio";
            this.DoubleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.DoubleRadio.RadioColor = System.Drawing.Color.Purple;
            this.DoubleRadio.Size = new System.Drawing.Size(25, 25);
            this.DoubleRadio.TabIndex = 5;
            this.DoubleRadio.Text = null;
            // 
            // QuadLabel
            // 
            this.QuadLabel.AutoSize = true;
            this.QuadLabel.Location = new System.Drawing.Point(245, 30);
            this.QuadLabel.Name = "QuadLabel";
            this.QuadLabel.Size = new System.Drawing.Size(43, 17);
            this.QuadLabel.TabIndex = 4;
            this.QuadLabel.Text = "Quad";
            // 
            // TripleLabel
            // 
            this.TripleLabel.AutoSize = true;
            this.TripleLabel.Location = new System.Drawing.Point(171, 30);
            this.TripleLabel.Name = "TripleLabel";
            this.TripleLabel.Size = new System.Drawing.Size(44, 17);
            this.TripleLabel.TabIndex = 3;
            this.TripleLabel.Text = "Triple";
            // 
            // DoubleLabel
            // 
            this.DoubleLabel.AutoSize = true;
            this.DoubleLabel.Location = new System.Drawing.Point(94, 30);
            this.DoubleLabel.Name = "DoubleLabel";
            this.DoubleLabel.Size = new System.Drawing.Size(53, 17);
            this.DoubleLabel.TabIndex = 2;
            this.DoubleLabel.Text = "Double";
            // 
            // SingleLabel
            // 
            this.SingleLabel.AutoSize = true;
            this.SingleLabel.Location = new System.Drawing.Point(22, 30);
            this.SingleLabel.Name = "SingleLabel";
            this.SingleLabel.Size = new System.Drawing.Size(47, 17);
            this.SingleLabel.TabIndex = 1;
            this.SingleLabel.Text = "Single";
            // 
            // SingleRadio
            // 
            this.SingleRadio.Checked = false;
            this.SingleRadio.Location = new System.Drawing.Point(34, 60);
            this.SingleRadio.Name = "SingleRadio";
            this.SingleRadio.OutlineColor = System.Drawing.Color.Purple;
            this.SingleRadio.RadioColor = System.Drawing.Color.Purple;
            this.SingleRadio.Size = new System.Drawing.Size(25, 25);
            this.SingleRadio.TabIndex = 0;
            this.SingleRadio.Text = null;
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
            this.LoadButton.Location = new System.Drawing.Point(375, 49);
            this.LoadButton.Name = "LoadButton";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.LoadButton.onHoverState = stateProperties7;
            this.LoadButton.Size = new System.Drawing.Size(210, 45);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AnyRadio
            // 
            this.AnyRadio.Checked = false;
            this.AnyRadio.Location = new System.Drawing.Point(317, 60);
            this.AnyRadio.Name = "AnyRadio";
            this.AnyRadio.OutlineColor = System.Drawing.Color.Purple;
            this.AnyRadio.RadioColor = System.Drawing.Color.Purple;
            this.AnyRadio.Size = new System.Drawing.Size(25, 25);
            this.AnyRadio.TabIndex = 8;
            this.AnyRadio.Text = null;
            // 
            // AnyLabel
            // 
            this.AnyLabel.AutoSize = true;
            this.AnyLabel.Location = new System.Drawing.Point(314, 30);
            this.AnyLabel.Name = "AnyLabel";
            this.AnyLabel.Size = new System.Drawing.Size(32, 17);
            this.AnyLabel.TabIndex = 9;
            this.AnyLabel.Text = "Any";
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
            this.ReportButton.Location = new System.Drawing.Point(678, 49);
            this.ReportButton.Name = "ReportButton";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.ReportButton.onHoverState = stateProperties8;
            this.ReportButton.Size = new System.Drawing.Size(262, 45);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ViewHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 577);
            this.Controls.Add(this.RadioBox);
            this.Controls.Add(this.RoomsDataGrid);
            this.Controls.Add(this.HotelDataGrid);
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
    }
}