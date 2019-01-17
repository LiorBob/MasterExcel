namespace MasterExcel
{
    partial class frmMasterExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterExcel));
            this.txtFolderWithExcelFiles = new System.Windows.Forms.TextBox();
            this.lstExcelFiles = new System.Windows.Forms.ListBox();
            this.lblEnterDirectoryToSearchForExcelFiles = new System.Windows.Forms.Label();
            this.lblDoubleClickOnExcelFileToOpen = new System.Windows.Forms.Label();
            this.btnOpenSelectedFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolderWithExcelFiles
            // 
            this.txtFolderWithExcelFiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFolderWithExcelFiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtFolderWithExcelFiles.Location = new System.Drawing.Point(12, 62);
            this.txtFolderWithExcelFiles.Name = "txtFolderWithExcelFiles";
            this.txtFolderWithExcelFiles.Size = new System.Drawing.Size(294, 20);
            this.txtFolderWithExcelFiles.TabIndex = 2;
            this.txtFolderWithExcelFiles.TextChanged += new System.EventHandler(this.txtFolderWithExcelFiles_TextChanged);
            // 
            // lstExcelFiles
            // 
            this.lstExcelFiles.FormattingEnabled = true;
            this.lstExcelFiles.Location = new System.Drawing.Point(472, 62);
            this.lstExcelFiles.Name = "lstExcelFiles";
            this.lstExcelFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstExcelFiles.Size = new System.Drawing.Size(264, 186);
            this.lstExcelFiles.TabIndex = 3;
            this.lstExcelFiles.DoubleClick += new System.EventHandler(this.lstExcelFiles_DoubleClick);
            // 
            // lblEnterDirectoryToSearchForExcelFiles
            // 
            this.lblEnterDirectoryToSearchForExcelFiles.AutoSize = true;
            this.lblEnterDirectoryToSearchForExcelFiles.Location = new System.Drawing.Point(9, 37);
            this.lblEnterDirectoryToSearchForExcelFiles.Name = "lblEnterDirectoryToSearchForExcelFiles";
            this.lblEnterDirectoryToSearchForExcelFiles.Size = new System.Drawing.Size(195, 13);
            this.lblEnterDirectoryToSearchForExcelFiles.TabIndex = 0;
            this.lblEnterDirectoryToSearchForExcelFiles.Text = "Enter Directory to search for Excel Files:";
            // 
            // lblDoubleClickOnExcelFileToOpen
            // 
            this.lblDoubleClickOnExcelFileToOpen.AutoSize = true;
            this.lblDoubleClickOnExcelFileToOpen.Location = new System.Drawing.Point(469, 37);
            this.lblDoubleClickOnExcelFileToOpen.Name = "lblDoubleClickOnExcelFileToOpen";
            this.lblDoubleClickOnExcelFileToOpen.Size = new System.Drawing.Size(211, 13);
            this.lblDoubleClickOnExcelFileToOpen.TabIndex = 1;
            this.lblDoubleClickOnExcelFileToOpen.Text = "Double Click or select multiple files to open:";
            // 
            // btnOpenSelectedFile
            // 
            this.btnOpenSelectedFile.BackColor = System.Drawing.Color.Green;
            this.btnOpenSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSelectedFile.Location = new System.Drawing.Point(12, 303);
            this.btnOpenSelectedFile.Name = "btnOpenSelectedFile";
            this.btnOpenSelectedFile.Size = new System.Drawing.Size(724, 76);
            this.btnOpenSelectedFile.TabIndex = 4;
            this.btnOpenSelectedFile.Text = "Open Selected File";
            this.btnOpenSelectedFile.UseVisualStyleBackColor = false;
            this.btnOpenSelectedFile.Click += new System.EventHandler(this.btnOpenSelectedFile_Click);
            // 
            // frmMasterExcel
            // 
            this.AcceptButton = this.btnOpenSelectedFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 396);
            this.Controls.Add(this.btnOpenSelectedFile);
            this.Controls.Add(this.lblDoubleClickOnExcelFileToOpen);
            this.Controls.Add(this.lblEnterDirectoryToSearchForExcelFiles);
            this.Controls.Add(this.lstExcelFiles);
            this.Controls.Add(this.txtFolderWithExcelFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMasterExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderWithExcelFiles;
        private System.Windows.Forms.ListBox lstExcelFiles;
        private System.Windows.Forms.Label lblEnterDirectoryToSearchForExcelFiles;
        private System.Windows.Forms.Label lblDoubleClickOnExcelFileToOpen;
        private System.Windows.Forms.Button btnOpenSelectedFile;
    }
}

