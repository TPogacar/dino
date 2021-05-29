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
    public partial class Pozdrav : Form
    {
        #region Konstante
        public static Spremenljivke spremenljivke;
        #endregion

        public Pozdrav()
        {
            InitializeComponent();
            spremenljivke = new Spremenljivke();
        }

        #region Gumbi
        /// <summary>
        /// Odpre stran za nastavljanje ukaznih tipk, trenutne ne zapre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nastavi_ukaze_Click(object sender, EventArgs e)
        {
            new Ukazi().Show();
        }

        /// <summary>
        /// Odpre nastavitve igre in hkrati zapre pozdravno okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zacni_Click(object sender, EventArgs e)
        {
            new Nastavitev().Show();
        }
        #endregion
    }
}
