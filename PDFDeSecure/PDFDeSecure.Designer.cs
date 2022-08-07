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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pdffile = new System.Windows.Forms.Label();
            this.btnunlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(337, 37);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(188, 53);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select PDF File ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected PDF file:";
            // 
            // pdffile
            // 
            this.pdffile.AutoSize = true;
            this.pdffile.Location = new System.Drawing.Point(275, 120);
            this.pdffile.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pdffile.Name = "pdffile";
            this.pdffile.Size = new System.Drawing.Size(0, 30);
            this.pdffile.TabIndex = 3;
            // 
            // btnunlock
            // 
            this.btnunlock.BackColor = System.Drawing.Color.DarkRed;
            this.btnunlock.Enabled = false;
            this.btnunlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunlock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnunlock.Location = new System.Drawing.Point(798, 155);
            this.btnunlock.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(212, 69);
            this.btnunlock.TabIndex = 4;
            this.btnunlock.Text = "Unlock PDF";
            this.btnunlock.UseVisualStyleBackColor = false;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click);
            // 
            // PDFDeSecure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 242);
            this.Controls.Add(this.btnunlock);
            this.Controls.Add(this.pdffile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "PDFDeSecure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFDeSecure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pdffile;
        private System.Windows.Forms.Button btnunlock;
    }
}

