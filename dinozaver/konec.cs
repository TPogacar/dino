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
    public partial class konec : Form
    {
        Spremenljivke spremenljivke = pozdrav.spremenljivke;

        public konec()        
        {
            InitializeComponent();
            // prikažemo ustrezen najboljši rezultat
            if (spremenljivke.dosežen_nov_top_rezultat)
            {
                rezultat.Text = spremenljivke.Top_tocke.ToString();                
            }
            else
            {
                rezultat.Text = spremenljivke.Tocke.ToString();
            }
        }

        /// <summary>
        /// Zapre trenutno okno in ponovno odpre igro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void da_Click(object sender, EventArgs e)
        {
            Close();
            new igra().Show();
        }

        private void ne_Click(object sender, EventArgs e)
        {

        }
    }
}
