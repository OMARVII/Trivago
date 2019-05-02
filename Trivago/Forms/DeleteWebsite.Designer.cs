namespace Trivago.Forms
{
    partial class DeleteWebsite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteWebsite));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.website = new Bunifu.UI.WinForms.BunifuDropdown();
            this.delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.websiteN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(21, 62);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(182, 31);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Delete Website";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 25;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(543, 20);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(51, 51);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 15;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // website
            // 
            this.website.AccessibleDescription = "";
            this.website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.website.BorderRadius = 1;
            this.website.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.website.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.website.DisabledColor = System.Drawing.Color.Gray;
            this.website.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.website.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.website.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.website.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.website.FillDropDown = false;
            this.website.FillIndicator = false;
            this.website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.website.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.ForeColor = System.Drawing.Color.White;
            this.website.FormattingEnabled = true;
            this.website.Icon = null;
            this.website.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.website.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.website.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.website.ItemBorderColor = System.Drawing.Color.White;
            this.website.ItemForeColor = System.Drawing.Color.White;
            this.website.ItemHeight = 26;
            this.website.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.website.Location = new System.Drawing.Point(144, 161);
            this.website.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(335, 32);
            this.website.TabIndex = 14;
            this.website.Text = "Select Website Name";
            this.website.SelectedIndexChanged += new System.EventHandler(this.website_SelectedIndexChanged);
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
            this.delete.Location = new System.Drawing.Point(144, 366);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.delete.onHoverState = stateProperties1;
            this.delete.Size = new System.Drawing.Size(252, 45);
            this.delete.TabIndex = 13;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // websiteN
            // 
            this.websiteN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.websiteN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.websiteN.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.websiteN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.websiteN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteN.ForeColor = System.Drawing.Color.White;
            this.websiteN.HintForeColor = System.Drawing.Color.White;
            this.websiteN.HintText = "Website Name";
            this.websiteN.isPassword = false;
            this.websiteN.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteN.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteN.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteN.LineThickness = 3;
            this.websiteN.Location = new System.Drawing.Point(144, 257);
            this.websiteN.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.websiteN.MaxLength = 32767;
            this.websiteN.Name = "websiteN";
            this.websiteN.Size = new System.Drawing.Size(336, 41);
            this.websiteN.TabIndex = 12;
            this.websiteN.Text = "Enter New Name";
            this.websiteN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.websiteN.OnValueChanged += new System.EventHandler(this.websiteN_OnValueChanged);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 20;
            this.bunifuPictureBox2.Image = global::Trivago.Properties.Resources.bk;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(3, 16);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 71;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // DeleteWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(460, 411);
            this.Controls.Add(this.bunifuPictureBox2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.website);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.websiteN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteWebsite";
            this.Load += new System.EventHandler(this.DeleteWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuDropdown website;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton delete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox websiteN;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}