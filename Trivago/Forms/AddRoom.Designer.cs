namespace Trivago.Forms
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.AvaliableHotelsDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.RoomIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RoomTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.AddRoomButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NewRoomPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.NewRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvaliableHotelsDropdown
            // 
            this.AvaliableHotelsDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.AvaliableHotelsDropdown.BorderRadius = 1;
            this.AvaliableHotelsDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.AvaliableHotelsDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.AvaliableHotelsDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AvaliableHotelsDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.AvaliableHotelsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvaliableHotelsDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.AvaliableHotelsDropdown.FillDropDown = false;
            this.AvaliableHotelsDropdown.FillIndicator = false;
            this.AvaliableHotelsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvaliableHotelsDropdown.ForeColor = System.Drawing.Color.Purple;
            this.AvaliableHotelsDropdown.FormattingEnabled = true;
            this.AvaliableHotelsDropdown.Icon = null;
            this.AvaliableHotelsDropdown.IndicatorColor = System.Drawing.Color.Purple;
            this.AvaliableHotelsDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.AvaliableHotelsDropdown.ItemBackColor = System.Drawing.Color.White;
            this.AvaliableHotelsDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.AvaliableHotelsDropdown.ItemForeColor = System.Drawing.Color.Purple;
            this.AvaliableHotelsDropdown.ItemHeight = 26;
            this.AvaliableHotelsDropdown.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.AvaliableHotelsDropdown.Location = new System.Drawing.Point(37, 60);
            this.AvaliableHotelsDropdown.Name = "AvaliableHotelsDropdown";
            this.AvaliableHotelsDropdown.Size = new System.Drawing.Size(217, 32);
            this.AvaliableHotelsDropdown.TabIndex = 1;
            this.AvaliableHotelsDropdown.Text = null;
            this.AvaliableHotelsDropdown.SelectedIndexChanged += new System.EventHandler(this.AvaliableHotelsDropdown_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(37, 36);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(35, 18);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Hotel";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RoomIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RoomIDTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RoomIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomIDTextBox.Enabled = false;
            this.RoomIDTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RoomIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomIDTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.RoomIDTextBox.HintText = "";
            this.RoomIDTextBox.isPassword = false;
            this.RoomIDTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.RoomIDTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.RoomIDTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.RoomIDTextBox.LineThickness = 3;
            this.RoomIDTextBox.Location = new System.Drawing.Point(0, 30);
            this.RoomIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoomIDTextBox.MaxLength = 32767;
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(379, 33);
            this.RoomIDTextBox.TabIndex = 4;
            this.RoomIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.RoomTypeDropdown.Location = new System.Drawing.Point(0, 103);
            this.RoomTypeDropdown.Name = "RoomTypeDropdown";
            this.RoomTypeDropdown.Size = new System.Drawing.Size(217, 32);
            this.RoomTypeDropdown.TabIndex = 5;
            this.RoomTypeDropdown.Text = null;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(73, 18);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "Room\'s_ID:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(0, 79);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(85, 18);
            this.bunifuLabel3.TabIndex = 7;
            this.bunifuLabel3.Text = "Room\'s Type";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRoomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddRoomButton.BackgroundImage")));
            this.AddRoomButton.ButtonText = "Add";
            this.AddRoomButton.ButtonTextMarginLeft = 0;
            this.AddRoomButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddRoomButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddRoomButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddRoomButton.ForeColor = System.Drawing.Color.White;
            this.AddRoomButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddRoomButton.IconPadding = 10;
            this.AddRoomButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddRoomButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddRoomButton.IdleBorderRadius = 1;
            this.AddRoomButton.IdleBorderThickness = 0;
            this.AddRoomButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddRoomButton.IdleIconLeftImage = null;
            this.AddRoomButton.IdleIconRightImage = null;
            this.AddRoomButton.Location = new System.Drawing.Point(302, 402);
            this.AddRoomButton.Name = "AddRoomButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.AddRoomButton.onHoverState = stateProperties1;
            this.AddRoomButton.Size = new System.Drawing.Size(210, 45);
            this.AddRoomButton.TabIndex = 8;
            this.AddRoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // NewRoomPanel
            // 
            this.NewRoomPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.NewRoomPanel.Controls.Add(this.RoomIDTextBox);
            this.NewRoomPanel.Controls.Add(this.RoomTypeDropdown);
            this.NewRoomPanel.Controls.Add(this.bunifuLabel3);
            this.NewRoomPanel.Controls.Add(this.bunifuLabel2);
            this.NewRoomPanel.Location = new System.Drawing.Point(37, 128);
            this.NewRoomPanel.Name = "NewRoomPanel";
            this.NewRoomPanel.PanelColor = System.Drawing.Color.Empty;
            this.NewRoomPanel.ShadowDept = 2;
            this.NewRoomPanel.ShadowTopLeftVisible = false;
            this.NewRoomPanel.Size = new System.Drawing.Size(391, 144);
            this.NewRoomPanel.TabIndex = 10;
            this.NewRoomPanel.Visible = false;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewRoomPanel);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.AvaliableHotelsDropdown);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRoom_FormClosing);
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.NewRoomPanel.ResumeLayout(false);
            this.NewRoomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown AvaliableHotelsDropdown;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RoomIDTextBox;
        private Bunifu.UI.WinForms.BunifuDropdown RoomTypeDropdown;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddRoomButton;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel NewRoomPanel;
    }
}