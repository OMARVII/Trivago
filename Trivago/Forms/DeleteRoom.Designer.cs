namespace Trivago.Forms
{
    partial class DeleteRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRoom));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.hotelDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.roomDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.DeleteBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDropDown
            // 
            this.hotelDropDown.AccessibleDescription = "";
            this.hotelDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.hotelDropDown.BorderRadius = 1;
            this.hotelDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.hotelDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.hotelDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hotelDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.hotelDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.hotelDropDown.FillDropDown = false;
            this.hotelDropDown.FillIndicator = false;
            this.hotelDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelDropDown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelDropDown.ForeColor = System.Drawing.Color.White;
            this.hotelDropDown.FormattingEnabled = true;
            this.hotelDropDown.Icon = null;
            this.hotelDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.hotelDropDown.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.hotelDropDown.ItemForeColor = System.Drawing.Color.White;
            this.hotelDropDown.ItemHeight = 26;
            this.hotelDropDown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.hotelDropDown.Location = new System.Drawing.Point(113, 135);
            this.hotelDropDown.Name = "hotelDropDown";
            this.hotelDropDown.Size = new System.Drawing.Size(252, 32);
            this.hotelDropDown.TabIndex = 4;
            this.hotelDropDown.Text = "Select Hotel ID";
            this.hotelDropDown.SelectedIndexChanged += new System.EventHandler(this.hotelDropDown_SelectedIndexChanged);
            // 
            // roomDropDown
            // 
            this.roomDropDown.AccessibleDescription = "";
            this.roomDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.roomDropDown.BorderRadius = 1;
            this.roomDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.roomDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.roomDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.roomDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.roomDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.roomDropDown.FillDropDown = false;
            this.roomDropDown.FillIndicator = false;
            this.roomDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomDropDown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDropDown.ForeColor = System.Drawing.Color.White;
            this.roomDropDown.FormattingEnabled = true;
            this.roomDropDown.Icon = null;
            this.roomDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.roomDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.roomDropDown.ItemBackColor = System.Drawing.Color.White;
            this.roomDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.roomDropDown.ItemForeColor = System.Drawing.Color.White;
            this.roomDropDown.ItemHeight = 26;
            this.roomDropDown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.roomDropDown.Location = new System.Drawing.Point(113, 211);
            this.roomDropDown.Name = "roomDropDown";
            this.roomDropDown.Size = new System.Drawing.Size(252, 32);
            this.roomDropDown.TabIndex = 5;
            this.roomDropDown.Text = "Select Room ID";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBTN.BackgroundImage")));
            this.DeleteBTN.ButtonText = "Delete";
            this.DeleteBTN.ButtonTextMarginLeft = 0;
            this.DeleteBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.DeleteBTN.DisabledFillColor = System.Drawing.Color.Gray;
            this.DeleteBTN.DisabledForecolor = System.Drawing.Color.White;
            this.DeleteBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteBTN.IconPadding = 10;
            this.DeleteBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.DeleteBTN.IdleBorderRadius = 1;
            this.DeleteBTN.IdleBorderThickness = 0;
            this.DeleteBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.DeleteBTN.IdleIconLeftImage = null;
            this.DeleteBTN.IdleIconRightImage = null;
            this.DeleteBTN.Location = new System.Drawing.Point(113, 285);
            this.DeleteBTN.Name = "DeleteBTN";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.DeleteBTN.onHoverState = stateProperties1;
            this.DeleteBTN.Size = new System.Drawing.Size(252, 45);
            this.DeleteBTN.TabIndex = 3;
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(410, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(32, 69);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(126, 25);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "Delete Room";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 20;
            this.bunifuPictureBox2.Image = global::Trivago.Properties.Resources.bk;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(2, 12);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 70;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // DeleteRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(460, 411);
            this.Controls.Add(this.bunifuPictureBox2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.roomDropDown);
            this.Controls.Add(this.hotelDropDown);
            this.Controls.Add(this.DeleteBTN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.Name = "DeleteRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRoom";
            this.Load += new System.EventHandler(this.DeleteRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteBTN;
        private Bunifu.UI.WinForms.BunifuDropdown hotelDropDown;
        private Bunifu.UI.WinForms.BunifuDropdown roomDropDown;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}