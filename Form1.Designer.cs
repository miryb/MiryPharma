
namespace MiryPharma
{
    partial class HomePharmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePharmaForm));
            this.AddDrugsButton = new System.Windows.Forms.Button();
            this.WelcomeMsgLabel = new System.Windows.Forms.Label();
            this.ViewDrugsButton = new System.Windows.Forms.Button();
            this.MailLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BannerPicturBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPicturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDrugsButton
            // 
            this.AddDrugsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(67)))));
            this.AddDrugsButton.FlatAppearance.BorderSize = 0;
            this.AddDrugsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.AddDrugsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDrugsButton.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddDrugsButton.Location = new System.Drawing.Point(507, 464);
            this.AddDrugsButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddDrugsButton.Name = "AddDrugsButton";
            this.AddDrugsButton.Size = new System.Drawing.Size(364, 80);
            this.AddDrugsButton.TabIndex = 26;
            this.AddDrugsButton.Text = "Add";
            this.AddDrugsButton.UseVisualStyleBackColor = false;
            this.AddDrugsButton.Click += new System.EventHandler(this.AddDrugsButton_Click);
            // 
            // WelcomeMsgLabel
            // 
            this.WelcomeMsgLabel.AutoSize = true;
            this.WelcomeMsgLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsgLabel.ForeColor = System.Drawing.Color.Black;
            this.WelcomeMsgLabel.Location = new System.Drawing.Point(135, 9);
            this.WelcomeMsgLabel.Name = "WelcomeMsgLabel";
            this.WelcomeMsgLabel.Size = new System.Drawing.Size(329, 22);
            this.WelcomeMsgLabel.TabIndex = 1;
            this.WelcomeMsgLabel.Text = "This is an app for managing my medicine at home";
            // 
            // ViewDrugsButton
            // 
            this.ViewDrugsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ViewDrugsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewDrugsButton.FlatAppearance.BorderSize = 0;
            this.ViewDrugsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewDrugsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDrugsButton.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold);
            this.ViewDrugsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ViewDrugsButton.Location = new System.Drawing.Point(139, 464);
            this.ViewDrugsButton.Margin = new System.Windows.Forms.Padding(0);
            this.ViewDrugsButton.Name = "ViewDrugsButton";
            this.ViewDrugsButton.Size = new System.Drawing.Size(368, 80);
            this.ViewDrugsButton.TabIndex = 28;
            this.ViewDrugsButton.Text = "View";
            this.ViewDrugsButton.UseVisualStyleBackColor = false;
            this.ViewDrugsButton.Click += new System.EventHandler(this.ViewDrugsButton_Click);
            // 
            // MailLinkLabel1
            // 
            this.MailLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.MailLinkLabel1.Image = global::MiryPharma.Properties.Resources.outlook_small;
            this.MailLinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MailLinkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.MailLinkLabel1.Location = new System.Drawing.Point(442, 544);
            this.MailLinkLabel1.Name = "MailLinkLabel1";
            this.MailLinkLabel1.Size = new System.Drawing.Size(129, 167);
            this.MailLinkLabel1.TabIndex = 29;
            this.MailLinkLabel1.TabStop = true;
            this.MailLinkLabel1.Text = "Mail Me!";
            this.MailLinkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MailLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailLinkLabel1_LinkClicked);
            // 
            // BannerPicturBox
            // 
            this.BannerPicturBox.BackgroundImage = global::MiryPharma.Properties.Resources.Laughter;
            this.BannerPicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BannerPicturBox.Location = new System.Drawing.Point(138, 61);
            this.BannerPicturBox.Margin = new System.Windows.Forms.Padding(0);
            this.BannerPicturBox.Name = "BannerPicturBox";
            this.BannerPicturBox.Size = new System.Drawing.Size(733, 373);
            this.BannerPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BannerPicturBox.TabIndex = 27;
            this.BannerPicturBox.TabStop = false;
            this.BannerPicturBox.Click += new System.EventHandler(this.BannerPicturBox_Click);
            // 
            // HomePharmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1035, 769);
            this.Controls.Add(this.MailLinkLabel1);
            this.Controls.Add(this.ViewDrugsButton);
            this.Controls.Add(this.BannerPicturBox);
            this.Controls.Add(this.WelcomeMsgLabel);
            this.Controls.Add(this.AddDrugsButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePharmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MirY Pharma";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePharmaForm_FormClosed);
            this.Load += new System.EventHandler(this.HomePharmaForm_Load);
            this.Shown += new System.EventHandler(this.HomePharmaForm_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.BannerPicturBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDrugsButton;
        private System.Windows.Forms.Label WelcomeMsgLabel;
        private System.Windows.Forms.PictureBox BannerPicturBox;
        private System.Windows.Forms.Button ViewDrugsButton;
        private System.Windows.Forms.LinkLabel MailLinkLabel1;
    }
}

