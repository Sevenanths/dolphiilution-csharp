namespace Dolphiilution2_
{
    partial class frmDolphiiMain
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDolphiiMain));
            this.lvwPlatform = new System.Windows.Forms.ListView();
            this.modeImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlIsoInfo = new System.Windows.Forms.Panel();
            this.btnOpenPatch = new System.Windows.Forms.Button();
            this.pbxCoverArt = new System.Windows.Forms.PictureBox();
            this.btnDecompiled = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.cbxChoices = new System.Windows.Forms.ComboBox();
            this.lvwOptions = new System.Windows.Forms.ListView();
            this.cbxXML = new System.Windows.Forms.ComboBox();
            this.cbxGames = new System.Windows.Forms.ComboBox();
            this.pbxRegion = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlIsoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwPlatform
            // 
            this.lvwPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPlatform.HideSelection = false;
            this.lvwPlatform.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvwPlatform.Location = new System.Drawing.Point(14, 2);
            this.lvwPlatform.MultiSelect = false;
            this.lvwPlatform.Name = "lvwPlatform";
            this.lvwPlatform.Scrollable = false;
            this.lvwPlatform.Size = new System.Drawing.Size(32, 83);
            this.lvwPlatform.SmallImageList = this.modeImageList;
            this.lvwPlatform.TabIndex = 0;
            this.lvwPlatform.UseCompatibleStateImageBehavior = false;
            this.lvwPlatform.View = System.Windows.Forms.View.List;
            this.lvwPlatform.SelectedIndexChanged += new System.EventHandler(this.lvwPlatform_SelectedIndexChanged);
            // 
            // modeImageList
            // 
            this.modeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("modeImageList.ImageStream")));
            this.modeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.modeImageList.Images.SetKeyName(0, "Visualpharm-Icons8-Metro-Style-Video-Game-Consoles-Wii.ico");
            this.modeImageList.Images.SetKeyName(1, "gamecube.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlIsoInfo);
            this.panel1.Location = new System.Drawing.Point(66, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 324);
            this.panel1.TabIndex = 5;
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
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnPatch);
            this.pnlInfo.Controls.Add(this.txtPatch);
            this.pnlInfo.Controls.Add(this.cbxChoices);
            this.pnlInfo.Controls.Add(this.lvwOptions);
            this.pnlInfo.Controls.Add(this.cbxXML);
            this.pnlInfo.Location = new System.Drawing.Point(313, 51);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(248, 324);
            this.pnlInfo.TabIndex = 4;
            // 
            // btnPatch
            // 
            this.btnPatch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btnPatch.Location = new System.Drawing.Point(6, 269);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(235, 50);
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
            this.txtPatch.Size = new System.Drawing.Size(81, 29);
            this.txtPatch.TabIndex = 5;
            // 
            // cbxChoices
            // 
            this.cbxChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoices.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cbxChoices.FormattingEnabled = true;
            this.cbxChoices.Location = new System.Drawing.Point(7, 236);
            this.cbxChoices.Name = "cbxChoices";
            this.cbxChoices.Size = new System.Drawing.Size(149, 29);
            this.cbxChoices.TabIndex = 4;
            this.cbxChoices.SelectedIndexChanged += new System.EventHandler(this.cbxChoices_SelectedIndexChanged);
            // 
            // lvwOptions
            // 
            this.lvwOptions.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lvwOptions.HideSelection = false;
            this.lvwOptions.Location = new System.Drawing.Point(7, 38);
            this.lvwOptions.MultiSelect = false;
            this.lvwOptions.Name = "lvwOptions";
            this.lvwOptions.Size = new System.Drawing.Size(233, 194);
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
            this.cbxXML.Location = new System.Drawing.Point(7, 3);
            this.cbxXML.Name = "cbxXML";
            this.cbxXML.Size = new System.Drawing.Size(233, 29);
            this.cbxXML.TabIndex = 1;
            this.cbxXML.SelectedIndexChanged += new System.EventHandler(this.cbxXML_SelectedIndexChanged);
            // 
            // cbxGames
            // 
            this.cbxGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGames.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGames.FormattingEnabled = true;
            this.cbxGames.Location = new System.Drawing.Point(66, 8);
            this.cbxGames.Name = "cbxGames";
            this.cbxGames.Size = new System.Drawing.Size(495, 38);
            this.cbxGames.TabIndex = 3;
            this.cbxGames.SelectedIndexChanged += new System.EventHandler(this.cbxGames_SelectedIndexChanged);
            // 
            // pbxRegion
            // 
            this.pbxRegion.Location = new System.Drawing.Point(565, -1);
            this.pbxRegion.Name = "pbxRegion";
            this.pbxRegion.Size = new System.Drawing.Size(58, 56);
            this.pbxRegion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegion.TabIndex = 7;
            this.pbxRegion.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Enabled = false;
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(577, 333);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(46, 42);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(12, 333);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 42);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmDolphiiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 383);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.pbxRegion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.cbxGames);
            this.Controls.Add(this.lvwPlatform);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDolphiiMain";
            this.Text = "Dolphiilution 2+ :: by Anthe :: alpha versoin";
            this.Load += new System.EventHandler(this.frmDolphiiMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnlIsoInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwPlatform;
        private System.Windows.Forms.ImageList modeImageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIsoInfo;
        private System.Windows.Forms.Button btnOpenPatch;
        private System.Windows.Forms.PictureBox pbxCoverArt;
        private System.Windows.Forms.Button btnDecompiled;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.ComboBox cbxChoices;
        private System.Windows.Forms.ListView lvwOptions;
        private System.Windows.Forms.ComboBox cbxXML;
        private System.Windows.Forms.ComboBox cbxGames;
        private System.Windows.Forms.PictureBox pbxRegion;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnSettings;
    }
}

