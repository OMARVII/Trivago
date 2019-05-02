namespace Trivago.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.EmailTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.ForeColor = System.Drawing.Color.White;
            this.EmailTxtBox.HintForeColor = System.Drawing.Color.White;
            this.EmailTxtBox.HintText = "Enter Email";
            this.EmailTxtBox.isPassword = false;
            this.EmailTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.EmailTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.EmailTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.EmailTxtBox.LineThickness = 3;
            this.EmailTxtBox.Location = new System.Drawing.Point(98, 57);
            this.EmailTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTxtBox.MaxLength = 32767;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(252, 33);
            this.EmailTxtBox.TabIndex = 7;
            this.EmailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtBox.HintForeColor = System.Drawing.Color.White;
            this.PasswordTxtBox.HintText = "Enter Password";
            this.PasswordTxtBox.isPassword = true;
            this.PasswordTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.PasswordTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.PasswordTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.PasswordTxtBox.LineThickness = 3;
            this.PasswordTxtBox.Location = new System.Drawing.Point(98, 119);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTxtBox.MaxLength = 32767;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(252, 33);
            this.PasswordTxtBox.TabIndex = 8;
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 19;
            this.bunifuPictureBox1.Image = global::Trivago.Properties.Resources.closeW;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(420, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 67;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(358, 220);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(118, 84);
            this.bunifuTileButton1.TabIndex = 66;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "LOGIN";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.White;
            this.LoginBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.LoginBtn.IdleBorderRadius = 1;
            this.LoginBtn.IdleBorderThickness = 0;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.Location = new System.Drawing.Point(98, 200);
            this.LoginBtn.Name = "LoginBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.LoginBtn.onHoverState = stateProperties1;
            this.LoginBtn.Size = new System.Drawing.Size(252, 45);
            this.LoginBtn.TabIndex = 21;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(468, 286);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTxtBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginBtn;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}