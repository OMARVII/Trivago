namespace Trivago.Forms
{
    partial class DeleteHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteHotel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.hotels = new Bunifu.UI.WinForms.BunifuDropdown();
            this.delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.hotelN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(489, -8);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(50, 87);
            this.bunifuTileButton2.TabIndex = 5;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(41, 36);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(121, 25);
            this.bunifuLabel1.TabIndex = 18;
            this.bunifuLabel1.Text = "Delete Hotel";
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
            this.bunifuPictureBox1.Location = new System.Drawing.Point(426, 22);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 17;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // hotels
            // 
            this.hotels.AccessibleDescription = "";
            this.hotels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.hotels.BorderRadius = 1;
            this.hotels.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotels.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.hotels.DisabledColor = System.Drawing.Color.Gray;
            this.hotels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hotels.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.hotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotels.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.hotels.FillDropDown = false;
            this.hotels.FillIndicator = false;
            this.hotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotels.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotels.ForeColor = System.Drawing.Color.White;
            this.hotels.FormattingEnabled = true;
            this.hotels.Icon = null;
            this.hotels.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotels.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.hotels.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotels.ItemBorderColor = System.Drawing.Color.White;
            this.hotels.ItemForeColor = System.Drawing.Color.White;
            this.hotels.ItemHeight = 26;
            this.hotels.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotels.Location = new System.Drawing.Point(112, 155);
            this.hotels.Name = "hotels";
            this.hotels.Size = new System.Drawing.Size(252, 32);
            this.hotels.TabIndex = 21;
            this.hotels.Text = "Select Hotel ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.ButtonText = "Delete";
            this.delete.ButtonTextMarginLeft = 0;
            this.delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.delete.DisabledFillColor = System.Drawing.Color.Gray;
            this.delete.DisabledForecolor = System.Drawing.Color.White;
            this.delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.delete.IconPadding = 10;
            this.delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.delete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.delete.IdleBorderRadius = 1;
            this.delete.IdleBorderThickness = 0;
            this.delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.delete.IdleIconLeftImage = null;
            this.delete.IdleIconRightImage = null;
            this.delete.Location = new System.Drawing.Point(112, 334);
            this.delete.Name = "delete";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.delete.onHoverState = stateProperties1;
            this.delete.Size = new System.Drawing.Size(252, 45);
            this.delete.TabIndex = 20;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // hotelN
            // 
            this.hotelN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.hotelN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.hotelN.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.hotelN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hotelN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelN.ForeColor = System.Drawing.Color.White;
            this.hotelN.HintForeColor = System.Drawing.Color.White;
            this.hotelN.HintText = "Website Name";
            this.hotelN.isPassword = false;
            this.hotelN.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelN.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelN.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelN.LineThickness = 3;
            this.hotelN.Location = new System.Drawing.Point(112, 240);
            this.hotelN.Margin = new System.Windows.Forms.Padding(4);
            this.hotelN.MaxLength = 32767;
            this.hotelN.Name = "hotelN";
            this.hotelN.Size = new System.Drawing.Size(252, 33);
            this.hotelN.TabIndex = 19;
            this.hotelN.Text = "Hotel Name";
            this.hotelN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hotelN.OnValueChanged += new System.EventHandler(this.hotelN_OnValueChanged);
            // 
            // DeleteHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.hotels);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.hotelN);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuTileButton2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteHotel";
            this.Load += new System.EventHandler(this.DeleteHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuDropdown hotels;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton delete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox hotelN;
    }
}