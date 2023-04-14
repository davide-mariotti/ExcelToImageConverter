using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Table;
using Spire.Xls;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using PdfiumViewer;
using static System.Net.Mime.MediaTypeNames;
using Spire.Pdf.Exporting.XPS.Schema;
using System.Security.Cryptography;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using MigraDocCore.DocumentObjectModel.Tables;
using MigraDocCore.DocumentObjectModel;

namespace ExcelToImageConverter
{
    public partial class Form1 : Form
    {

        static readonly int LIMIT_ROWS_BLANK = 50;
        static readonly int IMAGE_HEIGHT_PX = 1080;
        static readonly int IMAGE_WIDTH_PX = 1920;
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseExcelFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelFilePathTextBox.Text = dialog.FileName;
                }
            }
        }

        private void BrowseOutputFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OutputFolderTextBox.Text = dialog.SelectedPath;
                }
            }
        }
    
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ExcelFilePathTextBox.Text))
            {
                MessageBox.Show("Seleziona un file Excel da convertire", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(OutputFolderTextBox.Text))
            {
                MessageBox.Show("Seleziona una cartella di destinazione per le immagini convertite", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string excelFilePath = ExcelFilePathTextBox.Text;
            string outputFolderPath = OutputFolderTextBox.Text;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var fileInfo = new FileInfo(excelFilePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                var fileName = System.IO.Path.GetFileNameWithoutExtension(excelFilePath);
                var pdfPath = System.IO.Path.Combine(outputFolderPath, $"{fileName}.pdf");

                Workbook workbook = new Workbook();
                //Load excel file  
                workbook.LoadFromFile(excelFilePath);
                //Save excel file to pdf file.  

                workbook.SaveToFile(pdfPath, Spire.Xls.FileFormat.PDF);

                           }
                MessageBox.Show("Conversion Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
