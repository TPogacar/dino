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
    public partial class Nastavitev : Form
    {
        #region Konstante
        public static string naslov_rezultatov = @"rezultati.txt";
        #endregion

        public Nastavitev()
        {
            // če datoteke s top rezultati še ni, jo ustvari
            if (!File.Exists(naslov_rezultatov))
            {
                StreamWriter dat = File.CreateText(naslov_rezultatov);
                dat.Close();
            }
            // sicer preberemo vrednosti in jih shranimo v slovar `igralec_rezultat`
            else
            {
                using (StreamReader dat = File.OpenText(naslov_rezultatov))
                {
                    string vrstica = "";
                    while ((vrstica = dat.ReadLine()) != null)
                    {
                        // v datoteki so imena igralcev ločena od pripadajočih točk s `;`
                        // v vsaki vrstici je natanko en igralec in en rezultat
                        string[] podatka = vrstica.Split(';');
                        Pozdrav.spremenljivke.Igralec_rezultat(podatka[0], int.Parse(podatka[1]));
                    }
                }
            }            
            InitializeComponent();
        }

        #region Gumbi
        /// <summary>
        /// Želimo igrati proti vsem igralcem. Zapomnimo si ime trenutnega igralca ter poiščemo najboljši rezultat vseh igralcev ter ga spravimo v top_tocke. Nato zapremo trenutno okno in odpremo igro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void da_Click(object sender, EventArgs e)
        {
            Pozdrav.spremenljivke.Ime_igralca = ime.Text;
            Pozdrav.spremenljivke.Top_tocke = Pozdrav.spremenljivke.igralec_rezultat.Values.DefaultIfEmpty(0).Max();
            Pozdrav.spremenljivke.Dosezen_nov_top_rezultat = false;
            Close();
            new igra().Show();
        }

        /// <summary>
        /// Želimo igrati samo proti samemu sebi. Zapomnimo si trenutnega igralca in zapremo trenutno okno. Če je igralec nov, odpremo igro, sicer pa odpremo novo okno, kjer igralca vprašamo, ali želi igrati od začetka ali ne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ne_Click(object sender, EventArgs e)
        {
            Close();
            Pozdrav.spremenljivke.Ime_igralca = ime.Text;
            // že obstoječi igralec => odpremo vprašanje
            if (Pozdrav.spremenljivke.Igralec_rezultat(Pozdrav.spremenljivke.Ime_igralca) != -1)
            {
                new Ponovni_zacetek().Show();
            }
            // avtomatično pričnemo igro
            else
            {
                Pozdrav.spremenljivke.Top_tocke = 0;
                new igra().Show();
            }
        }
        #endregion
    }
}
