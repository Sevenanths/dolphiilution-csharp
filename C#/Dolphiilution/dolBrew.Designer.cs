namespace Dolphiilution
{
    partial class dolBrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dolBrew));
            this.pbxWiiFlash = new System.Windows.Forms.PictureBox();
            this.pbxWindots = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrShutdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWiiFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWindots)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxWiiFlash
            // 
            this.pbxWiiFlash.Image = ((System.Drawing.Image)(resources.GetObject("pbxWiiFlash.Image")));
            this.pbxWiiFlash.Location = new System.Drawing.Point(214, 12);
            this.pbxWiiFlash.Name = "pbxWiiFlash";
            this.pbxWiiFlash.Size = new System.Drawing.Size(213, 231);
            this.pbxWiiFlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWiiFlash.TabIndex = 0;
            this.pbxWiiFlash.TabStop = false;
            // 
            // pbxWindots
            // 
            this.pbxWindots.Image = ((System.Drawing.Image)(resources.GetObject("pbxWindots.Image")));
            this.pbxWindots.Location = new System.Drawing.Point(12, 113);
            this.pbxWindots.Name = "pbxWindots";
            this.pbxWindots.Size = new System.Drawing.Size(220, 20);
            this.pbxWindots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxWindots.TabIndex = 1;
            this.pbxWindots.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your game should be launched. Enjoy!";
            // 
            // dolBrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxWindots);
            this.Controls.Add(this.pbxWiiFlash);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "dolBrew";
            this.Text = "dolBrew";
            this.Load += new System.EventHandler(this.dolBrew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWiiFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWindots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxWiiFlash;
        public System.Windows.Forms.PictureBox pbxWindots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrShutdown;


    }
}