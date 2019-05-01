namespace Trivago.Forms
{
    partial class EditHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHotel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.HotelRating = new Bunifu.Framework.UI.BunifuRating();
            this.HotelNameDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.HotelName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.NewHotelNameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.NewEmailLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.HotelDescriptionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.NumberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RatingLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.NewNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewEmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewNumberError = new System.Windows.Forms.ErrorProvider(this.components);
            this.RatingError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNumberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingError)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelRating
            // 
            this.HotelRating.BackColor = System.Drawing.Color.Transparent;
            this.HotelRating.ForeColor = System.Drawing.Color.White;
            this.HotelRating.Location = new System.Drawing.Point(240, 377);
            this.HotelRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(335, 51);
            this.HotelRating.TabIndex = 7;
            this.HotelRating.Value = 0;
            // 
            // HotelNameDropDown
            // 
            this.HotelNameDropDown.AccessibleDescription = "";
            this.HotelNameDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelNameDropDown.BorderRadius = 1;
            this.HotelNameDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNameDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.HotelNameDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.HotelNameDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HotelNameDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.HotelNameDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelNameDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.HotelNameDropDown.FillDropDown = false;
            this.HotelNameDropDown.FillIndicator = false;
            this.HotelNameDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotelNameDropDown.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNameDropDown.ForeColor = System.Drawing.Color.White;
            this.HotelNameDropDown.FormattingEnabled = true;
            this.HotelNameDropDown.Icon = null;
            this.HotelNameDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNameDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.HotelNameDropDown.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNameDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.HotelNameDropDown.ItemForeColor = System.Drawing.Color.White;
            this.HotelNameDropDown.ItemHeight = 26;
            this.HotelNameDropDown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNameDropDown.Location = new System.Drawing.Point(239, 41);
            this.HotelNameDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.HotelNameDropDown.Name = "HotelNameDropDown";
            this.HotelNameDropDown.Size = new System.Drawing.Size(335, 32);
            this.HotelNameDropDown.TabIndex = 15;
            this.HotelNameDropDown.Text = "Select Hotel Name";
            this.HotelNameDropDown.SelectedIndexChanged += new System.EventHandler(this.HotelNameDropDown_SelectedIndexChanged);
            // 
            // HotelName
            // 
            this.HotelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelName.ForeColor = System.Drawing.Color.White;
            this.HotelName.HintForeColor = System.Drawing.Color.White;
            this.HotelName.HintText = "Insert New Hotel Name.";
            this.HotelName.isPassword = false;
            this.HotelName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelName.LineThickness = 3;
            this.HotelName.Location = new System.Drawing.Point(239, 91);
            this.HotelName.Margin = new System.Windows.Forms.Padding(5);
            this.HotelName.MaxLength = 32767;
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(336, 41);
            this.HotelName.TabIndex = 16;
            this.HotelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelEmail
            // 
            this.HotelEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelEmail.ForeColor = System.Drawing.Color.White;
            this.HotelEmail.HintForeColor = System.Drawing.Color.White;
            this.HotelEmail.HintText = "Insert New Hotel Email.";
            this.HotelEmail.isPassword = false;
            this.HotelEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelEmail.LineThickness = 3;
            this.HotelEmail.Location = new System.Drawing.Point(239, 161);
            this.HotelEmail.Margin = new System.Windows.Forms.Padding(5);
            this.HotelEmail.MaxLength = 32767;
            this.HotelEmail.Name = "HotelEmail";
            this.HotelEmail.Size = new System.Drawing.Size(336, 41);
            this.HotelEmail.TabIndex = 17;
            this.HotelEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelNumber
            // 
            this.HotelNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNumber.ForeColor = System.Drawing.Color.White;
            this.HotelNumber.HintForeColor = System.Drawing.Color.White;
            this.HotelNumber.HintText = "Insert New Number";
            this.HotelNumber.isPassword = false;
            this.HotelNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelNumber.LineThickness = 3;
            this.HotelNumber.Location = new System.Drawing.Point(240, 311);
            this.HotelNumber.Margin = new System.Windows.Forms.Padding(5);
            this.HotelNumber.MaxLength = 32767;
            this.HotelNumber.Name = "HotelNumber";
            this.HotelNumber.Size = new System.Drawing.Size(336, 41);
            this.HotelNumber.TabIndex = 18;
            this.HotelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelDescription
            // 
            this.HotelDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelDescription.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelDescription.ForeColor = System.Drawing.Color.White;
            this.HotelDescription.HintForeColor = System.Drawing.Color.White;
            this.HotelDescription.HintText = "Insert New Description";
            this.HotelDescription.isPassword = false;
            this.HotelDescription.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelDescription.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelDescription.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.HotelDescription.LineThickness = 3;
            this.HotelDescription.Location = new System.Drawing.Point(240, 235);
            this.HotelDescription.Margin = new System.Windows.Forms.Padding(5);
            this.HotelDescription.MaxLength = 32767;
            this.HotelDescription.Name = "HotelDescription";
            this.HotelDescription.Size = new System.Drawing.Size(336, 41);
            this.HotelDescription.TabIndex = 19;
            this.HotelDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitButton.BackgroundImage")));
            this.SubmitButton.ButtonText = "Submit";
            this.SubmitButton.ButtonTextMarginLeft = 0;
            this.SubmitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SubmitButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.SubmitButton.DisabledForecolor = System.Drawing.Color.White;
            this.SubmitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitButton.IconPadding = 10;
            this.SubmitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.SubmitButton.IdleBorderRadius = 1;
            this.SubmitButton.IdleBorderThickness = 0;
            this.SubmitButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.SubmitButton.IdleIconLeftImage = null;
            this.SubmitButton.IdleIconRightImage = null;
            this.SubmitButton.Location = new System.Drawing.Point(238, 477);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.SubmitButton.onHoverState = stateProperties3;
            this.SubmitButton.Size = new System.Drawing.Size(336, 55);
            this.SubmitButton.TabIndex = 20;
            this.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.CursorType = null;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(118, 31);
            this.TitleLabel.TabIndex = 21;
            this.TitleLabel.Text = "Edit Hotel";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 25;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(736, 3);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(51, 51);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 22;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // NewHotelNameLabel
            // 
            this.NewHotelNameLabel.AutoEllipsis = false;
            this.NewHotelNameLabel.CursorType = null;
            this.NewHotelNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.NewHotelNameLabel.ForeColor = System.Drawing.Color.White;
            this.NewHotelNameLabel.Location = new System.Drawing.Point(13, 101);
            this.NewHotelNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.NewHotelNameLabel.Name = "NewHotelNameLabel";
            this.NewHotelNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewHotelNameLabel.Size = new System.Drawing.Size(83, 31);
            this.NewHotelNameLabel.TabIndex = 23;
            this.NewHotelNameLabel.Text = "Name:";
            this.NewHotelNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NewHotelNameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NewEmailLabel
            // 
            this.NewEmailLabel.AutoEllipsis = false;
            this.NewEmailLabel.CursorType = null;
            this.NewEmailLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.NewEmailLabel.ForeColor = System.Drawing.Color.White;
            this.NewEmailLabel.Location = new System.Drawing.Point(13, 171);
            this.NewEmailLabel.Margin = new System.Windows.Forms.Padding(4);
            this.NewEmailLabel.Name = "NewEmailLabel";
            this.NewEmailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewEmailLabel.Size = new System.Drawing.Size(78, 31);
            this.NewEmailLabel.TabIndex = 24;
            this.NewEmailLabel.Text = "Email:";
            this.NewEmailLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NewEmailLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // HotelDescriptionLabel
            // 
            this.HotelDescriptionLabel.AutoEllipsis = false;
            this.HotelDescriptionLabel.CursorType = null;
            this.HotelDescriptionLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.HotelDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.HotelDescriptionLabel.Location = new System.Drawing.Point(13, 245);
            this.HotelDescriptionLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HotelDescriptionLabel.Name = "HotelDescriptionLabel";
            this.HotelDescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HotelDescriptionLabel.Size = new System.Drawing.Size(149, 31);
            this.HotelDescriptionLabel.TabIndex = 25;
            this.HotelDescriptionLabel.Text = "Description:";
            this.HotelDescriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.HotelDescriptionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoEllipsis = false;
            this.NumberLabel.CursorType = null;
            this.NumberLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.NumberLabel.ForeColor = System.Drawing.Color.White;
            this.NumberLabel.Location = new System.Drawing.Point(13, 321);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(4);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberLabel.Size = new System.Drawing.Size(109, 31);
            this.NumberLabel.TabIndex = 26;
            this.NumberLabel.Text = "Number:";
            this.NumberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NumberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoEllipsis = false;
            this.RatingLabel.CursorType = null;
            this.RatingLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.RatingLabel.ForeColor = System.Drawing.Color.White;
            this.RatingLabel.Location = new System.Drawing.Point(13, 397);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RatingLabel.Size = new System.Drawing.Size(90, 31);
            this.RatingLabel.TabIndex = 27;
            this.RatingLabel.Text = "Rating:";
            this.RatingLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RatingLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(616, 447);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(198, 127);
            this.bunifuTileButton1.TabIndex = 65;
            // 
            // NewNameError
            // 
            this.NewNameError.ContainerControl = this;
            // 
            // NewEmailError
            // 
            this.NewEmailError.ContainerControl = this;
            // 
            // NewNumberError
            // 
            this.NewNumberError.ContainerControl = this;
            // 
            // RatingError
            // 
            this.RatingError.ContainerControl = this;
            // 
            // EditHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.HotelDescriptionLabel);
            this.Controls.Add(this.NewEmailLabel);
            this.Controls.Add(this.NewHotelNameLabel);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HotelDescription);
            this.Controls.Add(this.HotelNumber);
            this.Controls.Add(this.HotelEmail);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.HotelNameDropDown);
            this.Controls.Add(this.HotelRating);
            this.Name = "EditHotel";
            this.Text = "EditHotel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditHotel_FormClosed);
            this.Load += new System.EventHandler(this.EditHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewNumberError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuRating HotelRating;
        private Bunifu.UI.WinForms.BunifuDropdown HotelNameDropDown;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SubmitButton;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel NewHotelNameLabel;
        private Bunifu.UI.WinForms.BunifuLabel NewEmailLabel;
        private Bunifu.UI.WinForms.BunifuLabel HotelDescriptionLabel;
        private Bunifu.UI.WinForms.BunifuLabel NumberLabel;
        private Bunifu.UI.WinForms.BunifuLabel RatingLabel;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.ErrorProvider NewNameError;
        private System.Windows.Forms.ErrorProvider NewEmailError;
        private System.Windows.Forms.ErrorProvider NewNumberError;
        private System.Windows.Forms.ErrorProvider RatingError;
    }
}