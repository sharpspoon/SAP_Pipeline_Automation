namespace SAP_Pipeline_Automation
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.uploadButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.operationalLabel = new System.Windows.Forms.Label();
            this.importedfileDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.servicesImportedFileDataGridView = new System.Windows.Forms.DataGridView();
            this.servicesUploadButton = new System.Windows.Forms.Button();
            this.archivePreviousDistributionFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importedfileDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesImportedFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(12, 12);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(150, 45);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2576, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivePreviousDistributionFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 48);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2528, 899);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.operationalLabel);
            this.tabPage1.Controls.Add(this.importedfileDataGridView);
            this.tabPage1.Controls.Add(this.uploadButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(3072, 1398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cloud LOB Operational";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // operationalLabel
            // 
            this.operationalLabel.AutoSize = true;
            this.operationalLabel.Location = new System.Drawing.Point(1436, 23);
            this.operationalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.operationalLabel.Name = "operationalLabel";
            this.operationalLabel.Size = new System.Drawing.Size(310, 32);
            this.operationalLabel.TabIndex = 4;
            this.operationalLabel.Text = "Cloud LOB Operational";
            // 
            // importedfileDataGridView
            // 
            this.importedfileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importedfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importedfileDataGridView.Location = new System.Drawing.Point(12, 68);
            this.importedfileDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.importedfileDataGridView.Name = "importedfileDataGridView";
            this.importedfileDataGridView.RowHeadersWidth = 51;
            this.importedfileDataGridView.RowTemplate.Height = 24;
            this.importedfileDataGridView.Size = new System.Drawing.Size(3040, 1304);
            this.importedfileDataGridView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.servicesLabel);
            this.tabPage2.Controls.Add(this.servicesImportedFileDataGridView);
            this.tabPage2.Controls.Add(this.servicesUploadButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(2520, 852);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(1436, 23);
            this.servicesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(124, 32);
            this.servicesLabel.TabIndex = 3;
            this.servicesLabel.Text = "Services";
            // 
            // servicesImportedFileDataGridView
            // 
            this.servicesImportedFileDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesImportedFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesImportedFileDataGridView.Location = new System.Drawing.Point(12, 68);
            this.servicesImportedFileDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.servicesImportedFileDataGridView.Name = "servicesImportedFileDataGridView";
            this.servicesImportedFileDataGridView.RowHeadersWidth = 51;
            this.servicesImportedFileDataGridView.RowTemplate.Height = 24;
            this.servicesImportedFileDataGridView.Size = new System.Drawing.Size(2488, 758);
            this.servicesImportedFileDataGridView.TabIndex = 2;
            // 
            // servicesUploadButton
            // 
            this.servicesUploadButton.Location = new System.Drawing.Point(12, 12);
            this.servicesUploadButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.servicesUploadButton.Name = "servicesUploadButton";
            this.servicesUploadButton.Size = new System.Drawing.Size(150, 45);
            this.servicesUploadButton.TabIndex = 1;
            this.servicesUploadButton.Text = "upload";
            this.servicesUploadButton.UseVisualStyleBackColor = true;
            this.servicesUploadButton.Click += new System.EventHandler(this.servicesUploadButton_Click);
            // 
            // archivePreviousDistributionFilesToolStripMenuItem
            // 
            this.archivePreviousDistributionFilesToolStripMenuItem.Name = "archivePreviousDistributionFilesToolStripMenuItem";
            this.archivePreviousDistributionFilesToolStripMenuItem.Size = new System.Drawing.Size(630, 54);
            this.archivePreviousDistributionFilesToolStripMenuItem.Text = "Archive Previous Distribution Files";
            this.archivePreviousDistributionFilesToolStripMenuItem.Click += new System.EventHandler(this.archivePreviousDistributionFilesToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2576, 983);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainForm";
            this.Text = "SAP Pipeline Automation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importedfileDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesImportedFileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView importedfileDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView servicesImportedFileDataGridView;
        private System.Windows.Forms.Button servicesUploadButton;
        private System.Windows.Forms.Label operationalLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.ToolStripMenuItem archivePreviousDistributionFilesToolStripMenuItem;
    }
}

