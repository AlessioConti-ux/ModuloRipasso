namespace ModuloRipasso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFrasi = new ListBox();
            btnDecifra = new Button();
            btnLeggi = new Button();
            SuspendLayout();
            // 
            // lstFrasi
            // 
            lstFrasi.FormattingEnabled = true;
            lstFrasi.ItemHeight = 15;
            lstFrasi.Location = new Point(292, 89);
            lstFrasi.Name = "lstFrasi";
            lstFrasi.Size = new Size(171, 154);
            lstFrasi.TabIndex = 0;
            // 
            // btnDecifra
            // 
            btnDecifra.Location = new Point(292, 293);
            btnDecifra.Name = "btnDecifra";
            btnDecifra.Size = new Size(171, 23);
            btnDecifra.TabIndex = 1;
            btnDecifra.Text = "Decifra Frasi";
            btnDecifra.UseVisualStyleBackColor = true;
            btnDecifra.Click += button1_Click;
            // 
            // btnLeggi
            // 
            btnLeggi.Location = new Point(292, 264);
            btnLeggi.Name = "btnLeggi";
            btnLeggi.Size = new Size(171, 23);
            btnLeggi.TabIndex = 2;
            btnLeggi.Text = "Leggi File";
            btnLeggi.UseVisualStyleBackColor = true;
            btnLeggi.Click += btnLeggi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeggi);
            Controls.Add(btnDecifra);
            Controls.Add(lstFrasi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFrasi;
        private Button btnDecifra;
        private Button btnLeggi;
    }
}
