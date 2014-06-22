namespace Dolphiilution
{
    partial class dolphinMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dolphinMain));
            this.lbxGames = new System.Windows.Forms.ListBox();
            this.lblIsoName = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblVirgin = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecompile = new System.Windows.Forms.Button();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.cbxRiivolutionXML = new System.Windows.Forms.ComboBox();
            this.lvwRiivolution = new System.Windows.Forms.ListView();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.cbxChoices = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadWiiGamesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRiivolutionFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchInDolphinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDolphinPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwExtractISO = new System.ComponentModel.BackgroundWorker();
            this.pnlInfo.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxGames
            // 
            this.lbxGames.FormattingEnabled = true;
            this.lbxGames.Location = new System.Drawing.Point(12, 31);
            this.lbxGames.Name = "lbxGames";
            this.lbxGames.Size = new System.Drawing.Size(125, 277);
            this.lbxGames.TabIndex = 2;
            this.lbxGames.SelectedIndexChanged += new System.EventHandler(this.lbxGames_SelectedIndexChanged);
            // 
            // lblIsoName
            // 
            this.lblIsoName.AutoSize = true;
            this.lblIsoName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblIsoName.Location = new System.Drawing.Point(3, 2);
            this.lblIsoName.Name = "lblIsoName";
            this.lblIsoName.Size = new System.Drawing.Size(90, 23);
            this.lblIsoName.TabIndex = 0;
            this.lblIsoName.Text = "ISO NAME";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblVirgin);
            this.pnlInfo.Controls.Add(this.btnClear);
            this.pnlInfo.Controls.Add(this.btnDecompile);
            this.pnlInfo.Controls.Add(this.lblIsoName);
            this.pnlInfo.Location = new System.Drawing.Point(409, 31);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(125, 277);
            this.pnlInfo.TabIndex = 4;
            // 
            // lblVirgin
            // 
            this.lblVirgin.AutoSize = true;
            this.lblVirgin.Location = new System.Drawing.Point(13, 21);
            this.lblVirgin.Name = "lblVirgin";
            this.lblVirgin.Size = new System.Drawing.Size(36, 13);
            this.lblVirgin.TabIndex = 3;
            this.lblVirgin.Text = "virgin";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Riivolution ISO";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecompile
            // 
            this.btnDecompile.Location = new System.Drawing.Point(3, 249);
            this.btnDecompile.Name = "btnDecompile";
            this.btnDecompile.Size = new System.Drawing.Size(117, 23);
            this.btnDecompile.TabIndex = 1;
            this.btnDecompile.Text = "Decompile";
            this.btnDecompile.UseVisualStyleBackColor = true;
            this.btnDecompile.Click += new System.EventHandler(this.btnDecompile_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.cbxRiivolutionXML);
            this.pnlItems.Controls.Add(this.lvwRiivolution);
            this.pnlItems.Controls.Add(this.btnPatch);
            this.pnlItems.Controls.Add(this.txtPatch);
            this.pnlItems.Controls.Add(this.cbxChoices);
            this.pnlItems.Enabled = false;
            this.pnlItems.Location = new System.Drawing.Point(143, 31);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(260, 277);
            this.pnlItems.TabIndex = 5;
            // 
            // cbxRiivolutionXML
            // 
            this.cbxRiivolutionXML.FormattingEnabled = true;
            this.cbxRiivolutionXML.Location = new System.Drawing.Point(3, 3);
            this.cbxRiivolutionXML.Name = "cbxRiivolutionXML";
            this.cbxRiivolutionXML.Size = new System.Drawing.Size(252, 21);
            this.cbxRiivolutionXML.TabIndex = 6;
            this.cbxRiivolutionXML.SelectedIndexChanged += new System.EventHandler(this.cbxRiivolutionXML_SelectedIndexChanged);
            // 
            // lvwRiivolution
            // 
            this.lvwRiivolution.HideSelection = false;
            this.lvwRiivolution.Location = new System.Drawing.Point(3, 30);
            this.lvwRiivolution.MultiSelect = false;
            this.lvwRiivolution.Name = "lvwRiivolution";
            this.lvwRiivolution.Size = new System.Drawing.Size(252, 163);
            this.lvwRiivolution.TabIndex = 7;
            this.lvwRiivolution.UseCompatibleStateImageBehavior = false;
            this.lvwRiivolution.View = System.Windows.Forms.View.List;
            this.lvwRiivolution.SelectedIndexChanged += new System.EventHandler(this.lvwRiivolution_SelectedIndexChanged);
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(3, 226);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(252, 46);
            this.btnPatch.TabIndex = 5;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtPatch
            // 
            this.txtPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtPatch.Location = new System.Drawing.Point(157, 199);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.Size = new System.Drawing.Size(98, 21);
            this.txtPatch.TabIndex = 9;
            // 
            // cbxChoices
            // 
            this.cbxChoices.FormattingEnabled = true;
            this.cbxChoices.Location = new System.Drawing.Point(3, 199);
            this.cbxChoices.Name = "cbxChoices";
            this.cbxChoices.Size = new System.Drawing.Size(152, 21);
            this.cbxChoices.TabIndex = 8;
            this.cbxChoices.SelectedIndexChanged += new System.EventHandler(this.cbxChoices_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWiiGamesFolderToolStripMenuItem,
            this.loadRiivolutionFolderToolStripMenuItem,
            this.launchInDolphinToolStripMenuItem,
            this.selectDolphinPathToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadWiiGamesFolderToolStripMenuItem
            // 
            this.loadWiiGamesFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadWiiGamesFolderToolStripMenuItem.Image")));
            this.loadWiiGamesFolderToolStripMenuItem.Name = "loadWiiGamesFolderToolStripMenuItem";
            this.loadWiiGamesFolderToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.loadWiiGamesFolderToolStripMenuItem.Text = "Load Wii Games folder";
            this.loadWiiGamesFolderToolStripMenuItem.Click += new System.EventHandler(this.loadWiiGamesFolderToolStripMenuItem_Click);
            // 
            // loadRiivolutionFolderToolStripMenuItem
            // 
            this.loadRiivolutionFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadRiivolutionFolderToolStripMenuItem.Image")));
            this.loadRiivolutionFolderToolStripMenuItem.Name = "loadRiivolutionFolderToolStripMenuItem";
            this.loadRiivolutionFolderToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.loadRiivolutionFolderToolStripMenuItem.Text = "Load Riivolution Folder";
            this.loadRiivolutionFolderToolStripMenuItem.Click += new System.EventHandler(this.loadRiivolutionFolderToolStripMenuItem_Click);
            // 
            // launchInDolphinToolStripMenuItem
            // 
            this.launchInDolphinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.launchInDolphinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("launchInDolphinToolStripMenuItem.Image")));
            this.launchInDolphinToolStripMenuItem.Name = "launchInDolphinToolStripMenuItem";
            this.launchInDolphinToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.launchInDolphinToolStripMenuItem.Text = "Play";
            this.launchInDolphinToolStripMenuItem.Click += new System.EventHandler(this.launchInDolphinToolStripMenuItem_Click);
            // 
            // selectDolphinPathToolStripMenuItem
            // 
            this.selectDolphinPathToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectDolphinPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectDolphinPathToolStripMenuItem.Image")));
            this.selectDolphinPathToolStripMenuItem.Name = "selectDolphinPathToolStripMenuItem";
            this.selectDolphinPathToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.selectDolphinPathToolStripMenuItem.Text = "Select Dolphin Path";
            this.selectDolphinPathToolStripMenuItem.Click += new System.EventHandler(this.selectDolphinPathToolStripMenuItem_Click);
            // 
            // bgwExtractISO
            // 
            this.bgwExtractISO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExtractISO_DoWork);
            // 
            // dolphinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(546, 318);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lbxGames);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dolphinMain";
            this.Text = "Dolphiilution :: C# version by Anthe";
            this.Load += new System.EventHandler(this.dolphinMain_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxGames;
        private System.Windows.Forms.Label lblIsoName;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnDecompile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.ComboBox cbxRiivolutionXML;
        private System.Windows.Forms.ListView lvwRiivolution;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.ComboBox cbxChoices;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadWiiGamesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRiivolutionFolderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwExtractISO;
        private System.Windows.Forms.Label lblVirgin;
        private System.Windows.Forms.ToolStripMenuItem selectDolphinPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchInDolphinToolStripMenuItem;
    }
}