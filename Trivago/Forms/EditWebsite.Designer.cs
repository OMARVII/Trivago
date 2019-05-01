namespace Trivago.Forms
{
    partial class EditWebsite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWebsite));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.newNameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UpdateBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.websiteDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newNameBox
            // 
            this.newNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newNameBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameBox.ForeColor = System.Drawing.Color.White;
            this.newNameBox.HintForeColor = System.Drawing.Color.White;
            this.newNameBox.HintText = "Enter New Name";
            this.newNameBox.isPassword = false;
            this.newNameBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.newNameBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.newNameBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.newNameBox.LineThickness = 3;
            this.newNameBox.Location = new System.Drawing.Point(104, 213);
            this.newNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.newNameBox.MaxLength = 32767;
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(252, 33);
            this.newNameBox.TabIndex = 6;
            this.newNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBTN.BackgroundImage")));
            this.UpdateBTN.ButtonText = "Update";
            this.UpdateBTN.ButtonTextMarginLeft = 0;
            this.UpdateBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.UpdateBTN.DisabledFillColor = System.Drawing.Color.Gray;
            this.UpdateBTN.DisabledForecolor = System.Drawing.Color.White;
            this.UpdateBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBTN.ForeColor = System.Drawing.Color.White;
            this.UpdateBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBTN.IconPadding = 10;
            this.UpdateBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.UpdateBTN.IdleBorderRadius = 1;
            this.UpdateBTN.IdleBorderThickness = 0;
            this.UpdateBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.UpdateBTN.IdleIconLeftImage = null;
            this.UpdateBTN.IdleIconRightImage = null;
            this.UpdateBTN.Location = new System.Drawing.Point(104, 301);
            this.UpdateBTN.Name = "UpdateBTN";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.UpdateBTN.onHoverState = stateProperties1;
            this.UpdateBTN.Size = new System.Drawing.Size(252, 45);
            this.UpdateBTN.TabIndex = 8;
            this.UpdateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // websiteDropDown
            // 
            this.websiteDropDown.AccessibleDescription = "";
            this.websiteDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.websiteDropDown.BorderRadius = 1;
            this.websiteDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.websiteDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.websiteDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.websiteDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.websiteDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.websiteDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.websiteDropDown.FillDropDown = false;
            this.websiteDropDown.FillIndicator = false;
            this.websiteDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteDropDown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteDropDown.ForeColor = System.Drawing.Color.White;
            this.websiteDropDown.FormattingEnabled = true;
            this.websiteDropDown.Icon = null;
            this.websiteDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.websiteDropDown.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.websiteDropDown.ItemForeColor = System.Drawing.Color.White;
            this.websiteDropDown.ItemHeight = 26;
            this.websiteDropDown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.websiteDropDown.Location = new System.Drawing.Point(104, 131);
            this.websiteDropDown.Name = "websiteDropDown";
            this.websiteDropDown.Size = new System.Drawing.Size(252, 32);
            this.websiteDropDown.TabIndex = 9;
            this.websiteDropDown.Text = "Select Website Name";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(23, 30);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(126, 25);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "Delete Room";
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
            this.bunifuPictureBox1.Location = new System.Drawing.Point(392, 17);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 10;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // EditWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(460, 411);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.websiteDropDown);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.newNameBox);
            this.Name = "EditWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWebsite";
            this.Load += new System.EventHandler(this.EditWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox newNameBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBTN;
        private Bunifu.UI.WinForms.BunifuDropdown websiteDropDown;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}