namespace Trivago.Forms
{
    partial class AddWebsite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWebsite));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.AddWebsiteProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.AddWesbsiteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddWebsiteTimer = new System.Windows.Forms.Timer(this.components);
            this.WebsiteNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.WebsiteNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWebsiteProgressBar
            // 
            this.AddWebsiteProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.AddWebsiteProgressBar.BorderRadius = 5;
            this.AddWebsiteProgressBar.Location = new System.Drawing.Point(51, 18);
            this.AddWebsiteProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.AddWebsiteProgressBar.MaximumValue = 100;
            this.AddWebsiteProgressBar.Name = "AddWebsiteProgressBar";
            this.AddWebsiteProgressBar.ProgressColor = System.Drawing.Color.White;
            this.AddWebsiteProgressBar.Size = new System.Drawing.Size(1109, 12);
            this.AddWebsiteProgressBar.TabIndex = 10;
            this.AddWebsiteProgressBar.Value = 0;
            // 
            // AddWesbsiteButton
            // 
            this.AddWesbsiteButton.BackColor = System.Drawing.Color.Transparent;
            this.AddWesbsiteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWesbsiteButton.BackgroundImage")));
            this.AddWesbsiteButton.ButtonText = "Add Website";
            this.AddWesbsiteButton.ButtonTextMarginLeft = 0;
            this.AddWesbsiteButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddWesbsiteButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddWesbsiteButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddWesbsiteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWesbsiteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.AddWesbsiteButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IconPadding = 10;
            this.AddWesbsiteButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IdleBorderColor = System.Drawing.Color.White;
            this.AddWesbsiteButton.IdleBorderRadius = 1;
            this.AddWesbsiteButton.IdleBorderThickness = 0;
            this.AddWesbsiteButton.IdleFillColor = System.Drawing.Color.White;
            this.AddWesbsiteButton.IdleIconLeftImage = null;
            this.AddWesbsiteButton.IdleIconRightImage = null;
            this.AddWesbsiteButton.Location = new System.Drawing.Point(407, 560);
            this.AddWesbsiteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddWesbsiteButton.Name = "AddWesbsiteButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.AddWesbsiteButton.onHoverState = stateProperties1;
            this.AddWesbsiteButton.Size = new System.Drawing.Size(194, 37);
            this.AddWesbsiteButton.TabIndex = 6;
            this.AddWesbsiteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddWesbsiteButton.Click += new System.EventHandler(this.AddWesbsiteButton_Click);
            // 
            // AddWebsiteTimer
            // 
            this.AddWebsiteTimer.Tick += new System.EventHandler(this.AddWebsiteTimer_Tick);
            // 
            // WebsiteNameError
            // 
            this.WebsiteNameError.ContainerControl = this;
            // 
            // WebsiteNameTextBox
            // 
            this.WebsiteNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.WebsiteNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.WebsiteNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.WebsiteNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WebsiteNameTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteNameTextBox.ForeColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.HintForeColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.HintText = "Enter website name here";
            this.WebsiteNameTextBox.isPassword = false;
            this.WebsiteNameTextBox.LineFocusedColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineIdleColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.WebsiteNameTextBox.LineThickness = 3;
            this.WebsiteNameTextBox.Location = new System.Drawing.Point(487, 566);
            this.WebsiteNameTextBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.WebsiteNameTextBox.MaxLength = 32767;
            this.WebsiteNameTextBox.Name = "WebsiteNameTextBox";
            this.WebsiteNameTextBox.Size = new System.Drawing.Size(360, 46);
            this.WebsiteNameTextBox.TabIndex = 11;
            this.WebsiteNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 25;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(1183, 5);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(51, 51);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 18;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.BorderRadius = 22;
            this.bunifuPictureBox2.Image = global::Trivago.Properties.Resources.bk;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(12, 5);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(44, 44);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 71;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox2.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // AddWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::Trivago.Properties.Resources.trivagoo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(929, 631);
            this.Controls.Add(this.bunifuPictureBox2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.WebsiteNameTextBox);
            this.Controls.Add(this.AddWebsiteProgressBar);
            this.Controls.Add(this.AddWesbsiteButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWebsite";
            this.Load += new System.EventHandler(this.AddWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar AddWebsiteProgressBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddWesbsiteButton;
        private System.Windows.Forms.Timer AddWebsiteTimer;
        private System.Windows.Forms.ErrorProvider WebsiteNameError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WebsiteNameTextBox;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}