
namespace ECommerce_Project
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblCopyright = new System.Windows.Forms.Label();
            this.PbSplashScreen = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PcbLogo.Image")));
            this.PcbLogo.Location = new System.Drawing.Point(124, 172);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(84, 81);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbLogo.TabIndex = 7;
            this.PcbLogo.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Modern No. 20", 55.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitle.Location = new System.Drawing.Point(181, 165);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(473, 95);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Rocket Box";
            // 
            // LblCopyright
            // 
            this.LblCopyright.AutoSize = true;
            this.LblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.LblCopyright.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopyright.ForeColor = System.Drawing.Color.White;
            this.LblCopyright.Location = new System.Drawing.Point(12, 407);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(630, 22);
            this.LblCopyright.TabIndex = 8;
            this.LblCopyright.Text = "Ⓒ Copyright: Todos os Direitos e imagens estão reservados a Rocket Box Inc. ";
            // 
            // PbSplashScreen
            // 
            this.PbSplashScreen.Location = new System.Drawing.Point(-2, 444);
            this.PbSplashScreen.Maximum = 500;
            this.PbSplashScreen.Name = "PbSplashScreen";
            this.PbSplashScreen.Size = new System.Drawing.Size(806, 14);
            this.PbSplashScreen.Step = 500;
            this.PbSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PbSplashScreen.TabIndex = 9;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbSplashScreen);
            this.Controls.Add(this.LblCopyright);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket Box";
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCopyright;
        private System.Windows.Forms.ProgressBar PbSplashScreen;
    }
}