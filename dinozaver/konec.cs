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
        igra dino_igra = pozdrav.dino_igra;

        public konec()        
        {
            // prikažemo ustrezen najboljši rezultat
            //if (dosežen_nov_top_rezultat)
            //{
            //    try
            //    {
            //        rezultat.Text = igra().top_tocke.ToString();
            //    }
            //    catch
            //    {
            //        // okno igre smo že zaprli => podatki so se izgubili
            //        rezultat.Text = "ERROR";
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        rezultat.Text = new igra().tocke.ToString();
            //    }
            //    catch
            //    {
            //        // okno igre smo že zaprli => podatki so se izgubili
            //        rezultat.Text = "ERROR";
            //    }

            //}

            InitializeComponent();
        }

        /// <summary>
        /// Zapre trenutno okno in ponovno odpre igro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void da_Click(object sender, EventArgs e)
        {
            Close();
            dino_igra.ponastavi_igro();
        }

        private void ne_Click(object sender, EventArgs e)
        {

        }
    }
}
