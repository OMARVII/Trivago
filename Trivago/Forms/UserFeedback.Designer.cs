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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFeedback));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.FeedBackDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FeedBackLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FeedbackText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HotelNames = new Bunifu.UI.WinForms.BunifuDropdown();
            this.HotelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // FeedBackDate
            // 
            this.FeedBackDate.AutoSize = true;
            this.FeedBackDate.Location = new System.Drawing.Point(170, 23);
            this.FeedBackDate.Name = "FeedBackDate";
            this.FeedBackDate.Size = new System.Drawing.Size(38, 17);
            this.FeedBackDate.TabIndex = 0;
            this.FeedBackDate.Text = "Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 17);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Feedback Date";
            // 
            // FeedBackLabel
            // 
            this.FeedBackLabel.AutoSize = true;
            this.FeedBackLabel.Location = new System.Drawing.Point(15, 173);
            this.FeedBackLabel.Name = "FeedBackLabel";
            this.FeedBackLabel.Size = new System.Drawing.Size(70, 17);
            this.FeedBackLabel.TabIndex = 2;
            this.FeedBackLabel.Text = "Feedback";
            // 
            // FeedbackText
            // 
            this.FeedbackText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FeedbackText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FeedbackText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FeedbackText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeedbackText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FeedbackText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FeedbackText.HintForeColor = System.Drawing.Color.Empty;
            this.FeedbackText.HintText = "Insert Your Feedback";
            this.FeedbackText.isPassword = false;
            this.FeedbackText.LineFocusedColor = System.Drawing.Color.Blue;
            this.FeedbackText.LineIdleColor = System.Drawing.Color.Gray;
            this.FeedbackText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FeedbackText.LineThickness = 3;
            this.FeedbackText.Location = new System.Drawing.Point(173, 157);
            this.FeedbackText.Margin = new System.Windows.Forms.Padding(4);
            this.FeedbackText.MaxLength = 32767;
            this.FeedbackText.Name = "FeedbackText";
            this.FeedbackText.Size = new System.Drawing.Size(379, 33);
            this.FeedbackText.TabIndex = 3;
            this.FeedbackText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HotelNames
            // 
            this.HotelNames.BackColor = System.Drawing.SystemColors.Control;
            this.HotelNames.BorderRadius = 1;
            this.HotelNames.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.HotelNames.DisabledColor = System.Drawing.Color.Gray;
            this.HotelNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HotelNames.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.HotelNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelNames.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.HotelNames.FillDropDown = false;
            this.HotelNames.FillIndicator = false;
            this.HotelNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotelNames.ForeColor = System.Drawing.Color.Purple;
            this.HotelNames.FormattingEnabled = true;
            this.HotelNames.Icon = null;
            this.HotelNames.IndicatorColor = System.Drawing.Color.Purple;
            this.HotelNames.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.HotelNames.ItemBackColor = System.Drawing.Color.White;
            this.HotelNames.ItemBorderColor = System.Drawing.Color.White;
            this.HotelNames.ItemForeColor = System.Drawing.Color.Purple;
            this.HotelNames.ItemHeight = 26;
            this.HotelNames.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.HotelNames.Location = new System.Drawing.Point(173, 77);
            this.HotelNames.Name = "HotelNames";
            this.HotelNames.Size = new System.Drawing.Size(217, 32);
            this.HotelNames.TabIndex = 4;
            this.HotelNames.Text = "Hotel Name";
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(15, 91);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(84, 17);
            this.HotelLabel.TabIndex = 5;
            this.HotelLabel.Text = "Select Hotel";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitButton.BackgroundImage")));
            this.SubmitButton.ButtonText = "Submit Feedback";
            this.SubmitButton.ButtonTextMarginLeft = 0;
            this.SubmitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SubmitButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.SubmitButton.DisabledForecolor = System.Drawing.Color.White;
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitButton.IconPadding = 10;
            this.SubmitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.SubmitButton.IdleBorderRadius = 1;
            this.SubmitButton.IdleBorderThickness = 0;
            this.SubmitButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.SubmitButton.IdleIconLeftImage = null;
            this.SubmitButton.IdleIconRightImage = null;
            this.SubmitButton.Location = new System.Drawing.Point(255, 365);
            this.SubmitButton.Name = "SubmitButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.SubmitButton.onHoverState = stateProperties2;
            this.SubmitButton.Size = new System.Drawing.Size(210, 45);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UserFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HotelLabel);
            this.Controls.Add(this.HotelNames);
            this.Controls.Add(this.FeedbackText);
            this.Controls.Add(this.FeedBackLabel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.FeedBackDate);
            this.Name = "UserFeedback";
            this.Text = "UserFeedback";
            this.Load += new System.EventHandler(this.UserFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel FeedBackDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel FeedBackLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FeedbackText;
        private Bunifu.UI.WinForms.BunifuDropdown HotelNames;
        private Bunifu.Framework.UI.BunifuCustomLabel HotelLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SubmitButton;
    }
}