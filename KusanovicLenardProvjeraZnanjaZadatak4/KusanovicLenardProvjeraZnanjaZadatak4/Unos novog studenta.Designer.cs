namespace KusanovicLenardProvjeraZnanjaZadatak4
{
    partial class FormaUnosNovogStudenta
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
            this.labelIme = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelBrojIndeksa = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSmjer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(47, 40);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // labelBrojIndeksa
            // 
            this.labelBrojIndeksa.AutoSize = true;
            this.labelBrojIndeksa.Location = new System.Drawing.Point(464, 40);
            this.labelBrojIndeksa.Name = "labelBrojIndeksa";
            this.labelBrojIndeksa.Size = new System.Drawing.Size(68, 13);
            this.labelBrojIndeksa.TabIndex = 1;
            this.labelBrojIndeksa.Text = "Broj indeksa:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(47, 130);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(464, 145);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(81, 13);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum rodjenja:";
            // 
            // labelSmjer
            // 
            this.labelSmjer.AutoSize = true;
            this.labelSmjer.Location = new System.Drawing.Point(46, 224);
            this.labelSmjer.Name = "labelSmjer";
            this.labelSmjer.Size = new System.Drawing.Size(36, 13);
            this.labelSmjer.TabIndex = 4;
            this.labelSmjer.Text = "Smjer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(467, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(50, 339);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonSnimi.TabIndex = 12;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(469, 308);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(75, 23);
            this.buttonOtkazi.TabIndex = 13;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            // 
            // FormaUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSmjer);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelBrojIndeksa);
            this.Controls.Add(this.labelIme);
            this.Name = "FormaUnosNovogStudenta";
            this.Text = "Unos novog studenta";
            this.Load += new System.EventHandler(this.Unos_novog_studenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelBrojIndeksa;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelSmjer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}