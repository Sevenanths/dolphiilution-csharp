namespace Dolphiilution
{
    partial class frmMainForm
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
            this.txtISO = new System.Windows.Forms.TextBox();
            this.btnISO = new System.Windows.Forms.Button();
            this.gpbISO = new System.Windows.Forms.GroupBox();
            this.lblContents = new System.Windows.Forms.Label();
            this.lvwISO = new System.Windows.Forms.ListView();
            this.clmFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbRiivolution = new System.Windows.Forms.GroupBox();
            this.lblRiivo = new System.Windows.Forms.Label();
            this.dgvRiivolution = new System.Windows.Forms.DataGridView();
            this.clmSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChoice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxRiivolutionXML = new System.Windows.Forms.ComboBox();
            this.btnRiivolution = new System.Windows.Forms.Button();
            this.txtRiivolution = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbISO.SuspendLayout();
            this.gpbRiivolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiivolution)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISO
            // 
            this.txtISO.Location = new System.Drawing.Point(12, 12);
            this.txtISO.Name = "txtISO";
            this.txtISO.ReadOnly = true;
            this.txtISO.Size = new System.Drawing.Size(195, 20);
            this.txtISO.TabIndex = 0;
            // 
            // btnISO
            // 
            this.btnISO.Location = new System.Drawing.Point(212, 11);
            this.btnISO.Name = "btnISO";
            this.btnISO.Size = new System.Drawing.Size(75, 22);
            this.btnISO.TabIndex = 1;
            this.btnISO.Text = "Load ISO";
            this.btnISO.UseVisualStyleBackColor = true;
            this.btnISO.Click += new System.EventHandler(this.btnISO_Click);
            // 
            // gpbISO
            // 
            this.gpbISO.Controls.Add(this.lblContents);
            this.gpbISO.Controls.Add(this.lvwISO);
            this.gpbISO.Location = new System.Drawing.Point(12, 47);
            this.gpbISO.Name = "gpbISO";
            this.gpbISO.Size = new System.Drawing.Size(275, 389);
            this.gpbISO.TabIndex = 2;
            this.gpbISO.TabStop = false;
            this.gpbISO.Text = "ISO";
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(6, 16);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(122, 13);
            this.lblContents.TabIndex = 4;
            this.lblContents.Text = "Contents (this is useless)";
            // 
            // lvwISO
            // 
            this.lvwISO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFilename,
            this.clmFilePath});
            this.lvwISO.Location = new System.Drawing.Point(6, 32);
            this.lvwISO.Name = "lvwISO";
            this.lvwISO.Size = new System.Drawing.Size(263, 351);
            this.lvwISO.TabIndex = 3;
            this.lvwISO.UseCompatibleStateImageBehavior = false;
            this.lvwISO.View = System.Windows.Forms.View.Details;
            // 
            // clmFilename
            // 
            this.clmFilename.Text = "Filename";
            this.clmFilename.Width = 100;
            // 
            // clmFilePath
            // 
            this.clmFilePath.Text = "Path";
            this.clmFilePath.Width = 500;
            // 
            // gpbRiivolution
            // 
            this.gpbRiivolution.Controls.Add(this.lblRiivo);
            this.gpbRiivolution.Controls.Add(this.dgvRiivolution);
            this.gpbRiivolution.Controls.Add(this.cbxRiivolutionXML);
            this.gpbRiivolution.Location = new System.Drawing.Point(293, 47);
            this.gpbRiivolution.Name = "gpbRiivolution";
            this.gpbRiivolution.Size = new System.Drawing.Size(792, 389);
            this.gpbRiivolution.TabIndex = 3;
            this.gpbRiivolution.TabStop = false;
            this.gpbRiivolution.Text = "Riivolution";
            // 
            // lblRiivo
            // 
            this.lblRiivo.AutoSize = true;
            this.lblRiivo.Location = new System.Drawing.Point(6, 16);
            this.lblRiivo.Name = "lblRiivo";
            this.lblRiivo.Size = new System.Drawing.Size(62, 13);
            this.lblRiivo.TabIndex = 8;
            this.lblRiivo.Text = "Select XML";
            // 
            // dgvRiivolution
            // 
            this.dgvRiivolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiivolution.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiivolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRiivolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiivolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSection,
            this.clmOption,
            this.clmChoice,
            this.clmPatch});
            this.dgvRiivolution.Location = new System.Drawing.Point(7, 59);
            this.dgvRiivolution.Name = "dgvRiivolution";
            this.dgvRiivolution.Size = new System.Drawing.Size(779, 324);
            this.dgvRiivolution.TabIndex = 7;
            this.dgvRiivolution.DataSourceChanged += new System.EventHandler(this.dgvRiivolution_DataSourceChanged);
            this.dgvRiivolution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiivolution_CellClick);
            this.dgvRiivolution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiivolution_CellContentClick);
            this.dgvRiivolution.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRiivolution_DataError);
            // 
            // clmSection
            // 
            this.clmSection.HeaderText = "SECTION";
            this.clmSection.Name = "clmSection";
            this.clmSection.ReadOnly = true;
            // 
            // clmOption
            // 
            this.clmOption.HeaderText = "OPTION";
            this.clmOption.Name = "clmOption";
            this.clmOption.ReadOnly = true;
            // 
            // clmChoice
            // 
            this.clmChoice.HeaderText = "CHOICE";
            this.clmChoice.Name = "clmChoice";
            // 
            // clmPatch
            // 
            this.clmPatch.HeaderText = "PATCH";
            this.clmPatch.Name = "clmPatch";
            this.clmPatch.ReadOnly = true;
            this.clmPatch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbxRiivolutionXML
            // 
            this.cbxRiivolutionXML.FormattingEnabled = true;
            this.cbxRiivolutionXML.Location = new System.Drawing.Point(7, 32);
            this.cbxRiivolutionXML.Name = "cbxRiivolutionXML";
            this.cbxRiivolutionXML.Size = new System.Drawing.Size(194, 21);
            this.cbxRiivolutionXML.TabIndex = 6;
            this.cbxRiivolutionXML.SelectedIndexChanged += new System.EventHandler(this.cbxRiivolutionXML_SelectedIndexChanged);
            // 
            // btnRiivolution
            // 
            this.btnRiivolution.Location = new System.Drawing.Point(499, 11);
            this.btnRiivolution.Name = "btnRiivolution";
            this.btnRiivolution.Size = new System.Drawing.Size(159, 22);
            this.btnRiivolution.TabIndex = 5;
            this.btnRiivolution.Text = "Load Riivolution file structure";
            this.btnRiivolution.UseVisualStyleBackColor = true;
            this.btnRiivolution.Click += new System.EventHandler(this.btnRiivolution_Click);
            // 
            // txtRiivolution
            // 
            this.txtRiivolution.Location = new System.Drawing.Point(299, 12);
            this.txtRiivolution.Name = "txtRiivolution";
            this.txtRiivolution.ReadOnly = true;
            this.txtRiivolution.Size = new System.Drawing.Size(195, 20);
            this.txtRiivolution.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRiivolution);
            this.Controls.Add(this.txtRiivolution);
            this.Controls.Add(this.gpbRiivolution);
            this.Controls.Add(this.gpbISO);
            this.Controls.Add(this.btnISO);
            this.Controls.Add(this.txtISO);
            this.Name = "frmMainForm";
            this.Text = "Dolphiilution";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.gpbISO.ResumeLayout(false);
            this.gpbISO.PerformLayout();
            this.gpbRiivolution.ResumeLayout(false);
            this.gpbRiivolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiivolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISO;
        private System.Windows.Forms.Button btnISO;
        private System.Windows.Forms.GroupBox gpbISO;
        private System.Windows.Forms.ListView lvwISO;
        private System.Windows.Forms.ColumnHeader clmFilename;
        private System.Windows.Forms.ColumnHeader clmFilePath;
        private System.Windows.Forms.GroupBox gpbRiivolution;
        private System.Windows.Forms.Button btnRiivolution;
        private System.Windows.Forms.TextBox txtRiivolution;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.ComboBox cbxRiivolutionXML;
        private System.Windows.Forms.Label lblRiivo;
        private System.Windows.Forms.DataGridView dgvRiivolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOption;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatch;
        private System.Windows.Forms.Button button1;
    }
}

