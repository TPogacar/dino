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
    public partial class pozdrav : Form
    {
        public static Spremenljivke spremenljivke;

        public pozdrav()
        {
            InitializeComponent();
            spremenljivke = new Spremenljivke();
        }

        /// <summary>
        /// Odpre stran za nastavljanje ukaznih tipk, trenutne ne zapre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nastavi_ukaze_Click(object sender, EventArgs e)
        {
            new ukazi().Show();
        }

        /// <summary>
        /// Odpre nastavitve igre in hkrati zapre pozdravno okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zacni_Click(object sender, EventArgs e)
        {
            new nastavitev().Show();
        }
    }
}
