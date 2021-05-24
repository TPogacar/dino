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
    public partial class ponovni_zacetek : Form
    {
        Spremenljivke spremenljivke = pozdrav.spremenljivke;

        public ponovni_zacetek()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Samo odpre igro in zapre trenutno okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void da_Click(object sender, EventArgs e)
        {
            Close();
            igra dino_igra = new igra();
            dino_igra.Show();
        }

        // Nastavi top_tocke na točke trenutnega igralca, zapre zrenutno okno in odpre okno igro.
        private void ne_Click(object sender, EventArgs e)
        {
            spremenljivke.Top_tocke = spremenljivke.igralec_rezultat[spremenljivke.ime_igralca];
            Close();
            igra dino_igra = new igra();
            dino_igra.Show();
        }
    }
}
