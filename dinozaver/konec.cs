using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dinozaver
{
    public partial class Konec : Form
    {
        public Konec()        
        {
            InitializeComponent();
            // prikažemo ustrezen najboljši rezultat
            if (Pozdrav.spremenljivke.Dosezen_nov_top_rezultat)
            {
                rezultat.Text = Pozdrav.spremenljivke.Top_tocke.ToString();                
            }
            else
            {
                rezultat.Text = Pozdrav.spremenljivke.Tocke.ToString();
            }
        }

        #region Gumbi
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

        /// <summary>
        /// Vpraša, ali želimo shraniti igro. Če potrdimo, se rezultat ustrezno zapiše v datoteko z rezultati. Nato se igra zapre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ne_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ali želiš shraniti dosežen rezultat?", "Shranjevanje podatkov", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // shranimo rezultat
                using (StreamWriter dat = File.CreateText(Nastavitev.naslov_rezultatov))
                {
                    bool dodan = false;
                    foreach (KeyValuePair<string, int> igralec in Pozdrav.spremenljivke.igralec_rezultat)
                    {
                        if (igralec.Key != Pozdrav.spremenljivke.Ime_igralca)
                        {
                            dat.WriteLine($"{igralec.Key};{igralec.Value}");
                        }
                        else
                        {
                            if (Pozdrav.spremenljivke.Dosezen_nov_top_rezultat)
                            {
                                dat.WriteLine($"{Pozdrav.spremenljivke.Ime_igralca};{Pozdrav.spremenljivke.Top_tocke}");
                            }
                            else
                            {
                                dat.WriteLine($"{Pozdrav.spremenljivke.Ime_igralca};{Pozdrav.spremenljivke.Tocke}");
                            }
                            dodan = true;
                        }
                    }
                    if (!dodan)
                    {
                        dat.WriteLine($"{Pozdrav.spremenljivke.Ime_igralca};{Pozdrav.spremenljivke.Tocke}");
                    }
                }
            }
            // zapremo vsa okna
            Close();
        }
        #endregion
    }
}
