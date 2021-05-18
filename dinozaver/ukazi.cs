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
    public partial class ukazi : Form
    {
        igra dino_igra = pozdrav.dino_igra;

        public ukazi()
        {
            InitializeComponent();
            ponastavi();
        }

        private void ponastavi()
        {
            cigaret.Text = dino_igra.ukaz_za_orozje[0];
            kapa.Text = dino_igra.ukaz_za_orozje[1];
            kladivo.Text = dino_igra.ukaz_za_orozje[2];
            kozarec.Text = dino_igra.ukaz_za_orozje[3];
            lizika.Text = dino_igra.ukaz_za_orozje[4];
            pistola.Text = dino_igra.ukaz_za_orozje[5];
            sablja.Text = dino_igra.ukaz_za_orozje[6];
            gor.Text = dino_igra.ukaz_za_premik["gor"];
            dol.Text = dino_igra.ukaz_za_premik["dol"];
            konec_orozje.Text = dino_igra.konec_orozja;
        }


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
            { "1", Keys.D1 },
            { "2", Keys.D2 },
            { "3", Keys.D3 },
            { "4", Keys.D4 },
            { "5", Keys.D5 },
            { "6", Keys.D6 },
            { "7", Keys.D7 },
            { "8", Keys.D8 },
            { "9", Keys.D9 },
            { "0", Keys.D0 },
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
                dino_igra.ukaz_za_orozje[0] = cigaret.Text;
                dino_igra.ukaz_za_orozje[1] = kapa.Text;
                dino_igra.ukaz_za_orozje[2] = kladivo.Text;
                dino_igra.ukaz_za_orozje[3] = kozarec.Text;
                dino_igra.ukaz_za_orozje[4] = lizika.Text;
                dino_igra.ukaz_za_orozje[5] = pistola.Text;
                dino_igra.ukaz_za_orozje[6] = sablja.Text;

                dino_igra.ukaz_za_premik["gor"] = gor.Text;
                dino_igra.ukaz_za_premik["dol"] = dol.Text;

                dino_igra.konec_orozja = konec_orozje.Text;

                dino_igra.konec_uporabe_orozja = dovoljeni_ukazi[konec_orozje.Text];

                foreach (TextBox ukaz in new TextBox[] { kladivo, pistola, sablja, cigaret, kapa, kozarec, lizika })
                {
                    dino_igra.gumb_za_orozje[ukaz.Text] = dovoljeni_ukazi[ukaz.Text];
                }

                foreach (TextBox ukaz in new TextBox[] { gor, dol })
                {
                    dino_igra.gumb_za_premik[ukaz.Text] = dovoljeni_ukazi[ukaz.Text];
                }

                // zapremo okno
                Close();
            }
            catch
            {
                Close();
                new ukazi().Show();
            }
        }
    }
}
