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
            this.hotels = new Bunifu.UI.WinForms.BunifuDropdown();
            this.delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.hotelN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // hotels
            // 
            this.hotels.BackColor = System.Drawing.SystemColors.Control;
            this.hotels.BorderRadius = 1;
            this.hotels.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotels.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.hotels.DisabledColor = System.Drawing.Color.Gray;
            this.hotels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hotels.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.hotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotels.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.hotels.FillDropDown = false;
            this.hotels.FillIndicator = false;
            this.hotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotels.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotels.FormattingEnabled = true;
            this.hotels.Icon = null;
            this.hotels.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotels.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.None;
            this.hotels.ItemBackColor = System.Drawing.Color.White;
            this.hotels.ItemBorderColor = System.Drawing.Color.White;
            this.hotels.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotels.ItemHeight = 26;
            this.hotels.ItemHighLightColor = System.Drawing.Color.Coral;
            this.hotels.Location = new System.Drawing.Point(251, 106);
            this.hotels.Name = "hotels";
            this.hotels.Size = new System.Drawing.Size(242, 32);
            this.hotels.TabIndex = 2;
            this.hotels.Text = "Hotel ID";
            this.hotels.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.ActiveBorderThickness = 1;
            this.delete.ActiveCornerRadius = 20;
            this.delete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.delete.ActiveForecolor = System.Drawing.Color.White;
            this.delete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.ButtonText = "Delete";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.delete.IdleBorderThickness = 1;
            this.delete.IdleCornerRadius = 20;
            this.delete.IdleFillColor = System.Drawing.Color.Transparent;
            this.delete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.delete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.delete.Location = new System.Drawing.Point(268, 250);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 48);
            this.delete.TabIndex = 1;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // hotelN
            // 
            this.hotelN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.hotelN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.hotelN.BackColor = System.Drawing.Color.White;
            this.hotelN.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.hotelN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hotelN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotelN.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotelN.HintText = "hotel name";
            this.hotelN.isPassword = false;
            this.hotelN.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotelN.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotelN.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(68)))), ((int)(((byte)(34)))));
            this.hotelN.LineThickness = 4;
            this.hotelN.Location = new System.Drawing.Point(268, 175);
            this.hotelN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hotelN.MaxLength = 32767;
            this.hotelN.Name = "hotelN";
            this.hotelN.Size = new System.Drawing.Size(196, 39);
            this.hotelN.TabIndex = 3;
            this.hotelN.Text = "Hotel name";
            this.hotelN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hotelN.OnValueChanged += new System.EventHandler(this.hotelN_OnValueChanged_1);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(365, 293);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(219, 138);
            this.bunifuTileButton1.TabIndex = 4;
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
            // DeleteHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivago.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 387);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.hotelN);
            this.Controls.Add(this.hotels);
            this.Controls.Add(this.delete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteHotel";
            this.Text = "DeleteHotel";
            this.Load += new System.EventHandler(this.DeleteHotel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 delete;
        private Bunifu.UI.WinForms.BunifuDropdown hotels;
        private Bunifu.Framework.UI.BunifuMaterialTextbox hotelN;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
    }
}