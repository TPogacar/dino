using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinozaver
{
    public partial class Ukazi : Form
    {
        public Ukazi()
        {
            InitializeComponent();
            ponastavi();
        }

        private void ponastavi()
        {
            cigaret.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(0);
            kapa.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(1);
            kladivo.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(2);
            kozarec.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(3);
            lizika.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(4);
            pistola.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(5);
            sablja.Text = Pozdrav.spremenljivke.Ukaz_za_orozje(6);
            gor.Text = Pozdrav.spremenljivke.Ukaz_za_premik("gor");
            dol.Text = Pozdrav.spremenljivke.Ukaz_za_premik("dol");
            konec_orozje.Text = Pozdrav.spremenljivke.Konec_orozja;
        }

        #region Konstante
        Dictionary<string, Keys> dovoljeni_ukazi = new Dictionary<string, Keys>()
        {
            { "A", Keys.A },
            { "B", Keys.B },
            { "C", Keys.C },
            { "D", Keys.D },
            { "E", Keys.E },
            { "F", Keys.F },
            { "G", Keys.G },
            { "H", Keys.H },
            { "I", Keys.I },
            { "J", Keys.J },
            { "K", Keys.K },
            { "L", Keys.L },
            { "M", Keys.M },
            { "N", Keys.N },
            { "O", Keys.O },
            { "P", Keys.P },
            { "R", Keys.R },
            { "S", Keys.S },
            { "T", Keys.T },
            { "U", Keys.T },
            { "V", Keys.V },
            { "Z", Keys.Z },
            { "X", Keys.X },
            { "Y", Keys.Y },
            { "Q", Keys.Q },
            { "1", Keys.NumPad1 },
            { "2", Keys.NumPad2 },
            { "3", Keys.NumPad3 },
            { "4", Keys.NumPad4 },
            { "5", Keys.NumPad5 },
            { "6", Keys.NumPad6 },
            { "7", Keys.NumPad7 },
            { "8", Keys.NumPad8 },
            { "9", Keys.NumPad9 },
            { "0", Keys.NumPad0 },
            { "gor", Keys.Up },
            { "dol", Keys.Down },
            { "levo", Keys.Left },
            { "desno", Keys.Right },
            { "shift", Keys.Shift },
            { "ctrl", Keys.Control },
            { "alt", Keys.Alt },
            { "tab", Keys.Tab },
            { "enter", Keys.Enter },
            { "space", Keys.Space },
            { "backspace", Keys.Back },
            { "delete", Keys.Delete }
        };
        #endregion

        #region Gumbi
        /// <summary>
        /// Okno se zapre, vnešene vrednosti se izgubijo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preklici_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Preveri, ali so vsi vnešeni ukazi ustrezni. Če niso, sproži napako.
        /// </summary>
        private void Ustrezni_ukazi()
        {
            foreach (TextBox ukaz in new TextBox[] { kladivo, pistola, sablja, konec_orozje, cigaret, kapa, kozarec, lizika, gor, dol })
            {
                // neveljaven ukaz => napaka!
                if (!dovoljeni_ukazi.Keys.Contains(ukaz.Text))
                {
                    MessageBox.Show("Neustrezen vnos podatkov! Prosimo, poskusite ponovno!", "NAPAKA!", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Novo izbrane vrednosti se shranijo (nadomestijo privzete ukaze igre), če so ustrezne. V kolikor niso vse izbrane vrednosti bosdisi črke, bodisi številke, se sproži napaka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shrani_Click(object sender, EventArgs e)
        {
            try
            {
                // tu pričakujemo napako
                Ustrezni_ukazi();

                // poporavimo ukaze v igri
                Pozdrav.spremenljivke.Ukaz_za_orozje(6, sablja.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(1, kapa.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(0, cigaret.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(2, kladivo.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(3, kozarec.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(4, lizika.Text);
                Pozdrav.spremenljivke.Ukaz_za_orozje(5, pistola.Text);

                Pozdrav.spremenljivke.Ukaz_za_premik("gor", gor.Text);
                Pozdrav.spremenljivke.Ukaz_za_premik("dol", dol.Text);

                Pozdrav.spremenljivke.Gumb_za_premik("gor", dovoljeni_ukazi[gor.Text]);
                Pozdrav.spremenljivke.Gumb_za_premik("dol", dovoljeni_ukazi[dol.Text]);

                Pozdrav.spremenljivke.Konec_orozja = konec_orozje.Text;

                Pozdrav.spremenljivke.Konec_uporabe_orozja = dovoljeni_ukazi[konec_orozje.Text];

                foreach (TextBox ukaz in new TextBox[] { kladivo, pistola, sablja, cigaret, kapa, kozarec, lizika })
                {
                    Pozdrav.spremenljivke.Gumb_za_orozje(ukaz.Text, dovoljeni_ukazi[ukaz.Text]);
                }

                // zapremo okno
                Close();
            }
            catch
            {
                Close();
                new Ukazi().Show();
            }
        }
        #endregion
    }
}
