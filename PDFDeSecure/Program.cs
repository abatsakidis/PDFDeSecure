using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFDeSecure
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            var Args = Environment.GetCommandLineArgs();
            if (Args.Length > 2)
            {
                //Auto Processing Mode
                PdfDocument pdf = new PdfDocument();
                PdfDocument outpdf = new PdfDocument();
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
                    try
                    {
                        outpdf = new PdfDocument();
                        Stream fileStream = fi.OpenRead();
                        pdf = PdfReader.Open(fileStream, PdfDocumentOpenMode.Import);
                        foreach (PdfPage page in pdf.Pages)
                        {
                            outpdf.AddPage(page);
                        }
                        outpdf.Save(new FileInfo(Output + "\\" + fi.Name).OpenWrite(), true);
                        counter++;
                        pdf.Dispose();
                        fileStream.Close();
                        outpdf.Dispose();
                    }
                    catch (Exception ex)
                    {
                        error++;
                        File.WriteAllText(Output + "\\Error-" + fi.Name + ".log", ex.ToString());
                    }
                }
                MessageBox.Show("Unlocked " + counter + " files" + Environment.NewLine + "Failed " + error + " files" + Environment.NewLine + "Percentage " + counter + "/" + (counter + error) + " = " + ((float)counter / (float)(counter + error) * 100).ToString("f2") + "%, Cheers!", "PDF file Unlocked! and Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PDFDeSecure());
            }
        }
    }
}
