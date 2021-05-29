using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinozaver
{
    public class Spremenljivke
    {
        #region Ukazi
        Dictionary<int, string> ukaz_za_orozje = new Dictionary<int, string>()
        {
            { 0, "C" },
            { 1, "K" },
            { 2, "H" },
            { 3, "G" },
            { 4, "L" },
            { 5, "P" },
            { 6, "S" },
        };
        // getter
        public string Ukaz_za_orozje(int kljuc)
        {
            if (ukaz_za_orozje.ContainsKey(kljuc))
            {
                return ukaz_za_orozje[kljuc];
            }
            return null;
        }
        // setter
        public void Ukaz_za_orozje(int kljuc,  string vrednost)
        {
            if (ukaz_za_orozje.ContainsKey(kljuc))
            {
                ukaz_za_orozje[kljuc] = vrednost;
            }
            else
            {
                ukaz_za_orozje.Add(kljuc, vrednost);
            }
        }

        Dictionary<string, string> ukaz_za_premik = new Dictionary<string, string>()
        {
            { "gor", "gor" },
            { "dol", "dol" }
        };
        // getter
        public string Ukaz_za_premik(string kljuc)
        {
            if (ukaz_za_premik.ContainsKey(kljuc))
            {
                return ukaz_za_premik[kljuc];
            }
            return null;
        }
        // setter
        public void Ukaz_za_premik(string kljuc, string vrednost)
        {
            if (ukaz_za_premik.ContainsKey(kljuc))
            {
                ukaz_za_premik[kljuc] = vrednost;
            }
            else
            {
                ukaz_za_premik.Add(kljuc, vrednost);
            }
        }

        string konec_orozja = "X";
        public string Konec_orozja
        {
            get { return konec_orozja; }
            set { konec_orozja = value; }
        }

        public Dictionary<string, Keys> gumb_za_orozje = new Dictionary<string, Keys>()
        {
            { "cigaret", Keys.C },
            { "kapa", Keys.K },
            { "kladivo", Keys.H },
            { "kozarec", Keys.G },
            { "lizika", Keys.L },
            { "pištola", Keys.P },
            { "sablja", Keys.S }
        };
        // getter
        public Keys Gumb_za_orozje(string kljuc)
        {
            if (gumb_za_orozje.ContainsKey(kljuc))
            {
                return gumb_za_orozje[kljuc];
            }
            return Keys.None;
        }
        // setter
        public void Gumb_za_orozje(string kljuc, Keys vrednost)
        {
            if (gumb_za_orozje.ContainsKey(kljuc))
            {
                gumb_za_orozje[kljuc] = vrednost;
            }
            else
            {
                gumb_za_orozje.Add(kljuc, vrednost);
            }
        }

        Dictionary<string, Keys> gumb_za_premik = new Dictionary<string, Keys>()
        {
            { "gor", Keys.Up },
            { "dol", Keys.Down }
        };
        // getter
        public Keys Gumb_za_premik(string kljuc)
        {
            if (gumb_za_premik.ContainsKey(kljuc))
            {
                return gumb_za_premik[kljuc];
            }
            return Keys.None;
        }
        // setter
        public void Gumb_za_premik(string kljuc, Keys vrednost)
        {
            if (gumb_za_premik.ContainsKey(kljuc))
            {
                gumb_za_premik[kljuc] = vrednost;
            }
            else
            {
                gumb_za_premik.Add(kljuc, vrednost);
            }
        }

        Keys konec_uporabe_orozja = Keys.X;
        public Keys Konec_uporabe_orozja
        {
            get { return konec_uporabe_orozja; }
            set { konec_uporabe_orozja = value; }
        }
        #endregion

        #region Tocke
        bool dosezen_nov_top_rezultat = false;  // če ne tekmujemo od začetka, moramo vedeti, ali smo že presegli prehdonji top rezultat
        public bool Dosezen_nov_top_rezultat
        {
            get { return dosezen_nov_top_rezultat; }
            set { dosezen_nov_top_rezultat = value; }
        }

        int tocke = 0;  // dosežene točke = koliko ovir je igralec premagal
        public int Tocke
        {
            get { return tocke; }
            set { tocke = value; }
        }

        int top_tocke = 0;  // dosedaj najboljši rezultat
        public int Top_tocke
        {
            get { return top_tocke; }
            set
            {
                // dosežemo nov najboljši rezultat
                if (value > Top_tocke)
                {
                    top_tocke = value;
                    Dosezen_nov_top_rezultat = true;
                }
            }
        }
        #endregion

        #region Igralec
        public Dictionary<string, int> igralec_rezultat = new Dictionary<string, int>();
        // getter
        public int Igralec_rezultat(string kljuc)
        {
            if (igralec_rezultat.ContainsKey(kljuc))
            {
                return igralec_rezultat[kljuc];
            }
            // privzeta vrednost za nevsebovan ključ je -1
            return -1;
        }
        // setter
        public void Igralec_rezultat(string kljuc, int vrednost)
        {
            if (igralec_rezultat.ContainsKey(kljuc))
            {
                igralec_rezultat[kljuc] = vrednost;
            }
            else
            {
                igralec_rezultat.Add(kljuc, vrednost);
            }
        }

        string ime_igralca = "nov_igralec";
        public string Ime_igralca
        { 
            get { return ime_igralca; }
            set 
            { 
                if (value != "")
                {
                    ime_igralca = value;
                }
            }
        }
        #endregion
    }
}
