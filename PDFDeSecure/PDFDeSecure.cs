using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFDeSecure
{
    public partial class PDFDeSecure : Form
    {

        PdfDocument pdf;

        PdfDocument outpdf;

        public PDFDeSecure()
        {
            InitializeComponent();
        }

       
        private async void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select PDF File";
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdffile.Text = openFileDialog1.FileName.ToString();
                btnunlock.Enabled = false; 
                btnbrowse.Enabled = false;
                progressBar1.Value = 0;
                var progress = new Progress<int>(report => progressBar1.Value = report);
                btnunlock.Text = "Processing...";
                await Task.Run(() =>
                {
                    outpdf = new PdfDocument();
                    Stream fileStream = openFileDialog1.OpenFile();
                    pdf = PdfReader.Open(fileStream, PdfDocumentOpenMode.Import);
                    int current = 0;
                    foreach (PdfPage page in pdf.Pages)
                    {
                        outpdf.AddPage(page);
                        current++;
                        IProgress<int> iprog = progress;
                        iprog.Report(current*100/pdf.PageCount);
                    }
                    fileStream.Close();
                });
                btnunlock.Enabled = true;
                btnbrowse.Enabled = true;
                btnunlock.Text = "Unlock PDF";
            }
        }

        private async void btnunlock_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Unlocked PDF File";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnunlock.Text = "Saving...";
                btnunlock.Enabled = false;
                await Task.Run(() =>
                {
                    outpdf.Save(saveFileDialog1.OpenFile(), true);
                    outpdf.Dispose();
                    pdf.Dispose();
                });
                MessageBox.Show("PDF file Unlocked! and Saved!","Unlocked & Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                pdffile.Text = "";
                btnunlock.Text = "Unlock PDF";
            }
        }
    }
}
