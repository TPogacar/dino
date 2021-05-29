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
    public partial class Ponovni_zacetek : Form
    {
        public Ponovni_zacetek()
        {
            InitializeComponent();
        }

        #region Gumbi
        /// <summary>
        /// Samo odpre igro in zapre trenutno okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void da_Click(object sender, EventArgs e)
        {
            Close();
            new igra().Show();
        }

        // Nastavi top_tocke na točke trenutnega igralca, zapre zrenutno okno in odpre okno igro.
        private void ne_Click(object sender, EventArgs e)
        {
            Pozdrav.spremenljivke.Top_tocke = Pozdrav.spremenljivke.Igralec_rezultat(Pozdrav.spremenljivke.Ime_igralca);
            Pozdrav.spremenljivke.Dosezen_nov_top_rezultat = false;
            Close();
            new igra().Show();
        }
        #endregion
    }
}
