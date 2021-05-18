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
        igra dino_igra = pozdrav.dino_igra;

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
            dino_igra.Show();
            dino_igra.ponastavi_igro();
        }

        // Nastavi top_tocke na točke trenutnega igralca, zapre zrenutno okno in odpre okno igro.
        private void ne_Click(object sender, EventArgs e)
        {
            dino_igra.top_tocke = dino_igra.igralec_rezultat[dino_igra.ime_igralca];
            Close();
            dino_igra.Show();
            dino_igra.ponastavi_igro();
        }
    }
}
