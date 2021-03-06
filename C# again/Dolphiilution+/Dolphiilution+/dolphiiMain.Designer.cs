﻿namespace Dolphiilution_
{
    partial class dolphiiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dolphiiMain));
            this.cbxGames = new System.Windows.Forms.ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.cbxChoices = new System.Windows.Forms.ComboBox();
            this.lvwOptions = new System.Windows.Forms.ListView();
            this.cbxXML = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlIsoInfo = new System.Windows.Forms.Panel();
            this.btnOpenPatch = new System.Windows.Forms.Button();
            this.pbxCoverArt = new System.Windows.Forms.PictureBox();
            this.btnDecompiled = new System.Windows.Forms.Button();
            this.lblGameID = new System.Windows.Forms.Label();
            this.pbxRegion = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIsoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGames
            // 
            this.cbxGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGames.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGames.FormattingEnabled = true;
            this.cbxGames.Location = new System.Drawing.Point(115, 12);
            this.cbxGames.Name = "cbxGames";
            this.cbxGames.Size = new System.Drawing.Size(495, 38);
            this.cbxGames.TabIndex = 0;
            this.cbxGames.SelectedIndexChanged += new System.EventHandler(this.cbxGames_SelectedIndexChanged);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnPatch);
            this.pnlInfo.Controls.Add(this.txtPatch);
            this.pnlInfo.Controls.Add(this.cbxChoices);
            this.pnlInfo.Controls.Add(this.lvwOptions);
            this.pnlInfo.Controls.Add(this.cbxXML);
            this.pnlInfo.Location = new System.Drawing.Point(362, 55);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(248, 324);
            this.pnlInfo.TabIndex = 1;
            // 
            // btnPatch
            // 
            this.btnPatch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnPatch.Location = new System.Drawing.Point(2, 269);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(242, 50);
            this.btnPatch.TabIndex = 6;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtPatch
            // 
            this.txtPatch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtPatch.Location = new System.Drawing.Point(159, 236);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.Size = new System.Drawing.Size(85, 29);
            this.txtPatch.TabIndex = 5;
            // 
            // cbxChoices
            // 
            this.cbxChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoices.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cbxChoices.FormattingEnabled = true;
            this.cbxChoices.Location = new System.Drawing.Point(3, 236);
            this.cbxChoices.Name = "cbxChoices";
            this.cbxChoices.Size = new System.Drawing.Size(153, 29);
            this.cbxChoices.TabIndex = 4;
            this.cbxChoices.SelectedIndexChanged += new System.EventHandler(this.cbxChoices_SelectedIndexChanged);
            this.cbxChoices.TextChanged += new System.EventHandler(this.cbxChoices_TextChanged);
            // 
            // lvwOptions
            // 
            this.lvwOptions.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lvwOptions.HideSelection = false;
            this.lvwOptions.Location = new System.Drawing.Point(3, 38);
            this.lvwOptions.MultiSelect = false;
            this.lvwOptions.Name = "lvwOptions";
            this.lvwOptions.Size = new System.Drawing.Size(241, 194);
            this.lvwOptions.TabIndex = 3;
            this.lvwOptions.UseCompatibleStateImageBehavior = false;
            this.lvwOptions.View = System.Windows.Forms.View.List;
            this.lvwOptions.SelectedIndexChanged += new System.EventHandler(this.lvwOptions_SelectedIndexChanged);
            // 
            // cbxXML
            // 
            this.cbxXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxXML.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cbxXML.FormattingEnabled = true;
            this.cbxXML.Location = new System.Drawing.Point(3, 3);
            this.cbxXML.Name = "cbxXML";
            this.cbxXML.Size = new System.Drawing.Size(241, 29);
            this.cbxXML.TabIndex = 1;
            this.cbxXML.SelectedIndexChanged += new System.EventHandler(this.cbxXML_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlIsoInfo);
            this.panel1.Location = new System.Drawing.Point(115, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 324);
            this.panel1.TabIndex = 2;
            // 
            // pnlIsoInfo
            // 
            this.pnlIsoInfo.Controls.Add(this.btnOpenPatch);
            this.pnlIsoInfo.Controls.Add(this.pbxCoverArt);
            this.pnlIsoInfo.Controls.Add(this.btnDecompiled);
            this.pnlIsoInfo.Location = new System.Drawing.Point(-1, -1);
            this.pnlIsoInfo.Name = "pnlIsoInfo";
            this.pnlIsoInfo.Size = new System.Drawing.Size(249, 324);
            this.pnlIsoInfo.TabIndex = 3;
            // 
            // btnOpenPatch
            // 
            this.btnOpenPatch.Enabled = false;
            this.btnOpenPatch.Location = new System.Drawing.Point(126, 4);
            this.btnOpenPatch.Name = "btnOpenPatch";
            this.btnOpenPatch.Size = new System.Drawing.Size(119, 23);
            this.btnOpenPatch.TabIndex = 1;
            this.btnOpenPatch.Text = "Open patch folder";
            this.btnOpenPatch.UseVisualStyleBackColor = true;
            this.btnOpenPatch.Click += new System.EventHandler(this.btnOpenPatch_Click);
            // 
            // pbxCoverArt
            // 
            this.pbxCoverArt.Location = new System.Drawing.Point(4, 33);
            this.pbxCoverArt.Name = "pbxCoverArt";
            this.pbxCoverArt.Size = new System.Drawing.Size(241, 287);
            this.pbxCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCoverArt.TabIndex = 2;
            this.pbxCoverArt.TabStop = false;
            // 
            // btnDecompiled
            // 
            this.btnDecompiled.Enabled = false;
            this.btnDecompiled.Location = new System.Drawing.Point(4, 4);
            this.btnDecompiled.Name = "btnDecompiled";
            this.btnDecompiled.Size = new System.Drawing.Size(119, 23);
            this.btnDecompiled.TabIndex = 0;
            this.btnDecompiled.Text = "Decompile";
            this.btnDecompiled.UseVisualStyleBackColor = true;
            this.btnDecompiled.Click += new System.EventHandler(this.btnDecompiled_Click);
            // 
            // lblGameID
            // 
            this.lblGameID.AutoSize = true;
            this.lblGameID.Location = new System.Drawing.Point(12, 12);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(0, 13);
            this.lblGameID.TabIndex = 3;
            // 
            // pbxRegion
            // 
            this.pbxRegion.Location = new System.Drawing.Point(616, 6);
            this.pbxRegion.Name = "pbxRegion";
            this.pbxRegion.Size = new System.Drawing.Size(55, 49);
            this.pbxRegion.TabIndex = 6;
            this.pbxRegion.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Enabled = false;
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(664, 337);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(46, 42);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(12, 337);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 42);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // dolphiiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 391);
            this.Controls.Add(this.pbxRegion);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblGameID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.cbxGames);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "dolphiiMain";
            this.Text = "Dolphiilution+ for Wii :: by Anthe :: release preview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dolphiiMain_FormClosed);
            this.Load += new System.EventHandler(this.dolphiiMain_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlIsoInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGames;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.ComboBox cbxChoices;
        private System.Windows.Forms.ListView lvwOptions;
        private System.Windows.Forms.ComboBox cbxXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlIsoInfo;
        private System.Windows.Forms.PictureBox pbxCoverArt;
        private System.Windows.Forms.Button btnOpenPatch;
        private System.Windows.Forms.Button btnDecompiled;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.PictureBox pbxRegion;

    }
}

