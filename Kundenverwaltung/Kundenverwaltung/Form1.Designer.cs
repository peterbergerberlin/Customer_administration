namespace Kundenverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kundennummer = new System.Windows.Forms.Label();
            this.lbl_vorname = new System.Windows.Forms.Label();
            this.lbl_nachname = new System.Windows.Forms.Label();
            this.lbl_strasse = new System.Windows.Forms.Label();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_first_kunde = new System.Windows.Forms.Button();
            this.btn_prev_kunde = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_new_kunde = new System.Windows.Forms.Button();
            this.btn_next_kunde = new System.Windows.Forms.Button();
            this.btn_last_kunde = new System.Windows.Forms.Button();
            this.rtb_kundennummer = new System.Windows.Forms.RichTextBox();
            this.rtb_vorname = new System.Windows.Forms.RichTextBox();
            this.rtb_nachname = new System.Windows.Forms.RichTextBox();
            this.rtb_strasse = new System.Windows.Forms.RichTextBox();
            this.rtb_plz = new System.Windows.Forms.RichTextBox();
            this.rtb_ort = new System.Windows.Forms.RichTextBox();
            this.rtb_email = new System.Windows.Forms.RichTextBox();
            this.lbl_infoText = new System.Windows.Forms.Label();
            this.btn_delete_kunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kundennummer
            // 
            this.lbl_kundennummer.AutoSize = true;
            this.lbl_kundennummer.Location = new System.Drawing.Point(47, 43);
            this.lbl_kundennummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kundennummer.Name = "lbl_kundennummer";
            this.lbl_kundennummer.Size = new System.Drawing.Size(108, 17);
            this.lbl_kundennummer.TabIndex = 0;
            this.lbl_kundennummer.Text = "Kundennummer";
            // 
            // lbl_vorname
            // 
            this.lbl_vorname.AutoSize = true;
            this.lbl_vorname.Location = new System.Drawing.Point(47, 97);
            this.lbl_vorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vorname.Name = "lbl_vorname";
            this.lbl_vorname.Size = new System.Drawing.Size(65, 17);
            this.lbl_vorname.TabIndex = 1;
            this.lbl_vorname.Text = "Vorname";
            // 
            // lbl_nachname
            // 
            this.lbl_nachname.AutoSize = true;
            this.lbl_nachname.Location = new System.Drawing.Point(47, 151);
            this.lbl_nachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nachname.Name = "lbl_nachname";
            this.lbl_nachname.Size = new System.Drawing.Size(76, 17);
            this.lbl_nachname.TabIndex = 2;
            this.lbl_nachname.Text = "Nachname";
            // 
            // lbl_strasse
            // 
            this.lbl_strasse.AutoSize = true;
            this.lbl_strasse.Location = new System.Drawing.Point(47, 204);
            this.lbl_strasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_strasse.Name = "lbl_strasse";
            this.lbl_strasse.Size = new System.Drawing.Size(56, 17);
            this.lbl_strasse.TabIndex = 3;
            this.lbl_strasse.Text = "Strasse";
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Location = new System.Drawing.Point(47, 257);
            this.lbl_plz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(34, 17);
            this.lbl_plz.TabIndex = 4;
            this.lbl_plz.Text = "PLZ";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(47, 310);
            this.lbl_ort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(28, 17);
            this.lbl_ort.TabIndex = 5;
            this.lbl_ort.Text = "Ort";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(47, 367);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 17);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "E-Mail";
            // 
            // btn_first_kunde
            // 
            this.btn_first_kunde.Location = new System.Drawing.Point(51, 464);
            this.btn_first_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_first_kunde.Name = "btn_first_kunde";
            this.btn_first_kunde.Size = new System.Drawing.Size(67, 37);
            this.btn_first_kunde.TabIndex = 7;
            this.btn_first_kunde.Text = "<*";
            this.btn_first_kunde.UseVisualStyleBackColor = true;
            this.btn_first_kunde.Click += new System.EventHandler(this.btn_first_kunde_Click);
            // 
            // btn_prev_kunde
            // 
            this.btn_prev_kunde.Location = new System.Drawing.Point(139, 464);
            this.btn_prev_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prev_kunde.Name = "btn_prev_kunde";
            this.btn_prev_kunde.Size = new System.Drawing.Size(67, 37);
            this.btn_prev_kunde.TabIndex = 8;
            this.btn_prev_kunde.Text = "<<";
            this.btn_prev_kunde.UseVisualStyleBackColor = true;
            this.btn_prev_kunde.Click += new System.EventHandler(this.btn_prev_kunde_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(233, 475);
            this.lbl_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(52, 17);
            this.lbl_count.TabIndex = 9;
            this.lbl_count.Text = "x von y";
            // 
            // btn_new_kunde
            // 
            this.btn_new_kunde.Location = new System.Drawing.Point(317, 464);
            this.btn_new_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new_kunde.Name = "btn_new_kunde";
            this.btn_new_kunde.Size = new System.Drawing.Size(67, 37);
            this.btn_new_kunde.TabIndex = 10;
            this.btn_new_kunde.Text = "*";
            this.btn_new_kunde.UseVisualStyleBackColor = true;
            this.btn_new_kunde.Click += new System.EventHandler(this.btn_new_kunde_Click);
            // 
            // btn_next_kunde
            // 
            this.btn_next_kunde.Location = new System.Drawing.Point(405, 464);
            this.btn_next_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next_kunde.Name = "btn_next_kunde";
            this.btn_next_kunde.Size = new System.Drawing.Size(67, 37);
            this.btn_next_kunde.TabIndex = 11;
            this.btn_next_kunde.Text = ">>";
            this.btn_next_kunde.UseVisualStyleBackColor = true;
            this.btn_next_kunde.Click += new System.EventHandler(this.btn_next_kunde_Click);
            // 
            // btn_last_kunde
            // 
            this.btn_last_kunde.Location = new System.Drawing.Point(493, 464);
            this.btn_last_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_last_kunde.Name = "btn_last_kunde";
            this.btn_last_kunde.Size = new System.Drawing.Size(67, 37);
            this.btn_last_kunde.TabIndex = 12;
            this.btn_last_kunde.Text = ">*";
            this.btn_last_kunde.UseVisualStyleBackColor = true;
            this.btn_last_kunde.Click += new System.EventHandler(this.btn_last_kunde_Click);
            // 
            // rtb_kundennummer
            // 
            this.rtb_kundennummer.Location = new System.Drawing.Point(211, 39);
            this.rtb_kundennummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_kundennummer.Name = "rtb_kundennummer";
            this.rtb_kundennummer.Size = new System.Drawing.Size(348, 38);
            this.rtb_kundennummer.TabIndex = 13;
            this.rtb_kundennummer.Text = "";
            // 
            // rtb_vorname
            // 
            this.rtb_vorname.Location = new System.Drawing.Point(211, 94);
            this.rtb_vorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_vorname.Name = "rtb_vorname";
            this.rtb_vorname.Size = new System.Drawing.Size(348, 38);
            this.rtb_vorname.TabIndex = 14;
            this.rtb_vorname.Text = "";
            // 
            // rtb_nachname
            // 
            this.rtb_nachname.Location = new System.Drawing.Point(211, 148);
            this.rtb_nachname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_nachname.Name = "rtb_nachname";
            this.rtb_nachname.Size = new System.Drawing.Size(348, 38);
            this.rtb_nachname.TabIndex = 15;
            this.rtb_nachname.Text = "";
            // 
            // rtb_strasse
            // 
            this.rtb_strasse.Location = new System.Drawing.Point(211, 201);
            this.rtb_strasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_strasse.Name = "rtb_strasse";
            this.rtb_strasse.Size = new System.Drawing.Size(348, 38);
            this.rtb_strasse.TabIndex = 16;
            this.rtb_strasse.Text = "";
            // 
            // rtb_plz
            // 
            this.rtb_plz.Location = new System.Drawing.Point(211, 254);
            this.rtb_plz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_plz.Name = "rtb_plz";
            this.rtb_plz.Size = new System.Drawing.Size(348, 38);
            this.rtb_plz.TabIndex = 17;
            this.rtb_plz.Text = "";
            // 
            // rtb_ort
            // 
            this.rtb_ort.Location = new System.Drawing.Point(211, 306);
            this.rtb_ort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_ort.Name = "rtb_ort";
            this.rtb_ort.Size = new System.Drawing.Size(348, 38);
            this.rtb_ort.TabIndex = 18;
            this.rtb_ort.Text = "";
            // 
            // rtb_email
            // 
            this.rtb_email.Location = new System.Drawing.Point(211, 363);
            this.rtb_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_email.Name = "rtb_email";
            this.rtb_email.Size = new System.Drawing.Size(348, 38);
            this.rtb_email.TabIndex = 19;
            this.rtb_email.Text = "";
            // 
            // lbl_infoText
            // 
            this.lbl_infoText.AutoSize = true;
            this.lbl_infoText.Location = new System.Drawing.Point(51, 421);
            this.lbl_infoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_infoText.Name = "lbl_infoText";
            this.lbl_infoText.Size = new System.Drawing.Size(0, 17);
            this.lbl_infoText.TabIndex = 20;
            // 
            // btn_delete_kunde
            // 
            this.btn_delete_kunde.Location = new System.Drawing.Point(51, 522);
            this.btn_delete_kunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete_kunde.Name = "btn_delete_kunde";
            this.btn_delete_kunde.Size = new System.Drawing.Size(100, 37);
            this.btn_delete_kunde.TabIndex = 21;
            this.btn_delete_kunde.Text = "Löschen";
            this.btn_delete_kunde.UseVisualStyleBackColor = true;
            this.btn_delete_kunde.Click += new System.EventHandler(this.btn_delete_kunde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 578);
            this.Controls.Add(this.btn_delete_kunde);
            this.Controls.Add(this.lbl_infoText);
            this.Controls.Add(this.rtb_email);
            this.Controls.Add(this.rtb_ort);
            this.Controls.Add(this.rtb_plz);
            this.Controls.Add(this.rtb_strasse);
            this.Controls.Add(this.rtb_nachname);
            this.Controls.Add(this.rtb_vorname);
            this.Controls.Add(this.rtb_kundennummer);
            this.Controls.Add(this.btn_last_kunde);
            this.Controls.Add(this.btn_next_kunde);
            this.Controls.Add(this.btn_new_kunde);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_prev_kunde);
            this.Controls.Add(this.btn_first_kunde);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.lbl_plz);
            this.Controls.Add(this.lbl_strasse);
            this.Controls.Add(this.lbl_nachname);
            this.Controls.Add(this.lbl_vorname);
            this.Controls.Add(this.lbl_kundennummer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kundennummer;
        private System.Windows.Forms.Label lbl_vorname;
        private System.Windows.Forms.Label lbl_nachname;
        private System.Windows.Forms.Label lbl_strasse;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_first_kunde;
        private System.Windows.Forms.Button btn_prev_kunde;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_new_kunde;
        private System.Windows.Forms.Button btn_next_kunde;
        private System.Windows.Forms.Button btn_last_kunde;
        private System.Windows.Forms.RichTextBox rtb_kundennummer;
        private System.Windows.Forms.RichTextBox rtb_vorname;
        private System.Windows.Forms.RichTextBox rtb_nachname;
        private System.Windows.Forms.RichTextBox rtb_strasse;
        private System.Windows.Forms.RichTextBox rtb_plz;
        private System.Windows.Forms.RichTextBox rtb_ort;
        private System.Windows.Forms.RichTextBox rtb_email;
        private System.Windows.Forms.Label lbl_infoText;
        private System.Windows.Forms.Button btn_delete_kunde;
    }
}

