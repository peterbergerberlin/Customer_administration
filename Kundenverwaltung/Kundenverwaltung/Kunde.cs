using System;

namespace Kundenverwaltung
{
    public class Kunde
    {
        private int kdnr;
        private String vorname;
        private String nachname;
        private String strasse;
        private String plz;
        private String ort;
        private String email;

        public int Kdnr { get => kdnr; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Email { get => email; set => email = value; }

        public Kunde(int kdnr, String vorname, String nachname, String strasse, String plz, String ort, String email)
        {
            this.kdnr = kdnr;
            this.vorname = vorname;
            this.nachname = nachname;
            this.strasse = strasse;
            this.plz = plz;
            this.ort = ort;
            this.email = email;
        }

        public Kunde()
        {
        }

        public override string ToString()
        {
            return Kdnr + " " + vorname + " " + nachname + " " + strasse + " " + plz + " " + ort + " " + email;
        }

        public bool equals(Object o)
        {
            bool erg = false;
            if (this.Kdnr == ((Kunde)o).Kdnr)
            {
                erg = true;
            }
            return erg;
        }
    }
}
