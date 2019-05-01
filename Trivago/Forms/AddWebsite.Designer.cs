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
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWebsiteProgressBar
            // 
            this.AddWebsiteProgressBar.BackColor = System.Drawing.Color.Silver;
            this.AddWebsiteProgressBar.BorderRadius = 5;
            this.AddWebsiteProgressBar.Location = new System.Drawing.Point(3, 31);
            this.AddWebsiteProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddWebsiteProgressBar.MaximumValue = 100;
            this.AddWebsiteProgressBar.Name = "AddWebsiteProgressBar";
            this.AddWebsiteProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.AddWebsiteProgressBar.Size = new System.Drawing.Size(722, 8);
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
            this.AddWesbsiteButton.ForeColor = System.Drawing.Color.White;
            this.AddWesbsiteButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IconPadding = 10;
            this.AddWesbsiteButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddWesbsiteButton.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.AddWesbsiteButton.IdleBorderRadius = 1;
            this.AddWesbsiteButton.IdleBorderThickness = 0;
            this.AddWesbsiteButton.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.AddWesbsiteButton.IdleIconLeftImage = null;
            this.AddWesbsiteButton.IdleIconRightImage = null;
            this.AddWesbsiteButton.Location = new System.Drawing.Point(302, 292);
            this.AddWesbsiteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddWesbsiteButton.Name = "AddWesbsiteButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.AddWesbsiteButton.onHoverState = stateProperties1;
            this.AddWesbsiteButton.Size = new System.Drawing.Size(158, 37);
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
            this.WebsiteNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.WebsiteNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WebsiteNameTextBox.HintForeColor = System.Drawing.Color.Silver;
            this.WebsiteNameTextBox.HintText = "Enter Website Name.";
            this.WebsiteNameTextBox.isPassword = false;
            this.WebsiteNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.WebsiteNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.WebsiteNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.WebsiteNameTextBox.LineThickness = 3;
            this.WebsiteNameTextBox.Location = new System.Drawing.Point(233, 250);
            this.WebsiteNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WebsiteNameTextBox.MaxLength = 32767;
            this.WebsiteNameTextBox.Name = "WebsiteNameTextBox";
            this.WebsiteNameTextBox.Size = new System.Drawing.Size(284, 27);
            this.WebsiteNameTextBox.TabIndex = 11;
            this.WebsiteNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivago.Properties.Resources.trivago_logo_new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 374);
            this.Controls.Add(this.WebsiteNameTextBox);
            this.Controls.Add(this.AddWebsiteProgressBar);
            this.Controls.Add(this.AddWesbsiteButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddWebsite";
            this.Text = "AddWebsite";
            this.Load += new System.EventHandler(this.AddWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteNameError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar AddWebsiteProgressBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddWesbsiteButton;
        private System.Windows.Forms.Timer AddWebsiteTimer;
        private System.Windows.Forms.ErrorProvider WebsiteNameError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WebsiteNameTextBox;
    }
}