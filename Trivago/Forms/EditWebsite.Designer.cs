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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.websiteDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.newNameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UpdateBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // websiteDropDown
            // 
            this.websiteDropDown.AccessibleDescription = "";
            this.websiteDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.websiteDropDown.BorderRadius = 1;
            this.websiteDropDown.Color = System.Drawing.Color.MidnightBlue;
            this.websiteDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.websiteDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.websiteDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.websiteDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.websiteDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.websiteDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.websiteDropDown.FillDropDown = false;
            this.websiteDropDown.FillIndicator = false;
            this.websiteDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteDropDown.ForeColor = System.Drawing.Color.RoyalBlue;
            this.websiteDropDown.FormattingEnabled = true;
            this.websiteDropDown.Icon = null;
            this.websiteDropDown.IndicatorColor = System.Drawing.Color.MidnightBlue;
            this.websiteDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.websiteDropDown.ItemBackColor = System.Drawing.Color.White;
            this.websiteDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.websiteDropDown.ItemForeColor = System.Drawing.Color.DarkBlue;
            this.websiteDropDown.ItemHeight = 26;
            this.websiteDropDown.ItemHighLightColor = System.Drawing.Color.RoyalBlue;
            this.websiteDropDown.Location = new System.Drawing.Point(33, 38);
            this.websiteDropDown.Name = "websiteDropDown";
            this.websiteDropDown.Size = new System.Drawing.Size(217, 32);
            this.websiteDropDown.TabIndex = 5;
            this.websiteDropDown.Text = "Select Website Name";
            this.websiteDropDown.SelectedIndexChanged += new System.EventHandler(this.websiteDropDown_SelectedIndexChanged);
            // 
            // newNameBox
            // 
            this.newNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newNameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.newNameBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.newNameBox.HintForeColor = System.Drawing.Color.RoyalBlue;
            this.newNameBox.HintText = "Enter New Name";
            this.newNameBox.isPassword = false;
            this.newNameBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.newNameBox.LineIdleColor = System.Drawing.Color.MidnightBlue;
            this.newNameBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.newNameBox.LineThickness = 3;
            this.newNameBox.Location = new System.Drawing.Point(33, 102);
            this.newNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.newNameBox.MaxLength = 32767;
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(217, 33);
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
            this.UpdateBTN.ForeColor = System.Drawing.Color.White;
            this.UpdateBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBTN.IconPadding = 10;
            this.UpdateBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.UpdateBTN.IdleBorderRadius = 1;
            this.UpdateBTN.IdleBorderThickness = 0;
            this.UpdateBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.UpdateBTN.IdleIconLeftImage = null;
            this.UpdateBTN.IdleIconRightImage = null;
            this.UpdateBTN.Location = new System.Drawing.Point(33, 171);
            this.UpdateBTN.Name = "UpdateBTN";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.UpdateBTN.onHoverState = stateProperties2;
            this.UpdateBTN.Size = new System.Drawing.Size(214, 45);
            this.UpdateBTN.TabIndex = 7;
            this.UpdateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // EditWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.websiteDropDown);
            this.Name = "EditWebsite";
            this.Text = "EditWebsite";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown websiteDropDown;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newNameBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBTN;
    }
}