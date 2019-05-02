namespace Trivago.Forms
{
    partial class ReserveRoom
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveRoom));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.SearchTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DisplayPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.tempPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.WebsiteName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoomPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelLocation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoomType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoomId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelRating = new Bunifu.Framework.UI.BunifuRating();
            this.HotelName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoomTypeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoomTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.reserveFromLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reserveToLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.reserveTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.reserveFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.DisplayPanel.SuspendLayout();
            this.tempPanel.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTextbox.HintText = "Enter Hotel name or country or city or street";
            this.SearchTextbox.isPassword = false;
            this.SearchTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTextbox.LineThickness = 3;
            this.SearchTextbox.Location = new System.Drawing.Point(10, 28);
            this.SearchTextbox.MaxLength = 32767;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(272, 26);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTextbox.OnValueChanged += new System.EventHandler(this.SearchTextbox_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 11);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Search :";
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.AutoScroll = true;
            this.DisplayPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.DisplayPanel.Controls.Add(this.tempPanel);
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 181);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.PanelColor = System.Drawing.Color.Empty;
            this.DisplayPanel.ShadowDept = 2;
            this.DisplayPanel.ShadowTopLeftVisible = false;
            this.DisplayPanel.Size = new System.Drawing.Size(964, 421);
            this.DisplayPanel.TabIndex = 2;
            this.DisplayPanel.Tag = "main";
            // 
            // tempPanel
            // 
            this.tempPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.tempPanel.Controls.Add(this.bunifuShadowPanel2);
            this.tempPanel.Controls.Add(this.bunifuShadowPanel1);
            this.tempPanel.Controls.Add(this.HotelLocation);
            this.tempPanel.Controls.Add(this.RoomType);
            this.tempPanel.Controls.Add(this.RoomId);
            this.tempPanel.Controls.Add(this.HotelRating);
            this.tempPanel.Controls.Add(this.HotelName);
            this.tempPanel.Location = new System.Drawing.Point(2, 6);
            this.tempPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.PanelColor = System.Drawing.Color.Empty;
            this.tempPanel.ShadowDept = 2;
            this.tempPanel.ShadowTopLeftVisible = false;
            this.tempPanel.Size = new System.Drawing.Size(952, 110);
            this.tempPanel.TabIndex = 0;
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel2.Controls.Add(this.bunifuButton1);
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(710, 7);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(241, 104);
            this.bunifuShadowPanel2.TabIndex = 8;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuShadowPanel1.Controls.Add(this.WebsiteName);
            this.bunifuShadowPanel1.Controls.Add(this.RoomPrice);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(428, 4);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(278, 110);
            this.bunifuShadowPanel1.TabIndex = 7;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(110, 41);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "bunifuCustomLabel3";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(2, 40);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "bunifuCustomLabel2";
            // 
            // WebsiteName
            // 
            this.WebsiteName.AutoSize = true;
            this.WebsiteName.Location = new System.Drawing.Point(3, 7);
            this.WebsiteName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.Size = new System.Drawing.Size(74, 13);
            this.WebsiteName.TabIndex = 6;
            this.WebsiteName.Text = "WebsiteName";
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSize = true;
            this.RoomPrice.Location = new System.Drawing.Point(143, 7);
            this.RoomPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Size = new System.Drawing.Size(59, 13);
            this.RoomPrice.TabIndex = 5;
            this.RoomPrice.Text = "RoomPrice";
            // 
            // HotelLocation
            // 
            this.HotelLocation.AutoSize = true;
            this.HotelLocation.Location = new System.Drawing.Point(2, 74);
            this.HotelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HotelLocation.Name = "HotelLocation";
            this.HotelLocation.Size = new System.Drawing.Size(73, 13);
            this.HotelLocation.TabIndex = 4;
            this.HotelLocation.Text = "HotelLocation";
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.Location = new System.Drawing.Point(225, 41);
            this.RoomType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(62, 13);
            this.RoomType.TabIndex = 3;
            this.RoomType.Text = "Room Type";
            // 
            // RoomId
            // 
            this.RoomId.AutoSize = true;
            this.RoomId.Location = new System.Drawing.Point(225, 7);
            this.RoomId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(49, 13);
            this.RoomId.TabIndex = 2;
            this.RoomId.Text = "Room ID";
            // 
            // HotelRating
            // 
            this.HotelRating.BackColor = System.Drawing.Color.Transparent;
            this.HotelRating.ForeColor = System.Drawing.Color.SeaGreen;
            this.HotelRating.Location = new System.Drawing.Point(3, 32);
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(180, 32);
            this.HotelRating.TabIndex = 1;
            this.HotelRating.Value = 0;
            // 
            // HotelName
            // 
            this.HotelName.AutoSize = true;
            this.HotelName.Location = new System.Drawing.Point(3, 7);
            this.HotelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(60, 13);
            this.HotelName.TabIndex = 0;
            this.HotelName.Text = "HotelName";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(735, 11);
            this.RoomTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.RoomTypeLabel.TabIndex = 4;
            this.RoomTypeLabel.Text = "Room Type :";
            // 
            // RoomTypeDropdown
            // 
            this.RoomTypeDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.RoomTypeDropdown.BorderRadius = 1;
            this.RoomTypeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.RoomTypeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.RoomTypeDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.RoomTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.RoomTypeDropdown.FillDropDown = false;
            this.RoomTypeDropdown.FillIndicator = false;
            this.RoomTypeDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomTypeDropdown.ForeColor = System.Drawing.Color.Purple;
            this.RoomTypeDropdown.FormattingEnabled = true;
            this.RoomTypeDropdown.Icon = null;
            this.RoomTypeDropdown.IndicatorColor = System.Drawing.Color.Purple;
            this.RoomTypeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.RoomTypeDropdown.ItemBackColor = System.Drawing.Color.White;
            this.RoomTypeDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.RoomTypeDropdown.ItemForeColor = System.Drawing.Color.Purple;
            this.RoomTypeDropdown.ItemHeight = 26;
            this.RoomTypeDropdown.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.RoomTypeDropdown.Location = new System.Drawing.Point(737, 28);
            this.RoomTypeDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomTypeDropdown.Name = "RoomTypeDropdown";
            this.RoomTypeDropdown.Size = new System.Drawing.Size(164, 32);
            this.RoomTypeDropdown.TabIndex = 5;
            this.RoomTypeDropdown.Text = null;
            this.RoomTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.RoomTypeDropdown_SelectedIndexChanged);
            // 
            // reserveFromLabel
            // 
            this.reserveFromLabel.AutoSize = true;
            this.reserveFromLabel.Location = new System.Drawing.Point(322, 11);
            this.reserveFromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserveFromLabel.Name = "reserveFromLabel";
            this.reserveFromLabel.Size = new System.Drawing.Size(79, 13);
            this.reserveFromLabel.TabIndex = 9;
            this.reserveFromLabel.Text = "Reserve From :";
            // 
            // reserveToLabel
            // 
            this.reserveToLabel.AutoSize = true;
            this.reserveToLabel.Location = new System.Drawing.Point(529, 11);
            this.reserveToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserveToLabel.Name = "reserveToLabel";
            this.reserveToLabel.Size = new System.Drawing.Size(69, 13);
            this.reserveToLabel.TabIndex = 10;
            this.reserveToLabel.Text = "Reserve To :";
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "feedback";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(459, 99);
            this.bunifuButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties2;
            this.bunifuButton2.Size = new System.Drawing.Size(236, 37);
            this.bunifuButton2.TabIndex = 9;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(712, 98);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 68;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // reserveTo
            // 
            this.reserveTo.BorderRadius = 1;
            this.reserveTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.reserveTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.reserveTo.DisabledColor = System.Drawing.Color.Gray;
            this.reserveTo.DisplayWeekNumbers = false;
            this.reserveTo.DPHeight = 0;
            this.reserveTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.reserveTo.FillDatePicker = false;
            this.reserveTo.ForeColor = System.Drawing.Color.Purple;
            this.reserveTo.Icon = ((System.Drawing.Image)(resources.GetObject("reserveTo.Icon")));
            this.reserveTo.IconColor = System.Drawing.Color.Purple;
            this.reserveTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.reserveTo.Location = new System.Drawing.Point(531, 28);
            this.reserveTo.Margin = new System.Windows.Forms.Padding(2);
            this.reserveTo.MinimumSize = new System.Drawing.Size(164, 32);
            this.reserveTo.Name = "reserveTo";
            this.reserveTo.Size = new System.Drawing.Size(164, 32);
            this.reserveTo.TabIndex = 8;
            this.reserveTo.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            this.reserveTo.ValueChanged += new System.EventHandler(this.reserveTo_ValueChanged);
            // 
            // reserveFrom
            // 
            this.reserveFrom.BorderRadius = 1;
            this.reserveFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.reserveFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.reserveFrom.DisabledColor = System.Drawing.Color.Gray;
            this.reserveFrom.DisplayWeekNumbers = false;
            this.reserveFrom.DPHeight = 0;
            this.reserveFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.reserveFrom.FillDatePicker = false;
            this.reserveFrom.ForeColor = System.Drawing.Color.Purple;
            this.reserveFrom.Icon = ((System.Drawing.Image)(resources.GetObject("reserveFrom.Icon")));
            this.reserveFrom.IconColor = System.Drawing.Color.Purple;
            this.reserveFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.reserveFrom.Location = new System.Drawing.Point(325, 28);
            this.reserveFrom.Margin = new System.Windows.Forms.Padding(2);
            this.reserveFrom.MinimumSize = new System.Drawing.Size(164, 32);
            this.reserveFrom.Name = "reserveFrom";
            this.reserveFrom.Size = new System.Drawing.Size(164, 32);
            this.reserveFrom.TabIndex = 7;
            this.reserveFrom.ValueChanged += new System.EventHandler(this.reserveFrom_ValueChanged);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Bunifu Button";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(0, 69);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(236, 37);
            this.bunifuButton1.TabIndex = 8;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::Trivago.Properties.Resources.setnavy2;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "";
            this.bunifuTileButton3.Location = new System.Drawing.Point(356, 98);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(66, 107);
            this.bunifuTileButton3.TabIndex = 76;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.reserveToLabel);
            this.Controls.Add(this.reserveFromLabel);
            this.Controls.Add(this.reserveTo);
            this.Controls.Add(this.reserveFrom);
            this.Controls.Add(this.RoomTypeDropdown);
            this.Controls.Add(this.RoomTypeLabel);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SearchTextbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReserveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReserveRoom";
            this.DisplayPanel.ResumeLayout(false);
            this.tempPanel.ResumeLayout(false);
            this.tempPanel.PerformLayout();
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel DisplayPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel RoomTypeLabel;
        private Bunifu.UI.WinForms.BunifuDropdown RoomTypeDropdown;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel tempPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelName;
        private Bunifu.Framework.UI.BunifuRating HotelRating;
        private Bunifu.Framework.UI.BunifuCustomLabel RoomPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelLocation;
        private Bunifu.Framework.UI.BunifuCustomLabel RoomType;
        private Bunifu.Framework.UI.BunifuCustomLabel RoomId;
        private Bunifu.Framework.UI.BunifuCustomLabel WebsiteName;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel2;
        private Bunifu.UI.WinForms.BunifuDatePicker reserveFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker reserveTo;
        private Bunifu.Framework.UI.BunifuCustomLabel reserveFromLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel reserveToLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
    }
}