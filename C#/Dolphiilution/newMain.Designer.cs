namespace Dolphiilution
{
    partial class newMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadISOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRiivolutionFileStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxRiivolutionXML = new System.Windows.Forms.ComboBox();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.plnStuffs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.cbxChoices = new System.Windows.Forms.ComboBox();
            this.lvwRiivolution = new System.Windows.Forms.ListView();
            this.bgwExtractISO = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.plnStuffs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadISOToolStripMenuItem,
            this.loadRiivolutionFileStructureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadISOToolStripMenuItem
            // 
            this.loadISOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadISOToolStripMenuItem.Image")));
            this.loadISOToolStripMenuItem.Name = "loadISOToolStripMenuItem";
            this.loadISOToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadISOToolStripMenuItem.Text = "Load ISO";
            this.loadISOToolStripMenuItem.Click += new System.EventHandler(this.loadISOToolStripMenuItem_Click);
            // 
            // loadRiivolutionFileStructureToolStripMenuItem
            // 
            this.loadRiivolutionFileStructureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadRiivolutionFileStructureToolStripMenuItem.Image")));
            this.loadRiivolutionFileStructureToolStripMenuItem.Name = "loadRiivolutionFileStructureToolStripMenuItem";
            this.loadRiivolutionFileStructureToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.loadRiivolutionFileStructureToolStripMenuItem.Text = "Load Riivolution file structure";
            this.loadRiivolutionFileStructureToolStripMenuItem.Click += new System.EventHandler(this.loadRiivolutionFileStructureToolStripMenuItem_Click);
            // 
            // cbxRiivolutionXML
            // 
            this.cbxRiivolutionXML.FormattingEnabled = true;
            this.cbxRiivolutionXML.Location = new System.Drawing.Point(3, 3);
            this.cbxRiivolutionXML.Name = "cbxRiivolutionXML";
            this.cbxRiivolutionXML.Size = new System.Drawing.Size(252, 21);
            this.cbxRiivolutionXML.TabIndex = 1;
            this.cbxRiivolutionXML.SelectedIndexChanged += new System.EventHandler(this.cbxRiivolutionXML_SelectedIndexChanged);
            // 
            // pnlItems
            // 
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.cbxRiivolutionXML);
            this.pnlItems.Location = new System.Drawing.Point(10, 35);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(260, 391);
            this.pnlItems.TabIndex = 2;
            // 
            // plnStuffs
            // 
            this.plnStuffs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plnStuffs.Controls.Add(this.panel1);
            this.plnStuffs.Controls.Add(this.txtPatch);
            this.plnStuffs.Controls.Add(this.cbxChoices);
            this.plnStuffs.Controls.Add(this.lvwRiivolution);
            this.plnStuffs.Location = new System.Drawing.Point(10, 63);
            this.plnStuffs.Name = "plnStuffs";
            this.plnStuffs.Size = new System.Drawing.Size(260, 363);
            this.plnStuffs.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPatch);
            this.panel1.Location = new System.Drawing.Point(-1, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 54);
            this.panel1.TabIndex = 5;
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(3, 3);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(252, 46);
            this.btnPatch.TabIndex = 0;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtPatch
            // 
            this.txtPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtPatch.Location = new System.Drawing.Point(157, 282);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.Size = new System.Drawing.Size(98, 21);
            this.txtPatch.TabIndex = 4;
            // 
            // cbxChoices
            // 
            this.cbxChoices.FormattingEnabled = true;
            this.cbxChoices.Location = new System.Drawing.Point(3, 282);
            this.cbxChoices.Name = "cbxChoices";
            this.cbxChoices.Size = new System.Drawing.Size(152, 21);
            this.cbxChoices.TabIndex = 3;
            this.cbxChoices.SelectedIndexChanged += new System.EventHandler(this.cbxChoices_SelectedIndexChanged);
            this.cbxChoices.DataSourceChanged += new System.EventHandler(this.cbxChoices_DataSourceChanged);
            // 
            // lvwRiivolution
            // 
            this.lvwRiivolution.HideSelection = false;
            this.lvwRiivolution.Location = new System.Drawing.Point(3, 3);
            this.lvwRiivolution.MultiSelect = false;
            this.lvwRiivolution.Name = "lvwRiivolution";
            this.lvwRiivolution.Size = new System.Drawing.Size(252, 275);
            this.lvwRiivolution.TabIndex = 2;
            this.lvwRiivolution.UseCompatibleStateImageBehavior = false;
            this.lvwRiivolution.View = System.Windows.Forms.View.List;
            this.lvwRiivolution.SelectedIndexChanged += new System.EventHandler(this.lvwRiivolution_SelectedIndexChanged);
            // 
            // bgwExtractISO
            // 
            this.bgwExtractISO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExtractISO_DoWork);
            // 
            // newMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 438);
            this.Controls.Add(this.plnStuffs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlItems);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "newMain";
            this.Text = "newMain";
            this.Load += new System.EventHandler(this.newMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlItems.ResumeLayout(false);
            this.plnStuffs.ResumeLayout(false);
            this.plnStuffs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadISOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRiivolutionFileStructureToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxRiivolutionXML;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel plnStuffs;
        private System.Windows.Forms.ListView lvwRiivolution;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.ComboBox cbxChoices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPatch;
        private System.ComponentModel.BackgroundWorker bgwExtractISO;
    }
}