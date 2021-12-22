namespace NicolausiKey
{
    partial class ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.ButtonGenerateKey = new System.Windows.Forms.Button();
            this.TextBoxNameInput = new System.Windows.Forms.TextBox();
            this.ComboBoxGameSelect = new System.Windows.Forms.ComboBox();
            this.GroupBoxNameInputGameSelect = new System.Windows.Forms.GroupBox();
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.GroupBoxRegistrationCode = new System.Windows.Forms.GroupBox();
            this.GroupBoxNameInputGameSelect.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.GroupBoxRegistrationCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonGenerateKey
            // 
            this.ButtonGenerateKey.Location = new System.Drawing.Point(11, 48);
            this.ButtonGenerateKey.Name = "ButtonGenerateKey";
            this.ButtonGenerateKey.Size = new System.Drawing.Size(238, 25);
            this.ButtonGenerateKey.TabIndex = 0;
            this.ButtonGenerateKey.Text = "Generate Key";
            this.ButtonGenerateKey.UseVisualStyleBackColor = true;
            this.ButtonGenerateKey.Click += new System.EventHandler(this.ButtonGenerateKey_Click);
            // 
            // TextBoxNameInput
            // 
            this.TextBoxNameInput.Location = new System.Drawing.Point(12, 22);
            this.TextBoxNameInput.Name = "TextBoxNameInput";
            this.TextBoxNameInput.Size = new System.Drawing.Size(237, 20);
            this.TextBoxNameInput.TabIndex = 1;
            // 
            // ComboBoxGameSelect
            // 
            this.ComboBoxGameSelect.FormattingEnabled = true;
            this.ComboBoxGameSelect.Location = new System.Drawing.Point(11, 48);
            this.ComboBoxGameSelect.Name = "ComboBoxGameSelect";
            this.ComboBoxGameSelect.Size = new System.Drawing.Size(237, 21);
            this.ComboBoxGameSelect.TabIndex = 2;
            // 
            // GroupBoxNameInputGameSelect
            // 
            this.GroupBoxNameInputGameSelect.Controls.Add(this.ComboBoxGameSelect);
            this.GroupBoxNameInputGameSelect.Controls.Add(this.TextBoxNameInput);
            this.GroupBoxNameInputGameSelect.Location = new System.Drawing.Point(12, 149);
            this.GroupBoxNameInputGameSelect.Name = "GroupBoxNameInputGameSelect";
            this.GroupBoxNameInputGameSelect.Size = new System.Drawing.Size(260, 84);
            this.GroupBoxNameInputGameSelect.TabIndex = 3;
            this.GroupBoxNameInputGameSelect.TabStop = false;
            this.GroupBoxNameInputGameSelect.Text = "Name Input and GameSelect";
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Location = new System.Drawing.Point(12, 22);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.ReadOnly = true;
            this.TextBoxKey.Size = new System.Drawing.Size(237, 20);
            this.TextBoxKey.TabIndex = 6;
            this.TextBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout,
            this.MenuItemGitHub});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 7;
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuItemGitHub
            // 
            this.MenuItemGitHub.Name = "MenuItemGitHub";
            this.MenuItemGitHub.Size = new System.Drawing.Size(57, 20);
            this.MenuItemGitHub.Text = "GitHub";
            this.MenuItemGitHub.Click += new System.EventHandler(this.MenuItemGitHub_Click);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(13, 29);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(260, 116);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 8;
            this.PictureBoxLogo.TabStop = false;
            // 
            // GroupBoxRegistrationCode
            // 
            this.GroupBoxRegistrationCode.Controls.Add(this.TextBoxKey);
            this.GroupBoxRegistrationCode.Controls.Add(this.ButtonGenerateKey);
            this.GroupBoxRegistrationCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxRegistrationCode.Location = new System.Drawing.Point(12, 239);
            this.GroupBoxRegistrationCode.Name = "GroupBoxRegistrationCode";
            this.GroupBoxRegistrationCode.Size = new System.Drawing.Size(260, 84);
            this.GroupBoxRegistrationCode.TabIndex = 9;
            this.GroupBoxRegistrationCode.TabStop = false;
            this.GroupBoxRegistrationCode.Text = "Registration Code";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.GroupBoxRegistrationCode);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.GroupBoxNameInputGameSelect);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "ProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NicolausiKey";
            this.GroupBoxNameInputGameSelect.ResumeLayout(false);
            this.GroupBoxNameInputGameSelect.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.GroupBoxRegistrationCode.ResumeLayout(false);
            this.GroupBoxRegistrationCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerateKey;
        private System.Windows.Forms.TextBox TextBoxNameInput;
        private System.Windows.Forms.ComboBox ComboBoxGameSelect;
        private System.Windows.Forms.GroupBox GroupBoxNameInputGameSelect;
        private System.Windows.Forms.TextBox TextBoxKey;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.GroupBox GroupBoxRegistrationCode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGitHub;
    }
}