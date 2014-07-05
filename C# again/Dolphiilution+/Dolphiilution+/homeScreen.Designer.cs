namespace Dolphiilution_
{
    partial class homeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLastPlayed = new System.Windows.Forms.Button();
            this.btnPatchWiiGames = new System.Windows.Forms.Button();
            this.btnPatchGCGames = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pbxDolphiilogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDolphiilogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxDolphiilogo);
            this.panel1.Location = new System.Drawing.Point(343, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 282);
            this.panel1.TabIndex = 0;
            // 
            // btnLastPlayed
            // 
            this.btnLastPlayed.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnLastPlayed.Location = new System.Drawing.Point(12, 12);
            this.btnLastPlayed.Name = "btnLastPlayed";
            this.btnLastPlayed.Size = new System.Drawing.Size(325, 66);
            this.btnLastPlayed.TabIndex = 1;
            this.btnLastPlayed.Text = "Launch last played game";
            this.btnLastPlayed.UseVisualStyleBackColor = true;
            this.btnLastPlayed.Click += new System.EventHandler(this.btnLastPlayed_Click);
            // 
            // btnPatchWiiGames
            // 
            this.btnPatchWiiGames.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnPatchWiiGames.Location = new System.Drawing.Point(12, 84);
            this.btnPatchWiiGames.Name = "btnPatchWiiGames";
            this.btnPatchWiiGames.Size = new System.Drawing.Size(325, 66);
            this.btnPatchWiiGames.TabIndex = 2;
            this.btnPatchWiiGames.Text = "Patch: Wii Games";
            this.btnPatchWiiGames.UseVisualStyleBackColor = true;
            this.btnPatchWiiGames.Click += new System.EventHandler(this.btnPatchWiiGames_Click);
            // 
            // btnPatchGCGames
            // 
            this.btnPatchGCGames.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnPatchGCGames.Location = new System.Drawing.Point(12, 156);
            this.btnPatchGCGames.Name = "btnPatchGCGames";
            this.btnPatchGCGames.Size = new System.Drawing.Size(325, 66);
            this.btnPatchGCGames.TabIndex = 3;
            this.btnPatchGCGames.Text = "Patch: Gamecube Games";
            this.btnPatchGCGames.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(12, 228);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(325, 66);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // pbxDolphiilogo
            // 
            this.pbxDolphiilogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDolphiilogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxDolphiilogo.Image")));
            this.pbxDolphiilogo.Location = new System.Drawing.Point(0, 0);
            this.pbxDolphiilogo.Name = "pbxDolphiilogo";
            this.pbxDolphiilogo.Size = new System.Drawing.Size(184, 280);
            this.pbxDolphiilogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDolphiilogo.TabIndex = 0;
            this.pbxDolphiilogo.TabStop = false;
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 305);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPatchGCGames);
            this.Controls.Add(this.btnPatchWiiGames);
            this.Controls.Add(this.btnLastPlayed);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "homeScreen";
            this.Text = "homeScreen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDolphiilogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxDolphiilogo;
        private System.Windows.Forms.Button btnLastPlayed;
        private System.Windows.Forms.Button btnPatchWiiGames;
        private System.Windows.Forms.Button btnPatchGCGames;
        private System.Windows.Forms.Button btnQuit;
    }
}