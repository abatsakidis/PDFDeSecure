using System;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFDeSecure
{
    public partial class PDFDeSecure : Form
    {

        PdfDocument pdf = new PdfDocument();

        PdfDocument outpdf = new PdfDocument();

        public PDFDeSecure()
        {
            InitializeComponent();
        }

       
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select PDF File";
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdffile.Text = openFileDialog1.FileName.ToString();

                pdf = PdfReader.Open(openFileDialog1.OpenFile(), PdfDocumentOpenMode.Import);

                foreach (PdfPage page in pdf.Pages)
                {
                    outpdf.AddPage(page);
                }

                btnunlock.Enabled = true;
            }
        }

        private void btnunlock_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Unlocked PDF File";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outpdf.Save(saveFileDialog1.OpenFile(), true);
                MessageBox.Show("PDF file Unlocked! and Saved!","Unlocked & Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
