namespace Dolphiilution_
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
            this.cbxGames = new System.Windows.Forms.ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.cbxChoices = new System.Windows.Forms.ComboBox();
            this.lvwOptions = new System.Windows.Forms.ListView();
            this.cbxXML = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxCoverArt = new System.Windows.Forms.PictureBox();
            this.lblGameID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGames
            // 
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
            this.pnlInfo.Controls.Add(this.button1);
            this.pnlInfo.Controls.Add(this.txtPatch);
            this.pnlInfo.Controls.Add(this.cbxChoices);
            this.pnlInfo.Controls.Add(this.lvwOptions);
            this.pnlInfo.Controls.Add(this.cbxXML);
            this.pnlInfo.Location = new System.Drawing.Point(115, 56);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(248, 324);
            this.pnlInfo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.button1.Location = new System.Drawing.Point(2, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Patch";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.pbxCoverArt);
            this.panel1.Location = new System.Drawing.Point(362, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 324);
            this.panel1.TabIndex = 2;
            // 
            // pbxCoverArt
            // 
            this.pbxCoverArt.Location = new System.Drawing.Point(3, 3);
            this.pbxCoverArt.Name = "pbxCoverArt";
            this.pbxCoverArt.Size = new System.Drawing.Size(241, 316);
            this.pbxCoverArt.TabIndex = 2;
            this.pbxCoverArt.TabStop = false;
            // 
            // lblGameID
            // 
            this.lblGameID.AutoSize = true;
            this.lblGameID.Location = new System.Drawing.Point(12, 12);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(0, 13);
            this.lblGameID.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dolphiiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblGameID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.cbxGames);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "dolphiiMain";
            this.Text = "Dolplhiilution :: C# version 2.0";
            this.Load += new System.EventHandler(this.dolphiiMain_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGames;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.ComboBox cbxChoices;
        private System.Windows.Forms.ListView lvwOptions;
        private System.Windows.Forms.ComboBox cbxXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxCoverArt;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Button button2;

    }
}

