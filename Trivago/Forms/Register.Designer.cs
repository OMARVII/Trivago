namespace Trivago.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.first = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.last = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mobile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateofbirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.m = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.f = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.close = new Bunifu.Framework.UI.BunifuTileButton();
            this.checkb = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.haveaccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.registerr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.first.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.first.BackColor = System.Drawing.Color.White;
            this.first.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.first.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.first.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.first.HintForeColor = System.Drawing.Color.Empty;
            this.first.HintText = "First Name";
            this.first.isPassword = false;
            this.first.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.first.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.first.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.first.LineThickness = 3;
            this.first.Location = new System.Drawing.Point(527, 63);
            this.first.Margin = new System.Windows.Forms.Padding(4);
            this.first.MaxLength = 32767;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(136, 32);
            this.first.TabIndex = 0;
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.first.OnValueChanged += new System.EventHandler(this.first_OnValueChanged);
            // 
            // last
            // 
            this.last.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.last.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.last.BackColor = System.Drawing.Color.White;
            this.last.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.last.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.last.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.last.HintForeColor = System.Drawing.Color.Empty;
            this.last.HintText = "Last Name";
            this.last.isPassword = false;
            this.last.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.last.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.last.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.last.LineThickness = 3;
            this.last.Location = new System.Drawing.Point(684, 63);
            this.last.Margin = new System.Windows.Forms.Padding(4);
            this.last.MaxLength = 32767;
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(131, 32);
            this.last.TabIndex = 1;
            this.last.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.last.OnValueChanged += new System.EventHandler(this.last_OnValueChanged);
            // 
            // email
            // 
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "Enter your email here";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.email.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(527, 122);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(288, 38);
            this.email.TabIndex = 2;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.OnValueChanged += new System.EventHandler(this.email_OnValueChanged);
            // 
            // password
            // 
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password.BackColor = System.Drawing.Color.White;
            this.password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.password.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(527, 196);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(288, 33);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // mobile
            // 
            this.mobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mobile.BackColor = System.Drawing.Color.White;
            this.mobile.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mobile.HintForeColor = System.Drawing.Color.Empty;
            this.mobile.HintText = "Enter your mobil here";
            this.mobile.isPassword = false;
            this.mobile.LineFocusedColor = System.Drawing.Color.DarkBlue;
            this.mobile.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.mobile.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            this.mobile.LineThickness = 3;
            this.mobile.Location = new System.Drawing.Point(527, 275);
            this.mobile.Margin = new System.Windows.Forms.Padding(4);
            this.mobile.MaxLength = 32767;
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(288, 33);
            this.mobile.TabIndex = 4;
            this.mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mobile.OnValueChanged += new System.EventHandler(this.mobile_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(384, 70);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 20);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Name:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.dateofbirth.BorderRadius = 0;
            this.dateofbirth.ForeColor = System.Drawing.Color.White;
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateofbirth.FormatCustom = null;
            this.dateofbirth.Location = new System.Drawing.Point(528, 345);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(287, 36);
            this.dateofbirth.TabIndex = 6;
            this.dateofbirth.Value = new System.DateTime(2019, 4, 27, 14, 27, 58, 456);
            this.dateofbirth.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(384, 134);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(73, 20);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "E-mail:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(384, 204);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 20);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Password:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(384, 283);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Mobile:";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(384, 352);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(126, 20);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Date of birth:";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // m
            // 
            this.m.BackColor = System.Drawing.Color.White;
            this.m.Checked = true;
            this.m.Location = new System.Drawing.Point(664, 415);
            this.m.Name = "m";
            this.m.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.m.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.m.Size = new System.Drawing.Size(25, 25);
            this.m.TabIndex = 11;
            this.m.Text = null;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.White;
            this.f.Checked = false;
            this.f.Location = new System.Drawing.Point(594, 415);
            this.f.Name = "f";
            this.f.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.f.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.f.Size = new System.Drawing.Size(25, 25);
            this.f.TabIndex = 12;
            this.f.Text = null;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(384, 415);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "Gender:";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(624, 418);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(19, 20);
            this.bunifuCustomLabel7.TabIndex = 16;
            this.bunifuCustomLabel7.Text = "F";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(695, 418);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(22, 20);
            this.bunifuCustomLabel8.TabIndex = 17;
            this.bunifuCustomLabel8.Text = "M";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel8_Click);
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(782, 561);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(150, 296);
            this.bunifuTileButton1.TabIndex = 19;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
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
            this.close.Location = new System.Drawing.Point(857, -5);
            this.close.Margin = new System.Windows.Forms.Padding(6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(66, 107);
            this.close.TabIndex = 20;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // checkb
            // 
            this.checkb.AllowBindingControlAnimation = true;
            this.checkb.AllowBindingControlColorChanges = false;
            this.checkb.AllowBindingControlLocation = true;
            this.checkb.AllowCheckBoxAnimation = false;
            this.checkb.AllowCheckmarkAnimation = true;
            this.checkb.AllowOnHoverStates = true;
            this.checkb.AutoCheck = true;
            this.checkb.BackColor = System.Drawing.Color.Transparent;
            this.checkb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkb.BackgroundImage")));
            this.checkb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkb.BindingControl = null;
            this.checkb.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkb.Checked = false;
            this.checkb.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.checkb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkb.CustomCheckmarkImage = null;
            this.checkb.Location = new System.Drawing.Point(534, 471);
            this.checkb.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkb.Name = "checkb";
            this.checkb.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnCheck.BorderRadius = 2;
            this.checkb.OnCheck.BorderThickness = 2;
            this.checkb.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkb.OnCheck.CheckmarkThickness = 2;
            this.checkb.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkb.OnDisable.BorderRadius = 2;
            this.checkb.OnDisable.BorderThickness = 2;
            this.checkb.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkb.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkb.OnDisable.CheckmarkThickness = 2;
            this.checkb.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnHoverChecked.BorderRadius = 2;
            this.checkb.OnHoverChecked.BorderThickness = 2;
            this.checkb.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkb.OnHoverChecked.CheckmarkThickness = 2;
            this.checkb.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnHoverUnchecked.BorderRadius = 2;
            this.checkb.OnHoverUnchecked.BorderThickness = 2;
            this.checkb.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkb.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.checkb.OnUncheck.BorderRadius = 2;
            this.checkb.OnUncheck.BorderThickness = 2;
            this.checkb.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkb.Size = new System.Drawing.Size(21, 21);
            this.checkb.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkb.TabIndex = 21;
            this.checkb.ThreeState = false;
            this.checkb.ToolTipText = null;
            this.checkb.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox1_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(570, 471);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(255, 20);
            this.bunifuLabel1.TabIndex = 22;
            this.bunifuLabel1.Text = "Agree on terms and conditions";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(26, 99);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(112, 25);
            this.bunifuLabel2.TabIndex = 23;
            this.bunifuLabel2.Text = "ABOUT US";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
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
            this.bunifuTileButton2.Location = new System.Drawing.Point(229, 339);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(99, 151);
            this.bunifuTileButton2.TabIndex = 25;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = true;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.AutoSizeHeightOnly = true;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(26, 155);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(291, 164);
            this.bunifuLabel3.TabIndex = 27;
            this.bunifuLabel3.Text = resources.GetString("bunifuLabel3.Text");
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click_1);
            // 
            // haveaccount
            // 
            this.haveaccount.Active = true;
            this.haveaccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.haveaccount.BackColor = System.Drawing.Color.White;
            this.haveaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.haveaccount.BorderRadius = 0;
            this.haveaccount.ButtonText = "Have An Account";
            this.haveaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.haveaccount.DisabledColor = System.Drawing.Color.Gray;
            this.haveaccount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveaccount.Iconcolor = System.Drawing.Color.Transparent;
            this.haveaccount.Iconimage = null;
            this.haveaccount.Iconimage_right = null;
            this.haveaccount.Iconimage_right_Selected = null;
            this.haveaccount.Iconimage_Selected = null;
            this.haveaccount.IconMarginLeft = 0;
            this.haveaccount.IconMarginRight = 0;
            this.haveaccount.IconRightVisible = true;
            this.haveaccount.IconRightZoom = 0D;
            this.haveaccount.IconVisible = true;
            this.haveaccount.IconZoom = 90D;
            this.haveaccount.IsTab = false;
            this.haveaccount.Location = new System.Drawing.Point(56, 384);
            this.haveaccount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.haveaccount.Name = "haveaccount";
            this.haveaccount.Normalcolor = System.Drawing.Color.White;
            this.haveaccount.OnHovercolor = System.Drawing.Color.White;
            this.haveaccount.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.haveaccount.selected = true;
            this.haveaccount.Size = new System.Drawing.Size(165, 45);
            this.haveaccount.TabIndex = 29;
            this.haveaccount.Text = "Have An Account";
            this.haveaccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.haveaccount.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.haveaccount.TextFont = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveaccount.Click += new System.EventHandler(this.haveaccount_Click);
            // 
            // registerr
            // 
            this.registerr.Active = false;
            this.registerr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.registerr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.registerr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerr.BorderRadius = 0;
            this.registerr.ButtonText = "Sign Up";
            this.registerr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerr.DisabledColor = System.Drawing.Color.Gray;
            this.registerr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerr.Iconcolor = System.Drawing.Color.Transparent;
            this.registerr.Iconimage = null;
            this.registerr.Iconimage_right = null;
            this.registerr.Iconimage_right_Selected = null;
            this.registerr.Iconimage_Selected = null;
            this.registerr.IconMarginLeft = 0;
            this.registerr.IconMarginRight = 0;
            this.registerr.IconRightVisible = true;
            this.registerr.IconRightZoom = 0D;
            this.registerr.IconVisible = true;
            this.registerr.IconZoom = 90D;
            this.registerr.IsTab = false;
            this.registerr.Location = new System.Drawing.Point(607, 519);
            this.registerr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.registerr.Name = "registerr";
            this.registerr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.registerr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.registerr.OnHoverTextColor = System.Drawing.Color.White;
            this.registerr.selected = false;
            this.registerr.Size = new System.Drawing.Size(146, 48);
            this.registerr.TabIndex = 35;
            this.registerr.Text = "Sign Up";
            this.registerr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerr.Textcolor = System.Drawing.Color.White;
            this.registerr.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerr.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Trivago.Properties.Resources.navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 631);
            this.Controls.Add(this.registerr);
            this.Controls.Add(this.haveaccount);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.checkb);
            this.Controls.Add(this.close);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.f);
            this.Controls.Add(this.m);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox first;
        private Bunifu.Framework.UI.BunifuMaterialTextbox last;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mobile;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dateofbirth;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.UI.WinForms.BunifuRadioButton m;
        private Bunifu.UI.WinForms.BunifuRadioButton f;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton close;
        private Bunifu.UI.WinForms.BunifuCheckBox checkb;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton haveaccount;
        private Bunifu.Framework.UI.BunifuFlatButton registerr;
    }
}