namespace ImageAlphaAdd
{
    partial class frmImageAlphaAdder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageAlphaAdder));
            this.btnBaseImage = new System.Windows.Forms.Button();
            this.txtBaseImageLocation = new System.Windows.Forms.TextBox();
            this.txtAlphaImageLocation = new System.Windows.Forms.TextBox();
            this.btnAlpha = new System.Windows.Forms.Button();
            this.lblCreditTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGithubLink = new System.Windows.Forms.Button();
            this.btnSteamLink = new System.Windows.Forms.Button();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.lblOptionsTitle = new System.Windows.Forms.Label();
            this.radTextures = new System.Windows.Forms.RadioButton();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.tmrExpandWindow = new System.Windows.Forms.Timer(this.components);
            this.tmrRetractWindow = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrLabelSwitchPrompt = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseImage
            // 
            this.btnBaseImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseImage.Location = new System.Drawing.Point(13, 47);
            this.btnBaseImage.Name = "btnBaseImage";
            this.btnBaseImage.Size = new System.Drawing.Size(140, 27);
            this.btnBaseImage.TabIndex = 0;
            this.btnBaseImage.Text = "Base Image";
            this.btnBaseImage.UseVisualStyleBackColor = true;
            this.btnBaseImage.Click += new System.EventHandler(this.btnBaseImage_Click);
            // 
            // txtBaseImageLocation
            // 
            this.txtBaseImageLocation.BackColor = System.Drawing.Color.DimGray;
            this.txtBaseImageLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBaseImageLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseImageLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBaseImageLocation.Location = new System.Drawing.Point(160, 48);
            this.txtBaseImageLocation.Name = "txtBaseImageLocation";
            this.txtBaseImageLocation.Size = new System.Drawing.Size(413, 26);
            this.txtBaseImageLocation.TabIndex = 1;
            // 
            // txtAlphaImageLocation
            // 
            this.txtAlphaImageLocation.BackColor = System.Drawing.Color.DimGray;
            this.txtAlphaImageLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlphaImageLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlphaImageLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAlphaImageLocation.Location = new System.Drawing.Point(160, 79);
            this.txtAlphaImageLocation.Name = "txtAlphaImageLocation";
            this.txtAlphaImageLocation.Size = new System.Drawing.Size(413, 26);
            this.txtAlphaImageLocation.TabIndex = 3;
            // 
            // btnAlpha
            // 
            this.btnAlpha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlpha.Location = new System.Drawing.Point(13, 78);
            this.btnAlpha.Name = "btnAlpha";
            this.btnAlpha.Size = new System.Drawing.Size(140, 27);
            this.btnAlpha.TabIndex = 2;
            this.btnAlpha.Text = "Alpha Image";
            this.btnAlpha.UseVisualStyleBackColor = true;
            this.btnAlpha.Click += new System.EventHandler(this.btnAlpha_Click);
            // 
            // lblCreditTitle
            // 
            this.lblCreditTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCreditTitle.Location = new System.Drawing.Point(592, 10);
            this.lblCreditTitle.Name = "lblCreditTitle";
            this.lblCreditTitle.Size = new System.Drawing.Size(225, 31);
            this.lblCreditTitle.TabIndex = 4;
            this.lblCreditTitle.Text = "Created By: DefyTheRush";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImageAlphaAdd.Properties.Resources.defypicture_start;
            this.pictureBox1.Location = new System.Drawing.Point(638, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnGithubLink
            // 
            this.btnGithubLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithubLink.Location = new System.Drawing.Point(707, 188);
            this.btnGithubLink.Name = "btnGithubLink";
            this.btnGithubLink.Size = new System.Drawing.Size(104, 27);
            this.btnGithubLink.TabIndex = 7;
            this.btnGithubLink.Text = "GitHub Link";
            this.btnGithubLink.UseVisualStyleBackColor = true;
            this.btnGithubLink.Click += new System.EventHandler(this.btnGithubLink_Click);
            // 
            // btnSteamLink
            // 
            this.btnSteamLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteamLink.Location = new System.Drawing.Point(597, 188);
            this.btnSteamLink.Name = "btnSteamLink";
            this.btnSteamLink.Size = new System.Drawing.Size(104, 27);
            this.btnSteamLink.TabIndex = 6;
            this.btnSteamLink.Text = "Steam Link";
            this.btnSteamLink.UseVisualStyleBackColor = true;
            this.btnSteamLink.Click += new System.EventHandler(this.btnSteamLink_Click);
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProgramTitle.Location = new System.Drawing.Point(208, 10);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(181, 25);
            this.lblProgramTitle.TabIndex = 8;
            this.lblProgramTitle.Text = "Image Alpha Adder";
            // 
            // lblOptionsTitle
            // 
            this.lblOptionsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionsTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionsTitle.Location = new System.Drawing.Point(259, 115);
            this.lblOptionsTitle.Name = "lblOptionsTitle";
            this.lblOptionsTitle.Size = new System.Drawing.Size(83, 25);
            this.lblOptionsTitle.TabIndex = 10;
            this.lblOptionsTitle.Text = "Options";
            // 
            // radTextures
            // 
            this.radTextures.Checked = true;
            this.radTextures.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextures.ForeColor = System.Drawing.SystemColors.Window;
            this.radTextures.Location = new System.Drawing.Point(264, 149);
            this.radTextures.Name = "radTextures";
            this.radTextures.Size = new System.Drawing.Size(73, 22);
            this.radTextures.TabIndex = 11;
            this.radTextures.TabStop = true;
            this.radTextures.Text = "Textures";
            this.radTextures.UseVisualStyleBackColor = true;
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.Location = new System.Drawing.Point(370, 183);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(140, 27);
            this.btnCredits.TabIndex = 13;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunProgram.Location = new System.Drawing.Point(78, 183);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(140, 27);
            this.btnRunProgram.TabIndex = 12;
            this.btnRunProgram.Text = "Run Program";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // tmrExpandWindow
            // 
            this.tmrExpandWindow.Interval = 10;
            this.tmrExpandWindow.Tick += new System.EventHandler(this.tmrExpandWindow_Tick);
            // 
            // tmrRetractWindow
            // 
            this.tmrRetractWindow.Interval = 10;
            this.tmrRetractWindow.Tick += new System.EventHandler(this.tmrRetractWindow_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(224, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 27);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrLabelSwitchPrompt
            // 
            this.tmrLabelSwitchPrompt.Interval = 1000;
            this.tmrLabelSwitchPrompt.Tick += new System.EventHandler(this.tmrErrorMessage_Tick);
            // 
            // frmImageAlphaAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(585, 226);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnRunProgram);
            this.Controls.Add(this.radTextures);
            this.Controls.Add(this.lblOptionsTitle);
            this.Controls.Add(this.lblProgramTitle);
            this.Controls.Add(this.btnGithubLink);
            this.Controls.Add(this.btnSteamLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCreditTitle);
            this.Controls.Add(this.txtAlphaImageLocation);
            this.Controls.Add(this.btnAlpha);
            this.Controls.Add(this.txtBaseImageLocation);
            this.Controls.Add(this.btnBaseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImageAlphaAdder";
            this.Text = "Image Alpha Adder | By DefyTheRush";
            this.Load += new System.EventHandler(this.frmImageAlphaAdder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaseImage;
        private System.Windows.Forms.TextBox txtBaseImageLocation;
        private System.Windows.Forms.TextBox txtAlphaImageLocation;
        private System.Windows.Forms.Button btnAlpha;
        private System.Windows.Forms.Label lblCreditTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGithubLink;
        private System.Windows.Forms.Button btnSteamLink;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.Label lblOptionsTitle;
        private System.Windows.Forms.RadioButton radTextures;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.Timer tmrExpandWindow;
        private System.Windows.Forms.Timer tmrRetractWindow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrLabelSwitchPrompt;
    }
}

