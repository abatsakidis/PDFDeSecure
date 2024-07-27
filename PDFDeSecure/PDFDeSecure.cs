using System;
using System.IO;
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
            var Args = Environment.GetCommandLineArgs();
            if (Args.Length > 2)
            {
                //Auto Processing Mode
                //First Argu Is INPUT Dir, Second Is OUTPUT Dir
                var Input = Args[1];
                var Output = Args[2];
                DirectoryInfo di = new DirectoryInfo(Input);
                var aryFi = di.GetFiles("*.pdf");
                var counter = 0;
                var error = 0;
                foreach (FileInfo fi in aryFi)
                {
                    //Skip file with errors
                    try { 
                        outpdf = new PdfDocument();
                        Stream fileStream = fi.OpenRead();
                        pdf = PdfReader.Open(fileStream, PdfDocumentOpenMode.Import);
                        foreach (PdfPage page in pdf.Pages)
                        {
                            outpdf.AddPage(page);
                            }
                        outpdf.Save(new FileInfo(Output+"\\"+fi.Name).OpenWrite(), true);
                        counter++;
                        pdf.Dispose();
                        fileStream.Close();
                        outpdf.Dispose();
                    }
                    catch(Exception ex)
                    {
                        error++;
                        File.WriteAllText(Output + "\\Error-" + fi.Name + ".log", ex.ToString());
                    }
                }
                MessageBox.Show("Unlocked " + counter + " files" + Environment.NewLine + "Failed " + error + " files" + Environment.NewLine + "Percentage " + counter + "/" + (counter + error) + " = " + ((float)counter/ (float)(counter + error) * 100).ToString("f2") + "%, Cheers!", "PDF file Unlocked! and Saved!" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
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
                Stream fileStream = openFileDialog1.OpenFile();
                pdf = PdfReader.Open(fileStream, PdfDocumentOpenMode.Import);

                foreach (PdfPage page in pdf.Pages)
                {
                    outpdf.AddPage(page);
                }

                btnunlock.Enabled = true;
                fileStream.Close();
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
                outpdf.Dispose();
                pdf.Dispose();
                MessageBox.Show("PDF file Unlocked! and Saved!","Unlocked & Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                pdffile.Text = "";
                btnunlock.Enabled = false;
            }
        }
    }
}
