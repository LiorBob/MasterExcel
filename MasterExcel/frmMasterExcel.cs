using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MasterExcel
{
    public partial class frmMasterExcel : Form
    {
        public frmMasterExcel()
        {
            InitializeComponent();

            txtFolderWithExcelFiles.Text = @"N:\Automation\PackagesExecutionProgress\V15";
        }





        private void txtFolderWithExcelFiles_TextChanged(object sender, EventArgs e)
        {
            btnOpenSelectedFile.Enabled = false;

            lstExcelFiles.Items.Clear();




            // So we'll search for excel files only if the typed directory is a valid directory

            if (!Directory.Exists(txtFolderWithExcelFiles.Text))
            {
                return;
            }




            // Shows only excel files names under the selected folder

            string[] excelFilesNamesUnderFolder = Directory.GetFiles(txtFolderWithExcelFiles.Text, "*.xls*", SearchOption.TopDirectoryOnly);


            foreach (string excelFileName in excelFilesNamesUnderFolder)
            {
                lstExcelFiles.Items.Add(Path.GetFileName(excelFileName));
            }




            if (lstExcelFiles.Items.Count > 0)
            {
                lstExcelFiles.SelectedIndex = 0;

                btnOpenSelectedFile.Enabled = true;
            }

        }





        private void lstExcelFiles_DoubleClick(object sender, EventArgs e)
        {
            btnOpenSelectedFile.PerformClick();
        }






        // So we can select some files together  and open them (open some excels simultaneously)

        private void btnOpenSelectedFile_Click(object sender, EventArgs e)
        {
            if (lstExcelFiles.Items.Count > 0)
            {
                foreach (var selectedFile in lstExcelFiles.SelectedItems)
                {
                    string selectedFileName = selectedFile.ToString();

                    string fileNameToOpen = Path.Combine(txtFolderWithExcelFiles.Text, selectedFileName);



                    try
                    {
                        Process.Start(fileNameToOpen);
                    }

                    catch (Win32Exception)
                    {
                        MessageBox.Show("An error occurred when trying to open " + fileNameToOpen, this.Text);
                    }

                }

            }

        }

    }

}
