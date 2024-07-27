namespace PDFDeSecure
{
    partial class PDFDeSecure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFDeSecure));
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            btnbrowse = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pdffile = new System.Windows.Forms.Label();
            btnunlock = new System.Windows.Forms.Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new System.Drawing.Point(225, 31);
            btnbrowse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new System.Drawing.Size(125, 44);
            btnbrowse.TabIndex = 0;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 40);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 25);
            label1.TabIndex = 1;
            label1.Text = "Select PDF File ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 100);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Selected PDF file:";
            // 
            // pdffile
            // 
            pdffile.AutoSize = true;
            pdffile.Location = new System.Drawing.Point(183, 100);
            pdffile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            pdffile.Name = "pdffile";
            pdffile.Size = new System.Drawing.Size(0, 25);
            pdffile.TabIndex = 3;
            // 
            // btnunlock
            // 
            btnunlock.BackColor = System.Drawing.Color.DarkRed;
            btnunlock.Enabled = false;
            btnunlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnunlock.ForeColor = System.Drawing.SystemColors.Control;
            btnunlock.Location = new System.Drawing.Point(538, 100);
            btnunlock.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnunlock.Name = "btnunlock";
            btnunlock.Size = new System.Drawing.Size(141, 58);
            btnunlock.TabIndex = 4;
            btnunlock.Text = "Unlock PDF";
            btnunlock.UseVisualStyleBackColor = false;
            btnunlock.Click += btnunlock_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(20, 180);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(661, 10);
            progressBar1.TabIndex = 5;
            // 
            // PDFDeSecure
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(693, 202);
            Controls.Add(progressBar1);
            Controls.Add(btnunlock);
            Controls.Add(pdffile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnbrowse);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "PDFDeSecure";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PDFDeSecure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pdffile;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

