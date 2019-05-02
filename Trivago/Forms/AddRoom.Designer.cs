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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.NewRoomPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.RoomIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RoomTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.AddRoomButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AvaliableHotelsDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.NewRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewRoomPanel
            // 
            this.NewRoomPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.NewRoomPanel.Controls.Add(this.bunifuLabel3);
            this.NewRoomPanel.Controls.Add(this.bunifuLabel2);
            this.NewRoomPanel.Controls.Add(this.RoomIDTextBox);
            this.NewRoomPanel.Controls.Add(this.RoomTypeDropdown);
            this.NewRoomPanel.Location = new System.Drawing.Point(67, 130);
            this.NewRoomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewRoomPanel.Name = "NewRoomPanel";
            this.NewRoomPanel.PanelColor = System.Drawing.Color.Empty;
            this.NewRoomPanel.ShadowDept = 2;
            this.NewRoomPanel.ShadowTopLeftVisible = false;
            this.NewRoomPanel.Size = new System.Drawing.Size(426, 165);
            this.NewRoomPanel.TabIndex = 10;
            this.NewRoomPanel.Visible = false;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Verdana", 10F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(6, 9);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(78, 18);
            this.bunifuLabel3.TabIndex = 16;
            this.bunifuLabel3.Text = "Room\'s ID : ";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Verdana", 10F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(6, 88);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(85, 18);
            this.bunifuLabel2.TabIndex = 15;
            this.bunifuLabel2.Text = "Room Type :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RoomIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RoomIDTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RoomIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomIDTextBox.Enabled = false;
            this.RoomIDTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomIDTextBox.ForeColor = System.Drawing.Color.White;
            this.RoomIDTextBox.HintForeColor = System.Drawing.Color.White;
            this.RoomIDTextBox.HintText = "Room ID";
            this.RoomIDTextBox.isPassword = false;
            this.RoomIDTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomIDTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomIDTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomIDTextBox.LineThickness = 3;
            this.RoomIDTextBox.Location = new System.Drawing.Point(6, 38);
            this.RoomIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomIDTextBox.MaxLength = 32767;
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(252, 33);
            this.RoomIDTextBox.TabIndex = 14;
            this.RoomIDTextBox.Text = "Enter New Name";
            this.RoomIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RoomTypeDropdown
            // 
            this.RoomTypeDropdown.AccessibleDescription = "";
            this.RoomTypeDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.RoomTypeDropdown.BorderRadius = 1;
            this.RoomTypeDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomTypeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.RoomTypeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.RoomTypeDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.RoomTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.RoomTypeDropdown.FillDropDown = false;
            this.RoomTypeDropdown.FillIndicator = false;
            this.RoomTypeDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomTypeDropdown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeDropdown.ForeColor = System.Drawing.Color.White;
            this.RoomTypeDropdown.FormattingEnabled = true;
            this.RoomTypeDropdown.Icon = null;
            this.RoomTypeDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomTypeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.RoomTypeDropdown.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomTypeDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.RoomTypeDropdown.ItemForeColor = System.Drawing.Color.White;
            this.RoomTypeDropdown.ItemHeight = 26;
            this.RoomTypeDropdown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.RoomTypeDropdown.Location = new System.Drawing.Point(6, 119);
            this.RoomTypeDropdown.Name = "RoomTypeDropdown";
            this.RoomTypeDropdown.Size = new System.Drawing.Size(252, 32);
            this.RoomTypeDropdown.TabIndex = 12;
            this.RoomTypeDropdown.Text = "Select Room Type";
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
            this.AddRoomButton.Location = new System.Drawing.Point(265, 353);
            this.AddRoomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRoomButton.Name = "AddRoomButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.AddRoomButton.onHoverState = stateProperties2;
            this.AddRoomButton.Size = new System.Drawing.Size(158, 37);
            this.AddRoomButton.TabIndex = 8;
            this.AddRoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // AvaliableHotelsDropdown
            // 
            this.AvaliableHotelsDropdown.AccessibleDescription = "";
            this.AvaliableHotelsDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.AvaliableHotelsDropdown.BorderRadius = 1;
            this.AvaliableHotelsDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.AvaliableHotelsDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.AvaliableHotelsDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.AvaliableHotelsDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AvaliableHotelsDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.AvaliableHotelsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvaliableHotelsDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.AvaliableHotelsDropdown.FillDropDown = false;
            this.AvaliableHotelsDropdown.FillIndicator = false;
            this.AvaliableHotelsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvaliableHotelsDropdown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaliableHotelsDropdown.ForeColor = System.Drawing.Color.White;
            this.AvaliableHotelsDropdown.FormattingEnabled = true;
            this.AvaliableHotelsDropdown.Icon = null;
            this.AvaliableHotelsDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.AvaliableHotelsDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.AvaliableHotelsDropdown.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.AvaliableHotelsDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.AvaliableHotelsDropdown.ItemForeColor = System.Drawing.Color.White;
            this.AvaliableHotelsDropdown.ItemHeight = 26;
            this.AvaliableHotelsDropdown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.AvaliableHotelsDropdown.Location = new System.Drawing.Point(67, 73);
            this.AvaliableHotelsDropdown.Name = "AvaliableHotelsDropdown";
            this.AvaliableHotelsDropdown.Size = new System.Drawing.Size(252, 32);
            this.AvaliableHotelsDropdown.TabIndex = 13;
            this.AvaliableHotelsDropdown.Text = "Select Hotel";
            this.AvaliableHotelsDropdown.SelectedIndexChanged += new System.EventHandler(this.AvaliableHotelsDropdown_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 10F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(67, 41);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(48, 18);
            this.bunifuLabel1.TabIndex = 14;
            this.bunifuLabel1.Text = "Hotel :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.bk;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(3, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 70;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(552, 426);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.AvaliableHotelsDropdown);
            this.Controls.Add(this.NewRoomPanel);
            this.Controls.Add(this.AddRoomButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRoom_FormClosing);
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.NewRoomPanel.ResumeLayout(false);
            this.NewRoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddRoomButton;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel NewRoomPanel;
        private Bunifu.UI.WinForms.BunifuDropdown RoomTypeDropdown;
        private Bunifu.UI.WinForms.BunifuDropdown AvaliableHotelsDropdown;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RoomIDTextBox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}