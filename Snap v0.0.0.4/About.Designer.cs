
namespace Snap
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.ProgramName = new System.Windows.Forms.Label();
            this.ProgramLogo = new System.Windows.Forms.PictureBox();
            this.ProgramVersion = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.Label();
            this.SnapMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.Winamp = new System.Windows.Forms.Timer(this.components);
            this.FooBar2000 = new System.Windows.Forms.Timer(this.components);
            this.VLC = new System.Windows.Forms.Timer(this.components);
            this.iTunes = new System.Windows.Forms.Timer(this.components);
            this.MusicBeeSupport = new System.Windows.Forms.Timer(this.components);
            this.ClementineSupport = new System.Windows.Forms.Timer(this.components);
            this.MPCHC = new System.Windows.Forms.Timer(this.components);
            this.PotPlayer = new System.Windows.Forms.Timer(this.components);
            this.Spotify = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).BeginInit();
            this.InfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramName.Location = new System.Drawing.Point(115, 19);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(66, 25);
            this.ProgramName.TabIndex = 0;
            this.ProgramName.Text = "Snap";
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.Image = ((System.Drawing.Image)(resources.GetObject("ProgramLogo.Image")));
            this.ProgramLogo.Location = new System.Drawing.Point(47, 18);
            this.ProgramLogo.Name = "ProgramLogo";
            this.ProgramLogo.Size = new System.Drawing.Size(62, 56);
            this.ProgramLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgramLogo.TabIndex = 1;
            this.ProgramLogo.TabStop = false;
            // 
            // ProgramVersion
            // 
            this.ProgramVersion.AutoSize = true;
            this.ProgramVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramVersion.Location = new System.Drawing.Point(116, 44);
            this.ProgramVersion.Name = "ProgramVersion";
            this.ProgramVersion.Size = new System.Drawing.Size(57, 20);
            this.ProgramVersion.TabIndex = 2;
            this.ProgramVersion.Text = "0.0.0.1";
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.HideButton);
            this.InfoBox.Controls.Add(this.InfoText);
            this.InfoBox.Location = new System.Drawing.Point(12, 84);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(202, 111);
            this.InfoBox.TabIndex = 3;
            this.InfoBox.TabStop = false;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(6, 85);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(190, 20);
            this.HideButton.TabIndex = 1;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.Location = new System.Drawing.Point(14, 14);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(174, 65);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "There is an icon in the status-bar /\r\nnotification area. Right click it and\r\nyou " +
    "will be prompted some options\r\nfor Snap. You can hide this window\r\nwith the hide" +
    " button below.";
            this.InfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SnapMenu
            // 
            this.SnapMenu.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SnapMenu.BalloonTipText = "Click this icon for more options for Snap.";
            this.SnapMenu.BalloonTipTitle = "Click Me For Options!";
            this.SnapMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("SnapMenu.Icon")));
            this.SnapMenu.Text = "Click For Options";
            this.SnapMenu.Visible = true;
            // 
            // Winamp
            // 
            this.Winamp.Tick += new System.EventHandler(this.Winamp_Tick);
            // 
            // FooBar2000
            // 
            this.FooBar2000.Tick += new System.EventHandler(this.FooBar2000_Tick);
            // 
            // VLC
            // 
            this.VLC.Tick += new System.EventHandler(this.VLC_Tick);
            // 
            // iTunes
            // 
            this.iTunes.Tick += new System.EventHandler(this.iTunes_Tick);
            // 
            // MusicBeeSupport
            // 
            this.MusicBeeSupport.Tick += new System.EventHandler(this.MusicBeeSupport_Tick);
            // 
            // ClementineSupport
            // 
            this.ClementineSupport.Tick += new System.EventHandler(this.ClementineSupport_Tick);
            // 
            // MPCHC
            // 
            this.MPCHC.Tick += new System.EventHandler(this.MPCHC_Tick);
            // 
            // PotPlayer
            // 
            this.PotPlayer.Tick += new System.EventHandler(this.PotPlayer_Tick);
            // 
            // Spotify
            // 
            this.Spotify.Tick += new System.EventHandler(this.Spotify_Tick);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(226, 207);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.ProgramVersion);
            this.Controls.Add(this.ProgramLogo);
            this.Controls.Add(this.ProgramName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Snap";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).EndInit();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.PictureBox ProgramLogo;
        private System.Windows.Forms.Label ProgramVersion;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.NotifyIcon SnapMenu;
        private System.Windows.Forms.Timer Winamp;
        private System.Windows.Forms.Timer FooBar2000;
        private System.Windows.Forms.Timer VLC;
        private System.Windows.Forms.Timer iTunes;
        private System.Windows.Forms.Timer MusicBeeSupport;
        private System.Windows.Forms.Timer ClementineSupport;
        private System.Windows.Forms.Timer MPCHC;
        private System.Windows.Forms.Timer PotPlayer;
        private System.Windows.Forms.Timer Spotify;
    }
}

