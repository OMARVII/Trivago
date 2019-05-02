namespace Trivago.Forms
{
    partial class UserFeedback
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFeedback));
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.DateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FeedBackDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelNames = new Bunifu.UI.WinForms.BunifuDropdown();
            this.FeedBackLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FeedbackText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.close = new Bunifu.Framework.UI.BunifuTileButton();
            this.SubmitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HotelNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.FeedbackError = new System.Windows.Forms.ErrorProvider(this.components);
            this.AccountSettingsIcon = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.HotelNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackError)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.CursorType = null;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(13, 23);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(239, 31);
            this.TitleLabel.TabIndex = 24;
            this.TitleLabel.Text = "HOTEL FEEDBACK";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = true;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.AutoSizeHeightOnly = true;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(37, 173);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(388, 94);
            this.bunifuLabel3.TabIndex = 28;
            this.bunifuLabel3.Text = "In this form you can give us your precious feedbackabout your experience with the" +
    " hotel we offered to you.";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(416, 663);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(150, 182);
            this.bunifuTileButton2.TabIndex = 29;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.DateLabel.Location = new System.Drawing.Point(549, 55);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(186, 26);
            this.DateLabel.TabIndex = 30;
            this.DateLabel.Text = "FeedBack Date:";
            // 
            // FeedBackDate
            // 
            this.FeedBackDate.AutoSize = true;
            this.FeedBackDate.BackColor = System.Drawing.Color.Transparent;
            this.FeedBackDate.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedBackDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.FeedBackDate.Location = new System.Drawing.Point(754, 55);
            this.FeedBackDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeedBackDate.Name = "FeedBackDate";
            this.FeedBackDate.Size = new System.Drawing.Size(74, 26);
            this.FeedBackDate.TabIndex = 31;
            this.FeedBackDate.Text = "Date:";
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelLabel.Location = new System.Drawing.Point(549, 130);
            this.HotelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(155, 26);
            this.HotelLabel.TabIndex = 32;
            this.HotelLabel.Text = "Select Hotel:";
            // 
            // HotelNames
            // 
            this.HotelNames.AccessibleDescription = "";
            this.HotelNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelNames.BorderRadius = 10;
            this.HotelNames.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelNames.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.HotelNames.DisabledColor = System.Drawing.Color.Gray;
            this.HotelNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HotelNames.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.HotelNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelNames.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.HotelNames.FillDropDown = false;
            this.HotelNames.FillIndicator = false;
            this.HotelNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotelNames.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNames.ForeColor = System.Drawing.Color.White;
            this.HotelNames.FormattingEnabled = true;
            this.HotelNames.Icon = null;
            this.HotelNames.IndicatorColor = System.Drawing.Color.White;
            this.HotelNames.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.HotelNames.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNames.ItemBorderColor = System.Drawing.Color.White;
            this.HotelNames.ItemForeColor = System.Drawing.Color.Silver;
            this.HotelNames.ItemHeight = 26;
            this.HotelNames.ItemHighLightColor = System.Drawing.Color.White;
            this.HotelNames.Location = new System.Drawing.Point(759, 124);
            this.HotelNames.Margin = new System.Windows.Forms.Padding(4);
            this.HotelNames.Name = "HotelNames";
            this.HotelNames.Size = new System.Drawing.Size(248, 32);
            this.HotelNames.TabIndex = 33;
            this.HotelNames.Text = "Select Hotel Name";
            // 
            // FeedBackLabel
            // 
            this.FeedBackLabel.AutoSize = true;
            this.FeedBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeedBackLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedBackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.FeedBackLabel.Location = new System.Drawing.Point(549, 221);
            this.FeedBackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeedBackLabel.Name = "FeedBackLabel";
            this.FeedBackLabel.Size = new System.Drawing.Size(126, 26);
            this.FeedBackLabel.TabIndex = 34;
            this.FeedBackLabel.Text = "FeedBack:";
            // 
            // FeedbackText
            // 
            this.FeedbackText.AllowDrop = true;
            this.FeedbackText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FeedbackText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FeedbackText.AutoSize = true;
            this.FeedbackText.BackColor = System.Drawing.Color.White;
            this.FeedbackText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FeedbackText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeedbackText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FeedbackText.HintForeColor = System.Drawing.Color.Empty;
            this.FeedbackText.HintText = "Insert Your Feedback";
            this.FeedbackText.isPassword = false;
            this.FeedbackText.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.FeedbackText.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.FeedbackText.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.FeedbackText.LineThickness = 3;
            this.FeedbackText.Location = new System.Drawing.Point(759, 200);
            this.FeedbackText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FeedbackText.MaxLength = 32767;
            this.FeedbackText.Name = "FeedbackText";
            this.FeedbackText.Size = new System.Drawing.Size(258, 47);
            this.FeedbackText.TabIndex = 35;
            this.FeedbackText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Image = global::Trivago.Properties.Resources.trivagoo;
            this.bunifuTileButton1.ImagePosition = -10;
            this.bunifuTileButton1.ImageZoom = 70;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1042, 676);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(198, 127);
            this.bunifuTileButton1.TabIndex = 66;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.color = System.Drawing.Color.Transparent;
            this.close.colorActive = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Image = global::Trivago.Properties.Resources.closeNavy;
            this.close.ImagePosition = 20;
            this.close.ImageZoom = 50;
            this.close.LabelPosition = 41;
            this.close.LabelText = "";
            this.close.Location = new System.Drawing.Point(1152, -16);
            this.close.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(88, 132);
            this.close.TabIndex = 67;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Active = false;
            this.SubmitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.BorderRadius = 0;
            this.SubmitButton.ButtonText = "Submit Feedback";
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.DisabledColor = System.Drawing.Color.Gray;
            this.SubmitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SubmitButton.Iconimage = null;
            this.SubmitButton.Iconimage_right = null;
            this.SubmitButton.Iconimage_right_Selected = null;
            this.SubmitButton.Iconimage_Selected = null;
            this.SubmitButton.IconMarginLeft = 0;
            this.SubmitButton.IconMarginRight = 0;
            this.SubmitButton.IconRightVisible = true;
            this.SubmitButton.IconRightZoom = 0D;
            this.SubmitButton.IconVisible = true;
            this.SubmitButton.IconZoom = 90D;
            this.SubmitButton.IsTab = false;
            this.SubmitButton.Location = new System.Drawing.Point(778, 337);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.SubmitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.SubmitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SubmitButton.selected = false;
            this.SubmitButton.Size = new System.Drawing.Size(195, 59);
            this.SubmitButton.TabIndex = 68;
            this.SubmitButton.Text = "Submit Feedback";
            this.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitButton.Textcolor = System.Drawing.Color.White;
            this.SubmitButton.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HotelNameError
            // 
            this.HotelNameError.ContainerControl = this;
            // 
            // FeedbackError
            // 
            this.FeedbackError.ContainerControl = this;
            // 
            // AccountSettingsIcon
            // 
            this.AccountSettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.AccountSettingsIcon.color = System.Drawing.Color.Transparent;
            this.AccountSettingsIcon.colorActive = System.Drawing.Color.Transparent;
            this.AccountSettingsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountSettingsIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.AccountSettingsIcon.ForeColor = System.Drawing.Color.White;
            this.AccountSettingsIcon.Image = global::Trivago.Properties.Resources.navy1;
            this.AccountSettingsIcon.ImagePosition = 20;
            this.AccountSettingsIcon.ImageZoom = 50;
            this.AccountSettingsIcon.LabelPosition = 41;
            this.AccountSettingsIcon.LabelText = "";
            this.AccountSettingsIcon.Location = new System.Drawing.Point(1088, -5);
            this.AccountSettingsIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AccountSettingsIcon.Name = "AccountSettingsIcon";
            this.AccountSettingsIcon.Size = new System.Drawing.Size(88, 132);
            this.AccountSettingsIcon.TabIndex = 69;
            this.AccountSettingsIcon.Click += new System.EventHandler(this.AccountSettingsIcon_Click);
            // 
            // UserFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::Trivago.Properties.Resources.navy;
            this.ClientSize = new System.Drawing.Size(1239, 777);
            this.Controls.Add(this.AccountSettingsIcon);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.close);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.FeedbackText);
            this.Controls.Add(this.FeedBackLabel);
            this.Controls.Add(this.HotelNames);
            this.Controls.Add(this.HotelLabel);
            this.Controls.Add(this.FeedBackDate);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.TitleLabel);
            this.Name = "UserFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFeedback";
            this.Load += new System.EventHandler(this.UserFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel DateLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel FeedBackDate;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelLabel;
        private Bunifu.UI.WinForms.BunifuDropdown HotelNames;
        private Bunifu.Framework.UI.BunifuCustomLabel FeedBackLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FeedbackText;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton close;
        private Bunifu.Framework.UI.BunifuFlatButton SubmitButton;
        private System.Windows.Forms.ErrorProvider HotelNameError;
        private System.Windows.Forms.ErrorProvider FeedbackError;
        private Bunifu.Framework.UI.BunifuTileButton AccountSettingsIcon;
    }
}