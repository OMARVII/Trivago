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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveRoom));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.SearchTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DisplayPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.tempPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.reserveFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.reserveTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.reserveFromLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reserveToLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DisplayPanel.SuspendLayout();
            this.tempPanel.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTextbox.HintText = "Enter Hotel name or country or city or street";
            this.SearchTextbox.isPassword = false;
            this.SearchTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTextbox.LineThickness = 3;
            this.SearchTextbox.Location = new System.Drawing.Point(13, 29);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextbox.MaxLength = 32767;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(362, 32);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTextbox.OnValueChanged += new System.EventHandler(this.SearchTextbox_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Search :";
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.AutoScroll = true;
            this.DisplayPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.DisplayPanel.Controls.Add(this.tempPanel);
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 95);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.PanelColor = System.Drawing.Color.Empty;
            this.DisplayPanel.ShadowDept = 2;
            this.DisplayPanel.ShadowTopLeftVisible = false;
            this.DisplayPanel.Size = new System.Drawing.Size(1285, 518);
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
            this.tempPanel.Location = new System.Drawing.Point(3, 3);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.PanelColor = System.Drawing.Color.Empty;
            this.tempPanel.ShadowDept = 2;
            this.tempPanel.ShadowTopLeftVisible = false;
            this.tempPanel.Size = new System.Drawing.Size(1270, 135);
            this.tempPanel.TabIndex = 0;
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel2.Controls.Add(this.bunifuButton1);
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(946, 4);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(321, 128);
            this.bunifuShadowPanel2.TabIndex = 8;
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
            this.bunifuButton1.Location = new System.Drawing.Point(3, 79);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.Size = new System.Drawing.Size(315, 46);
            this.bunifuButton1.TabIndex = 8;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuShadowPanel1.Controls.Add(this.WebsiteName);
            this.bunifuShadowPanel1.Controls.Add(this.RoomPrice);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(570, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(370, 135);
            this.bunifuShadowPanel1.TabIndex = 7;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(146, 46);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "bunifuCustomLabel3";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 44);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "bunifuCustomLabel2";
            // 
            // WebsiteName
            // 
            this.WebsiteName.AutoSize = true;
            this.WebsiteName.Location = new System.Drawing.Point(4, 4);
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.Size = new System.Drawing.Size(96, 17);
            this.WebsiteName.TabIndex = 6;
            this.WebsiteName.Text = "WebsiteName";
            // 
            // RoomPrice
            // 
            this.RoomPrice.AutoSize = true;
            this.RoomPrice.Location = new System.Drawing.Point(191, 4);
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Size = new System.Drawing.Size(77, 17);
            this.RoomPrice.TabIndex = 5;
            this.RoomPrice.Text = "RoomPrice";
            // 
            // HotelLocation
            // 
            this.HotelLocation.AutoSize = true;
            this.HotelLocation.Location = new System.Drawing.Point(3, 86);
            this.HotelLocation.Name = "HotelLocation";
            this.HotelLocation.Size = new System.Drawing.Size(95, 17);
            this.HotelLocation.TabIndex = 4;
            this.HotelLocation.Text = "HotelLocation";
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.Location = new System.Drawing.Point(300, 46);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(81, 17);
            this.RoomType.TabIndex = 3;
            this.RoomType.Text = "Room Type";
            // 
            // RoomId
            // 
            this.RoomId.AutoSize = true;
            this.RoomId.Location = new System.Drawing.Point(300, 4);
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(62, 17);
            this.RoomId.TabIndex = 2;
            this.RoomId.Text = "Room ID";
            // 
            // HotelRating
            // 
            this.HotelRating.BackColor = System.Drawing.Color.Transparent;
            this.HotelRating.ForeColor = System.Drawing.Color.SeaGreen;
            this.HotelRating.Location = new System.Drawing.Point(4, 35);
            this.HotelRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(240, 40);
            this.HotelRating.TabIndex = 1;
            this.HotelRating.Value = 0;
            // 
            // HotelName
            // 
            this.HotelName.AutoSize = true;
            this.HotelName.Location = new System.Drawing.Point(4, 4);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(78, 17);
            this.HotelName.TabIndex = 0;
            this.HotelName.Text = "HotelName";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(980, 9);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(89, 17);
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
            this.RoomTypeDropdown.Location = new System.Drawing.Point(983, 29);
            this.RoomTypeDropdown.Name = "RoomTypeDropdown";
            this.RoomTypeDropdown.Size = new System.Drawing.Size(217, 32);
            this.RoomTypeDropdown.TabIndex = 5;
            this.RoomTypeDropdown.Text = null;
            this.RoomTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.RoomTypeDropdown_SelectedIndexChanged);
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
            this.reserveFrom.Location = new System.Drawing.Point(433, 29);
            this.reserveFrom.MinimumSize = new System.Drawing.Size(217, 32);
            this.reserveFrom.Name = "reserveFrom";
            this.reserveFrom.Size = new System.Drawing.Size(217, 32);
            this.reserveFrom.TabIndex = 7;
            this.reserveFrom.ValueChanged += new System.EventHandler(this.reserveFrom_ValueChanged);
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
            this.reserveTo.Location = new System.Drawing.Point(708, 29);
            this.reserveTo.MinimumSize = new System.Drawing.Size(217, 32);
            this.reserveTo.Name = "reserveTo";
            this.reserveTo.Size = new System.Drawing.Size(217, 32);
            this.reserveTo.TabIndex = 8;
            this.reserveTo.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            this.reserveTo.ValueChanged += new System.EventHandler(this.reserveTo_ValueChanged);
            // 
            // reserveFromLabel
            // 
            this.reserveFromLabel.AutoSize = true;
            this.reserveFromLabel.Location = new System.Drawing.Point(430, 9);
            this.reserveFromLabel.Name = "reserveFromLabel";
            this.reserveFromLabel.Size = new System.Drawing.Size(105, 17);
            this.reserveFromLabel.TabIndex = 9;
            this.reserveFromLabel.Text = "Reserve From :";
            // 
            // reserveToLabel
            // 
            this.reserveToLabel.AutoSize = true;
            this.reserveToLabel.Location = new System.Drawing.Point(705, 9);
            this.reserveToLabel.Name = "reserveToLabel";
            this.reserveToLabel.Size = new System.Drawing.Size(90, 17);
            this.reserveToLabel.TabIndex = 10;
            this.reserveToLabel.Text = "Reserve To :";
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 613);
            this.Controls.Add(this.reserveToLabel);
            this.Controls.Add(this.reserveFromLabel);
            this.Controls.Add(this.reserveTo);
            this.Controls.Add(this.reserveFrom);
            this.Controls.Add(this.RoomTypeDropdown);
            this.Controls.Add(this.RoomTypeLabel);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SearchTextbox);
            this.Name = "ReserveRoom";
            this.Text = "ReserveRoom";
            this.DisplayPanel.ResumeLayout(false);
            this.tempPanel.ResumeLayout(false);
            this.tempPanel.PerformLayout();
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
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
    }
}