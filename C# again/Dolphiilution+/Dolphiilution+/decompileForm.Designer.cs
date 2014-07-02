namespace Dolphiilution_
{
    partial class decompileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decompileForm));
            this.pbxMarioDance = new System.Windows.Forms.PictureBox();
            this.btnMusic = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarioDance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMarioDance
            // 
            this.pbxMarioDance.Image = ((System.Drawing.Image)(resources.GetObject("pbxMarioDance.Image")));
            this.pbxMarioDance.Location = new System.Drawing.Point(12, 12);
            this.pbxMarioDance.Name = "pbxMarioDance";
            this.pbxMarioDance.Size = new System.Drawing.Size(416, 179);
            this.pbxMarioDance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMarioDance.TabIndex = 0;
            this.pbxMarioDance.TabStop = false;
            // 
            // btnMusic
            // 
            this.btnMusic.AutoSize = true;
            this.btnMusic.Location = new System.Drawing.Point(337, 181);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(97, 13);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.TabStop = true;
            this.btnMusic.Text = "Need some music?";
            this.btnMusic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMusic_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dolphiilution_.Properties.Resources.DECOMP;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 22);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // decompileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 203);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.pbxMarioDance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "decompileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "decompileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarioDance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMarioDance;
        private System.Windows.Forms.LinkLabel btnMusic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}