namespace Trivago.Forms
{
    partial class AddHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.HotelRating = new Bunifu.Framework.UI.BunifuRating();
            this.AddHotelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.HotelNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.HotelEmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumberError = new System.Windows.Forms.ErrorProvider(this.components);
            this.HotelRatingError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CountryError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.StreetError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DescriptionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.HotelName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelEmailLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelContactNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelNumberLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelDescriptionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelRatingLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelCountry = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelCountryLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelCity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelCityLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.HotelStreet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelStreetLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.WelcomeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.close = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.HotelNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelEmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRatingError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionError)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelRating
            // 
            this.HotelRating.BackColor = System.Drawing.Color.Transparent;
            this.HotelRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelRating.Location = new System.Drawing.Point(605, 267);
            this.HotelRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HotelRating.Name = "HotelRating";
            this.HotelRating.Size = new System.Drawing.Size(314, 52);
            this.HotelRating.TabIndex = 4;
            this.HotelRating.Value = 0;
            // 
            // AddHotelButton
            // 
            this.AddHotelButton.BackColor = System.Drawing.Color.Transparent;
            this.AddHotelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddHotelButton.BackgroundImage")));
            this.AddHotelButton.ButtonText = "Add Hotel";
            this.AddHotelButton.ButtonTextMarginLeft = 0;
            this.AddHotelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddHotelButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddHotelButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddHotelButton.ForeColor = System.Drawing.Color.White;
            this.AddHotelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddHotelButton.IconPadding = 10;
            this.AddHotelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddHotelButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddHotelButton.IdleBorderRadius = 1;
            this.AddHotelButton.IdleBorderThickness = 0;
            this.AddHotelButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddHotelButton.IdleIconLeftImage = null;
            this.AddHotelButton.IdleIconRightImage = null;
            this.AddHotelButton.Location = new System.Drawing.Point(532, 569);
            this.AddHotelButton.Name = "AddHotelButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.AddHotelButton.onHoverState = stateProperties2;
            this.AddHotelButton.Size = new System.Drawing.Size(210, 45);
            this.AddHotelButton.TabIndex = 6;
            this.AddHotelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddHotelButton.Click += new System.EventHandler(this.AddHotelButton_Click);
            // 
            // HotelNameError
            // 
            this.HotelNameError.ContainerControl = this;
            // 
            // HotelEmailError
            // 
            this.HotelEmailError.ContainerControl = this;
            // 
            // NumberError
            // 
            this.NumberError.ContainerControl = this;
            // 
            // HotelRatingError
            // 
            this.HotelRatingError.ContainerControl = this;
            // 
            // CountryError
            // 
            this.CountryError.ContainerControl = this;
            // 
            // CityError
            // 
            this.CityError.ContainerControl = this;
            // 
            // StreetError
            // 
            this.StreetError.ContainerControl = this;
            // 
            // DescriptionError
            // 
            this.DescriptionError.ContainerControl = this;
            // 
            // HotelName
            // 
            this.HotelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelName.BackColor = System.Drawing.Color.White;
            this.HotelName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelName.HintForeColor = System.Drawing.Color.Empty;
            this.HotelName.HintText = "";
            this.HotelName.isPassword = false;
            this.HotelName.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelName.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelName.LineThickness = 3;
            this.HotelName.Location = new System.Drawing.Point(605, 0);
            this.HotelName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelName.MaxLength = 32767;
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(314, 47);
            this.HotelName.TabIndex = 40;
            this.HotelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelNameLabel
            // 
            this.HotelNameLabel.AutoSize = true;
            this.HotelNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelNameLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelNameLabel.Location = new System.Drawing.Point(392, 21);
            this.HotelNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelNameLabel.Name = "HotelNameLabel";
            this.HotelNameLabel.Size = new System.Drawing.Size(151, 26);
            this.HotelNameLabel.TabIndex = 43;
            this.HotelNameLabel.Text = "Hotel Name:";
            // 
            // HotelEmail
            // 
            this.HotelEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelEmail.BackColor = System.Drawing.Color.White;
            this.HotelEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelEmail.HintForeColor = System.Drawing.Color.Empty;
            this.HotelEmail.HintText = "";
            this.HotelEmail.isPassword = false;
            this.HotelEmail.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelEmail.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelEmail.LineThickness = 3;
            this.HotelEmail.Location = new System.Drawing.Point(605, 65);
            this.HotelEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelEmail.MaxLength = 32767;
            this.HotelEmail.Name = "HotelEmail";
            this.HotelEmail.Size = new System.Drawing.Size(314, 47);
            this.HotelEmail.TabIndex = 44;
            this.HotelEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelEmailLabel
            // 
            this.HotelEmailLabel.AutoSize = true;
            this.HotelEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelEmailLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelEmailLabel.Location = new System.Drawing.Point(392, 86);
            this.HotelEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelEmailLabel.Name = "HotelEmailLabel";
            this.HotelEmailLabel.Size = new System.Drawing.Size(148, 26);
            this.HotelEmailLabel.TabIndex = 45;
            this.HotelEmailLabel.Text = "Hotel Email:";
            // 
            // HotelContactNumber
            // 
            this.HotelContactNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelContactNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelContactNumber.BackColor = System.Drawing.Color.White;
            this.HotelContactNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelContactNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelContactNumber.HintForeColor = System.Drawing.Color.Empty;
            this.HotelContactNumber.HintText = "";
            this.HotelContactNumber.isPassword = false;
            this.HotelContactNumber.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelContactNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelContactNumber.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelContactNumber.LineThickness = 3;
            this.HotelContactNumber.Location = new System.Drawing.Point(605, 122);
            this.HotelContactNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelContactNumber.MaxLength = 32767;
            this.HotelContactNumber.Name = "HotelContactNumber";
            this.HotelContactNumber.Size = new System.Drawing.Size(314, 47);
            this.HotelContactNumber.TabIndex = 46;
            this.HotelContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelNumberLabel
            // 
            this.HotelNumberLabel.AutoSize = true;
            this.HotelNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelNumberLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelNumberLabel.Location = new System.Drawing.Point(389, 143);
            this.HotelNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelNumberLabel.Name = "HotelNumberLabel";
            this.HotelNumberLabel.Size = new System.Drawing.Size(175, 26);
            this.HotelNumberLabel.TabIndex = 47;
            this.HotelNumberLabel.Text = "Hotel Number:";
            // 
            // HotelDescription
            // 
            this.HotelDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelDescription.BackColor = System.Drawing.Color.White;
            this.HotelDescription.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelDescription.HintForeColor = System.Drawing.Color.Empty;
            this.HotelDescription.HintText = "";
            this.HotelDescription.isPassword = false;
            this.HotelDescription.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelDescription.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelDescription.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelDescription.LineThickness = 3;
            this.HotelDescription.Location = new System.Drawing.Point(605, 179);
            this.HotelDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelDescription.MaxLength = 32767;
            this.HotelDescription.Name = "HotelDescription";
            this.HotelDescription.Size = new System.Drawing.Size(314, 47);
            this.HotelDescription.TabIndex = 48;
            this.HotelDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelDescriptionLabel
            // 
            this.HotelDescriptionLabel.AutoSize = true;
            this.HotelDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelDescriptionLabel.Location = new System.Drawing.Point(385, 200);
            this.HotelDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelDescriptionLabel.Name = "HotelDescriptionLabel";
            this.HotelDescriptionLabel.Size = new System.Drawing.Size(211, 26);
            this.HotelDescriptionLabel.TabIndex = 49;
            this.HotelDescriptionLabel.Text = "Hotel Description:";
            // 
            // HotelRatingLabel
            // 
            this.HotelRatingLabel.AutoSize = true;
            this.HotelRatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelRatingLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRatingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelRatingLabel.Location = new System.Drawing.Point(389, 283);
            this.HotelRatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelRatingLabel.Name = "HotelRatingLabel";
            this.HotelRatingLabel.Size = new System.Drawing.Size(159, 26);
            this.HotelRatingLabel.TabIndex = 50;
            this.HotelRatingLabel.Text = "Hotel Rating:";
            // 
            // HotelCountry
            // 
            this.HotelCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelCountry.BackColor = System.Drawing.Color.White;
            this.HotelCountry.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelCountry.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelCountry.HintForeColor = System.Drawing.Color.Empty;
            this.HotelCountry.HintText = "";
            this.HotelCountry.isPassword = false;
            this.HotelCountry.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelCountry.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelCountry.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelCountry.LineThickness = 3;
            this.HotelCountry.Location = new System.Drawing.Point(605, 326);
            this.HotelCountry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelCountry.MaxLength = 32767;
            this.HotelCountry.Name = "HotelCountry";
            this.HotelCountry.Size = new System.Drawing.Size(314, 47);
            this.HotelCountry.TabIndex = 51;
            this.HotelCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelCountryLabel
            // 
            this.HotelCountryLabel.AutoSize = true;
            this.HotelCountryLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelCountryLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCountryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelCountryLabel.Location = new System.Drawing.Point(385, 347);
            this.HotelCountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelCountryLabel.Name = "HotelCountryLabel";
            this.HotelCountryLabel.Size = new System.Drawing.Size(175, 26);
            this.HotelCountryLabel.TabIndex = 52;
            this.HotelCountryLabel.Text = "Hotel Country:";
            // 
            // HotelCity
            // 
            this.HotelCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelCity.BackColor = System.Drawing.Color.White;
            this.HotelCity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelCity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelCity.HintForeColor = System.Drawing.Color.Empty;
            this.HotelCity.HintText = "";
            this.HotelCity.isPassword = false;
            this.HotelCity.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelCity.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelCity.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelCity.LineThickness = 3;
            this.HotelCity.Location = new System.Drawing.Point(605, 400);
            this.HotelCity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelCity.MaxLength = 32767;
            this.HotelCity.Name = "HotelCity";
            this.HotelCity.Size = new System.Drawing.Size(314, 47);
            this.HotelCity.TabIndex = 53;
            this.HotelCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelCityLabel
            // 
            this.HotelCityLabel.AutoSize = true;
            this.HotelCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelCityLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelCityLabel.Location = new System.Drawing.Point(385, 421);
            this.HotelCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelCityLabel.Name = "HotelCityLabel";
            this.HotelCityLabel.Size = new System.Drawing.Size(131, 26);
            this.HotelCityLabel.TabIndex = 54;
            this.HotelCityLabel.Text = "Hotel City:";
            // 
            // HotelStreet
            // 
            this.HotelStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HotelStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HotelStreet.BackColor = System.Drawing.Color.White;
            this.HotelStreet.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HotelStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HotelStreet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HotelStreet.HintForeColor = System.Drawing.Color.Empty;
            this.HotelStreet.HintText = "";
            this.HotelStreet.isPassword = false;
            this.HotelStreet.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.HotelStreet.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelStreet.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.HotelStreet.LineThickness = 3;
            this.HotelStreet.Location = new System.Drawing.Point(605, 466);
            this.HotelStreet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HotelStreet.MaxLength = 32767;
            this.HotelStreet.Name = "HotelStreet";
            this.HotelStreet.Size = new System.Drawing.Size(314, 47);
            this.HotelStreet.TabIndex = 55;
            this.HotelStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelStreetLabel
            // 
            this.HotelStreetLabel.AutoSize = true;
            this.HotelStreetLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelStreetLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelStreetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.HotelStreetLabel.Location = new System.Drawing.Point(392, 487);
            this.HotelStreetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelStreetLabel.Name = "HotelStreetLabel";
            this.HotelStreetLabel.Size = new System.Drawing.Size(156, 26);
            this.HotelStreetLabel.TabIndex = 56;
            this.HotelStreetLabel.Text = "Hotel Street:";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(89, 1);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(178, 46);
            this.bunifuLabel1.TabIndex = 57;
            this.bunifuLabel1.Text = "Add Hotel";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoEllipsis = false;
            this.WelcomeLabel.CursorType = null;
            this.WelcomeLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 136);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WelcomeLabel.Size = new System.Drawing.Size(158, 43);
            this.WelcomeLabel.TabIndex = 59;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.WelcomeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuTileButton2.Location = new System.Drawing.Point(248, 487);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(132, 230);
            this.bunifuTileButton2.TabIndex = 62;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = true;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.AutoSizeHeightOnly = true;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(3, 267);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(388, 52);
            this.bunifuLabel3.TabIndex = 63;
            this.bunifuLabel3.Text = "Here you can add a new hotel to our system.";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(819, 539);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(198, 127);
            this.bunifuTileButton1.TabIndex = 64;
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
            this.close.Location = new System.Drawing.Point(921, -20);
            this.close.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(85, 132);
            this.close.TabIndex = 65;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::Trivago.Properties.Resources.navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 626);
            this.Controls.Add(this.close);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.HotelStreetLabel);
            this.Controls.Add(this.HotelStreet);
            this.Controls.Add(this.HotelCityLabel);
            this.Controls.Add(this.HotelCity);
            this.Controls.Add(this.HotelCountryLabel);
            this.Controls.Add(this.HotelCountry);
            this.Controls.Add(this.HotelRatingLabel);
            this.Controls.Add(this.HotelDescriptionLabel);
            this.Controls.Add(this.HotelDescription);
            this.Controls.Add(this.HotelNumberLabel);
            this.Controls.Add(this.HotelContactNumber);
            this.Controls.Add(this.HotelEmailLabel);
            this.Controls.Add(this.HotelEmail);
            this.Controls.Add(this.HotelNameLabel);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.AddHotelButton);
            this.Controls.Add(this.HotelRating);
            this.DoubleBuffered = true;
            this.Name = "AddHotel";
            this.Text = "AddHotel";
            this.Load += new System.EventHandler(this.AddHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelEmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelRatingError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuRating HotelRating;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddHotelButton;
        private System.Windows.Forms.ErrorProvider HotelNameError;
        private System.Windows.Forms.ErrorProvider HotelEmailError;
        private System.Windows.Forms.ErrorProvider NumberError;
        private System.Windows.Forms.ErrorProvider HotelRatingError;
        private System.Windows.Forms.ErrorProvider CountryError;
        private System.Windows.Forms.ErrorProvider CityError;
        private System.Windows.Forms.ErrorProvider StreetError;
        private System.Windows.Forms.ErrorProvider DescriptionError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelNumberLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelContactNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelEmailLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelDescriptionLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelRatingLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelCountry;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelCountryLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelStreetLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelStreet;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelCityLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HotelCity;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel WelcomeLabel;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton close;
    }
}