namespace KusanovicLenardProvjeraZnanjaZadatak4
{
    partial class FormaStudenti
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
            this.buttonNoviStudent = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonNoviStudent
            // 
            this.buttonNoviStudent.Location = new System.Drawing.Point(36, 34);
            this.buttonNoviStudent.Name = "buttonNoviStudent";
            this.buttonNoviStudent.Size = new System.Drawing.Size(123, 23);
            this.buttonNoviStudent.TabIndex = 0;
            this.buttonNoviStudent.Text = "Dodaj novog studenta";
            this.buttonNoviStudent.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(551, 172);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 1;
            this.buttonObrisi.Text = "Obrisi Studenta";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.Location = new System.Drawing.Point(49, 310);
            this.buttonObrisiSve.Name = "buttonObrisiSve";
            this.buttonObrisiSve.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisiSve.TabIndex = 2;
            this.buttonObrisiSve.Text = "Obrisi sve studente";
            this.buttonObrisiSve.UseVisualStyleBackColor = true;
            this.buttonObrisiSve.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 203);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FormaStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonNoviStudent);
            this.Name = "FormaStudenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNoviStudent;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonObrisiSve;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

