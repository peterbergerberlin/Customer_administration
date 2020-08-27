using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kundenverwaltung
{
    public partial class Form1 : Form {
        private static List<Kunde> kundenListe;
        private static string connString = "Server=127.0.0.1; Port=3306; User Id=testuser_2; Password=test12345; Database=Kunden;";
        private static string sql_befehl;
        private static Kunde kunde;
        private static string message = "Wollen Sie diesen Kunden wirklich löschen?";
        private static string title = "Sicherheitsfrage";
        private static MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        

        public Form1() {
            InitializeComponent();
            putAllKundenFromDBInArrayList();
            showKunde(kundenListe[0]);
            btn_first_kunde.Enabled = false;
            btn_prev_kunde.Enabled = false;
            Text = "Kundenverwaltung";
        }

        public void putAllKundenFromDBInArrayList() {
            kundenListe = new List<Kunde>();
            try {
                sql_befehl = "SELECT * FROM kundenliste";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand(sql_befehl, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    kunde = new Kunde(int.Parse
                        (reader[0].ToString()), 
                        reader[1].ToString(), 
                        reader[2].ToString(), 
                        reader[3].ToString(), 
                        reader[4].ToString(), 
                        reader[5].ToString(), 
                        reader[6].ToString());
                    if (!isEqualKundenNrInArrayList(kunde.Kdnr)) {
                        kundenListe.Add(kunde);
                    }
                }
                conn.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Upps" + " " + e);
            }
        }

        public void showKunde(Kunde kunde) {
            rtb_kundennummer.Text = kunde.Kdnr.ToString();
            rtb_vorname.Text = kunde.Vorname;
            rtb_nachname.Text = kunde.Nachname;
            rtb_strasse.Text = kunde.Strasse;
            rtb_plz.Text = kunde.Plz;
            rtb_ort.Text = kunde.Ort;
            rtb_email.Text = kunde.Email;
            lbl_count.Text = (kundenListe.IndexOf(kunde) + 1) + " von " + (kundenListe.Count());
            lbl_infoText.Text = "";
        }

        private bool isEqualKundenNrInArrayList(int kdnr) {
            bool erg = false;
            if (kundenListe.Count != 0) {
                foreach (Kunde k in kundenListe) {
                    if (k.Kdnr == kdnr) {
                        erg = true;
                    }
                }
            }
            return erg;
        }

        private Kunde getKundeFromArrayList(int kdnr) {
            kunde = new Kunde();
            if (kundenListe.Count != 0) {
                foreach (Kunde k in kundenListe) {
                    if (k.Kdnr == kdnr) {
                        return k;
                    }
                }
            }
            return kunde;
        }

        private bool isKundeValid(Kunde kunde)
        {
            if (String.IsNullOrWhiteSpace(kunde.Vorname)) { return false; }
            if (String.IsNullOrWhiteSpace(kunde.Nachname)) { return false; }
            if (String.IsNullOrWhiteSpace(kunde.Strasse)) { return false;}
            if (String.IsNullOrWhiteSpace(kunde.Plz)) { return false; }
            if (String.IsNullOrWhiteSpace(kunde.Ort)) { return false; }
            if (String.IsNullOrWhiteSpace(kunde.Email)) { return false; }
            return true;
        }

        private void addKunde() {   
            kunde = new Kunde(int.Parse(rtb_kundennummer.Text), rtb_vorname.Text, rtb_nachname.Text, rtb_strasse.Text, rtb_plz.Text, rtb_ort.Text, rtb_email.Text);
            if (isKundeValid(kunde)) {
                if (int.Parse(rtb_kundennummer.Text) > 0) {
                    if (!isEqualKundenNrInArrayList(int.Parse(rtb_kundennummer.Text))) {
                        if (RegexUtilities.IsValidEmail(kunde.Email)) {
                            try
                            {
                                sql_befehl = "INSERT INTO kundenliste VALUES (" + int.Parse(rtb_kundennummer.Text) + ",'" + rtb_vorname.Text + "','" + rtb_nachname.Text + "','" + rtb_strasse.Text + "','" + rtb_plz.Text + "','" + rtb_ort.Text + "','" + rtb_email.Text + "');";
                                MySqlConnection conn = new MySqlConnection(connString);
                                MySqlCommand cmd = new MySqlCommand(sql_befehl, conn);
                                conn.Open();
                                MySqlDataReader reader = cmd.ExecuteReader();
                                conn.Close();
                                putAllKundenFromDBInArrayList();
                                showKunde(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text)));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Upps" + " " + e);
                            }
                        } else { lbl_infoText.Text = "Die angegebene E-Mail Adresse ist ungültig."; }
                    } else { lbl_infoText.Text = "Diese Kundennummer ist schon vergeben."; }
                } else { lbl_infoText.Text = "Die Kundennummer muss größer als Null sein."; }
            } else { lbl_infoText.Text = "Bitte füllen Sie alle Felder aus."; }
        }

        private void deleteKunde()
        {
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                try
                {
                    sql_befehl = "DELETE FROM kundenliste WHERE kdnr =" + rtb_kundennummer.Text;
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand cmd = new MySqlCommand(sql_befehl, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                    int tempIndex = kundenListe.IndexOf(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text)));
                    kundenListe.Remove(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text)));
                    if (tempIndex == 0) { showKunde(kundenListe[tempIndex]); }
                    else { showKunde(kundenListe[tempIndex - 1]); }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Upps" + " " + e);
                }
            }
        }

        private void buttonDisabler() {
            if (kundenListe.IndexOf(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text))) == 0) {
                btn_first_kunde.Enabled = false;
                btn_prev_kunde.Enabled = false;
                btn_last_kunde.Enabled = true;
                btn_next_kunde.Enabled = true;
            }
            else if (kundenListe.IndexOf(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text))) == (kundenListe.Count - 1)) {
                btn_last_kunde.Enabled = false;
                btn_next_kunde.Enabled = false;
                btn_first_kunde.Enabled = true;
                btn_prev_kunde.Enabled = true;
            }
            else {
                btn_last_kunde.Enabled = true;
                btn_next_kunde.Enabled = true;
                btn_first_kunde.Enabled = true;
                btn_prev_kunde.Enabled = true;
            }
        }

        private void btn_first_kunde_Click(object sender, EventArgs e) {
            showKunde(kundenListe[0]);
            buttonDisabler();
        }

        private void btn_new_kunde_Click(object sender, EventArgs e) {
            addKunde();
            buttonDisabler();
        }

        private void btn_delete_kunde_Click(object sender, EventArgs e) {
            deleteKunde();
            buttonDisabler();
        }

        private void btn_prev_kunde_Click(object sender, EventArgs e) {
            showKunde(kundenListe[kundenListe.IndexOf(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text))) - 1]);
            buttonDisabler();
        }

        private void btn_next_kunde_Click(object sender, EventArgs e) {
            showKunde(kundenListe[kundenListe.IndexOf(getKundeFromArrayList(int.Parse(rtb_kundennummer.Text))) + 1]);
            buttonDisabler();
        }

        private void btn_last_kunde_Click(object sender, EventArgs e) {
            showKunde(kundenListe[kundenListe.Count-1]);
            buttonDisabler();
        }
    }
}
