using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

// vse ukaze daj v svoj razred in se potem v vseh ostalih samo sklicuješ nanje

namespace dinozaver
{
    public partial class igra : Form
    {
        Spremenljivke spremenljivke = pozdrav.spremenljivke;

        const int KDAJ_POVECAMO_HITROST = 10;  // po koliko doseženih točkah se poveča hitrost igre
        bool skok;  // ali igralec skače
        int hitrost_skoka;  // kako hitro skače
        int osnovna_sila;  // koliko se lahko dvigne
        int sila;  // sila skoka
        int HITROST_OVIRE;  // hitrost ovir
        int HITROST_OBLAKA;  // hitrost oblakov
        public bool dosežen_nov_top_rezultat = false;  // če ne tekmujemo od začetka, moramo vedeti, ali smo že presegli prehdonji top rezultat
        int KDAJ_ZAMENJAJ_SLIKO_PTICA = 9;  // na koliko trenutkov premakne krila (mora biti liho število)
        int koliko_trenutkov_ptic;
        int KDAJ_ZAMENJAJ_SLIKO_DINOTA = 5;  // na koliko trenutkov zamenja nogo
        int koliko_trenutkov_dino;

        Random rand = new Random();
        bool konec_igre;  // ali je igra končana
        bool levo_gor;  // dino ima dvignjeno levo nogo
        bool sklonjen;  // ali je dino sklonjen

        Bitmap[] veliki_kaktusi = new Bitmap[] { Properties.Resources.kaktus_velik_1, Properties.Resources.kaktus_velik_2, Properties.Resources.kaktus_velik_3, Properties.Resources.kaktus_velik_4, Properties.Resources.kaktus_velik_5, Properties.Resources.kaktus_velik_6 };
        Bitmap[] mini_kaktusi = new Bitmap[] { Properties.Resources.kaktus_mini_1, Properties.Resources.kaktus_mini_2, Properties.Resources.kaktus_mini_3, Properties.Resources.kaktus_mini_4, Properties.Resources.kaktus_mini_5, Properties.Resources.kaktus_mini_6 };
        Dictionary<int, Bitmap> vsa_orozja = new Dictionary<int, Bitmap>()
        {
            { 0, Properties.Resources.cigaret },
            { 1, Properties.Resources.kapa },
            { 2, Properties.Resources.kladivo },
            { 3, Properties.Resources.kozarec },
            { 4, Properties.Resources.lizika },
            { 5, Properties.Resources.pistola },
            { 6, Properties.Resources.sablja }
        };
        
        int akcija_v_uporabi;  // ali dino lahko uporabi akcijo -> z -1 označimo, da nimamo nobenega orožja na zalogi, sicer katero uporablja
        int st_trenutna_akcija;
        int st_prihajajoca_akcija;

        // ----------------------------------------------------------------------------------------------------------------------

        public igra()
        {
            InitializeComponent();
            ponastavi_igro();
        }

        /// <summary>
        /// Kaj se zgodi, ko pritisnemo na nek gumb (presledek => skok).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pritisnjen(object sender, KeyEventArgs e)
        {
            // če trenutno ne skače, je na tleh in pritisne presledek ali puščica navzgor => skoči
            if (e.KeyCode == spremenljivke.Gumb_za_premik("gor") && !skok && dino.Bounds.IntersectsWith(tla.Bounds) && !konec_igre)
            {
                skok = true;
                dino.Image = Properties.Resources.dino_stoji;
            }
            // če trenutno ne skače, je na tleh in pritisne puščico navzdol => se skloni
            if (e.KeyCode == spremenljivke.Gumb_za_premik("dol") && !skok && !sklonjen && dino.Bounds.IntersectsWith(tla.Bounds) && !konec_igre)
            {
                dino.Image = Properties.Resources.dino_dol_leva;
                sklonjen = true;
                levo_gor = true;
                dino.Width = 46;
                dino.Height = 26;
                dino.Top += 46 - 36;
                orozje_spodaj.Top += 1;
                orozje_sredina.Top += 5;
                orozje_sredina.Left += 10;
                orozje_gor.Top += 5;
                orozje_gor.Left += 10;
                dino_z_dodatki.Top += 5;
            }
            // če trenutno ni konec igre in ima akcijo na zalogi, lahko uporabi orožje
            if (!konec_igre && st_trenutna_akcija >= 0)
            {
                // cigaret
                if (e.KeyCode == spremenljivke.Gumb_za_orozje("cigaret"))
                {
                    // nastavimo ozadja orožij
                    orozje_gor.Image = null;
                    orozje_sredina.Image = vsa_orozja[st_trenutna_akcija];
                    orozje_spodaj.Image = null;
                    akcija_v_uporabi = st_trenutna_akcija;
                    st_trenutna_akcija = -1;
                    
                    orozje_ukaz.Text = "";
                    orozje_ukaz_slika.Image = null;
                }

                // kapa
                else if (e.KeyCode == spremenljivke.Gumb_za_orozje("kapa"))
                {
                    orozje_gor.Image = vsa_orozja[st_trenutna_akcija];
                    orozje_sredina.Image = null;
                    orozje_spodaj.Image = null;
                    akcija_v_uporabi = st_trenutna_akcija;
                    st_trenutna_akcija = -1;

                    orozje_ukaz.Text = "";
                    orozje_ukaz_slika.Image = null;
                }

                // ostalo - dino drži v rokah eno od ostalih dodatkov
                else if (spremenljivke.gumb_za_orozje.Values.Contains(e.KeyCode) && !new Keys[] { spremenljivke.Gumb_za_orozje("kapa"), spremenljivke.Gumb_za_orozje("cigaret") }.Contains(e.KeyCode))
                {
                    orozje_gor.Image = null;
                    orozje_sredina.Image = null;
                    orozje_spodaj.Image = vsa_orozja[st_trenutna_akcija];
                    akcija_v_uporabi = st_trenutna_akcija;
                    st_trenutna_akcija = -1;

                    orozje_ukaz.Text = "";
                    orozje_ukaz_slika.Image = null;
                }                
            }
            // ne želimo več uporabljati orožja
            if (!konec_igre && e.KeyCode == spremenljivke.Konec_uporabe_orozja && akcija_v_uporabi >= 0)
            {
                orozje_gor.Image = null;
                orozje_sredina.Image = null;
                orozje_spodaj.Image = null;
                akcija_v_uporabi = -1;
            }

            Zdruzi_dinota_z_orozji();
        }

        /// <summary>
        /// Kaj se zgodi, če pritisnemo in spustimo nek gumb (R => ponastavimo igro).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spuscen(object sender, KeyEventArgs e)
        {
            // -----------------------------------------------------------------------------------------------------------------------------
            if (e.KeyCode == Keys.R && konec_igre)  // R? -----------------------------------------------------------------------------------
            {
                // če pritisnemo in spustimo R, se igra ponastavi
                // samo ob koncu igre
                ponastavi_igro();
            }
            // ----------------------------------------------------------------------------------------------------------------------------
            if (skok && !konec_igre)
            {
                // ko je gumb spuščen, preverimo, ali skačemo
                // če skačemo, moramo nastaviti skok = false, da lahko igralec ponovno skoči
                skok = false;
                dino.Image = Properties.Resources.dino_leva;
                levo_gor = true;
            }

            if (sklonjen && !konec_igre)
            {
                sklonjen = false;
                levo_gor = true;
                dino.Image = Properties.Resources.dino_leva;
                dino.Width = 36;
                dino.Height = 39;
                dino.Top += 36 - 46;
                orozje_spodaj.Top -= 13;
                orozje_sredina.Top -= 17;
                orozje_sredina.Left -= 10;
                orozje_gor.Top -= 17;
                orozje_gor.Left -= 10;
                dino_z_dodatki.Top -= 17;
            }

            Zdruzi_dinota_z_orozji();
        }

        /// <summary>
        /// Poskrbi, da se ovira x ne bo prekrivala z nobeno drugo oviro.
        /// </summary>
        /// <param name="x">dana ovira</param>
        private void Nastavi_polozaj_ovire(Control x)
        {
            // poskrbimo, da se ne prekriva z drugimi ovirami
            while (true)
            {
                bool ni_prekrivanja = true;
                foreach (Control y in this.Controls)
                {
                    if (x is PictureBox && new PictureBox[] { ptic1, ptic2, ptic3, kaktus_mini, kaktus_velik, luknja }.Contains(y) && x.Bounds.IntersectsWith(y.Bounds) && x.Name != y.Name)
                    {
                        // trenutna ovira se prekriva z neko drugo
                        x.Left += rand.Next(20, 200);
                        ni_prekrivanja = false;
                    }
                }
                if (ni_prekrivanja)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Združi sliko dinota in potencialnih orožij.
        /// </summary>
        private void Zdruzi_dinota_z_orozji()
        {
            Bitmap bitmap = new Bitmap(dino_z_dodatki.Width, dino_z_dodatki.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // napake, ki se pojavijo, so nerelevantne (zato jih ne "lovimo")
                // napake so izključno, ker imamo največ eno ozožje naenkrat => le ena slika orožij ni `null`
                g.DrawImage(dino.Image, dino.Location.X - dino_z_dodatki.Location.X, dino.Location.Y - dino_z_dodatki.Location.Y, dino.Width, dino.Height);
                try
                {
                    g.DrawImage(orozje_gor.Image, orozje_gor.Location.X - dino_z_dodatki.Location.X, orozje_gor.Location.Y - dino_z_dodatki.Location.Y, orozje_gor.Width, orozje_gor.Height);
                }
                catch { }
                try
                {
                    g.DrawImage(orozje_spodaj.Image, orozje_spodaj.Location.X - dino_z_dodatki.Location.X, orozje_spodaj.Location.Y - dino_z_dodatki.Location.Y, orozje_spodaj.Width, orozje_spodaj.Height);
                }
                catch { }
                try
                {
                    g.DrawImage(orozje_sredina.Image, orozje_sredina.Location.X - dino_z_dodatki.Location.X, orozje_sredina.Location.Y - dino_z_dodatki.Location.Y, orozje_sredina.Width, orozje_sredina.Height);
                }                    
                catch { }                
            }
            dino_z_dodatki.Image = bitmap;
        }

        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Ta metoda ponastavi igro.
        /// </summary>
        public void ponastavi_igro()
        {
            // nastavimo privzete vrednosti
            sila = osnovna_sila;
            hitrost_skoka = 0;
            skok = false;
            osnovna_sila = 15;
            HITROST_OVIRE = 9;
            HITROST_OBLAKA = 1;
            spremenljivke.Tocke = 0; // morda ob koncu? --------------------------------------------------------------------------
            Tocke.Text = $"Točke: {spremenljivke.Tocke}";
            Top_tocke.Text = $"Najboljši rezultat: {spremenljivke.Top_tocke}";
            konec_igre = false;
            dino.Image = Properties.Resources.dino_leva;  // slika živega dinozavra
            dino.Top = tla.Top - dino.Height + 1;  // dinozavra postavimo na vrh tal (malo se prekrivata => da omejimo skoke)
            dino.Width = 36;
            dino.Height = 39;
            dino.Top += 36 - 46;
            orozje_spodaj.Top = dino.Top + 5;
            orozje_spodaj.Left = dino.Left + 20;
            orozje_sredina.Top = dino.Top - 2;
            orozje_sredina.Left = dino.Left + 25;
            orozje_gor.Top = dino.Top - 15;
            orozje_gor.Left = dino.Left + 17;
            dino_z_dodatki.Top = tla.Top - dino.Height - orozje_gor.Height + 5;
            levo_gor = true;
            sklonjen = false;
            koliko_trenutkov_ptic = KDAJ_ZAMENJAJ_SLIKO_PTICA;
            koliko_trenutkov_dino = KDAJ_ZAMENJAJ_SLIKO_DINOTA;
            orozje_ukaz_slika.Image = null;
            orozje_ukaz.Text = "";
            orozje_spodaj.Image = Properties.Resources.prosojno;
            orozje_spodaj.BackColor = Color.Transparent;
            orozje_sredina.Image = Properties.Resources.prosojno;
            orozje_sredina.BackColor = Color.Transparent;
            orozje_gor.Image = Properties.Resources.prosojno;
            orozje_gor.BackColor = Color.Transparent;
            akcija_v_uporabi = -1;
            st_trenutna_akcija = -1;
            igralec.Text = $"IGRALEC: {spremenljivke.ime_igralca} {spremenljivke.Gumb_za_premik("gor")} {spremenljivke.Gumb_za_premik("dol")}";

            // združimo slike dinota in potencialnih orožij
            Zdruzi_dinota_z_orozji();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    // zanimajo nas samo slike
                    if ((x.Tag ?? "").ToString() == "kaktus")  // da ne javlja potencialne napake, levo stran pretvorimo v niz
                    {
                        // x je slika ovire 
                        // generiramo naključno število, ki bo določalo položaj ovire
                        int polozaj = rand.Next(5, 500);
                        // oviro prestavimo v desno
                        x.Left += this.Width + polozaj;

                        // poskrbimo, da se ne prekriva z drugimi ovirami
                        Nastavi_polozaj_ovire(x);

                        // določimo sliko
                        if (x.Name == "kaktus_mini")
                        {
                            kaktus_mini.Image = mini_kaktusi[rand.Next(0, mini_kaktusi.Count())];
                        }
                        if (x.Name == "kaktus_velik")
                        {
                            kaktus_velik.Image = veliki_kaktusi[rand.Next(0, veliki_kaktusi.Count())];
                        }
                    }
                    else if ((x.Tag ?? "").ToString() == "ptic")
                    {
                        // ptiči se pojavijo občutno kasneje
                        x.Left += this.Width + rand.Next(6000, 10000);
                        Nastavi_polozaj_ovire(x);
                    }
                    else if ((x.Tag ?? "").ToString() == "oblak")
                    {
                        x.Left += this.Width + rand.Next(1, 50);
                    }
                    else if ((x.Tag ?? "").ToString() == "luknja")
                    {
                        x.Left += this.Width + rand.Next(500, 1000);
                        Nastavi_polozaj_ovire(x);
                    }
                    else if ((x.Tag ?? "").ToString() == "orozje")
                    {
                        if (x.Name == "akcija")
                        {
                            // akcije se pojavijo kasneje - orožja so za boljše igralce
                            x.Left += this.Width + rand.Next(3000, 6000);
                            st_prihajajoca_akcija = rand.Next(0, vsa_orozja.Count());
                            akcija.Image = vsa_orozja[st_prihajajoca_akcija];
                        }
                        if (new string[] {"orozje_gor", "orozje_spodaj", "orozje_sredina"}.Contains(x.Name))
                        {
                            x.BackgroundImage = Properties.Resources.prosojno;
                        }
                    }
                }                
            }
            // začnemo igro
            stoparca.Start();
        }

        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Metoda, ki definira sam potek igre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void igra_cas(object sender, EventArgs e)
        {
            // hitrost skoka povežemo z dinotom in orožjem, ki ga drži
            dino.Top += hitrost_skoka;
            orozje_spodaj.Top += hitrost_skoka;
            orozje_sredina.Top += hitrost_skoka;
            orozje_gor.Top += hitrost_skoka;
            dino_z_dodatki.Top += hitrost_skoka;
            // hitrost ovir povežemo z akcijo
            akcija.Left -= HITROST_OVIRE;

            // prikažemo rezultata
            Tocke.Text = $"Točke: {spremenljivke.Tocke}";
            Top_tocke.Text = $"Najboljši rezultat: {spremenljivke.Top_tocke}";

            // ustrezno nastavimo vrednosti skoka in sile
            if (skok && sila < 0)
            {
                skok = false;
            }

            if (skok)
            {
                // na dnu skoka => mora skočiti
                hitrost_skoka = -12;
                sila -= 1;
                skok = true;
            }
            else
            {
                // pada
                hitrost_skoka = 12;
                skok = false;
            }

            // zamenjamo sličico dinota
            koliko_trenutkov_dino -= 1;
            if (koliko_trenutkov_dino <= 0)
            {
                if (sklonjen)
                {
                    if (levo_gor)
                    {
                        dino.Image = Properties.Resources.dino_dol_desna;
                    }
                    else
                    {
                        dino.Image = Properties.Resources.dino_dol_leva;
                    }
                }
                else if (!sklonjen && !skok) // hodi
                {
                    if (levo_gor)
                    {
                        dino.Image = Properties.Resources.dino_desna;
                    }
                    else
                    {
                        dino.Image = Properties.Resources.dino_leva;
                    }
                }
                koliko_trenutkov_dino = KDAJ_ZAMENJAJ_SLIKO_DINOTA;
            }
            // zamenjamo sličico ptiča
            koliko_trenutkov_ptic -= 1;
            foreach (PictureBox ptic in new PictureBox[] { ptic1, ptic2, ptic3 })
            {
                if (koliko_trenutkov_ptic <= 0)
                {
                    if (levo_gor)
                    {
                        ptic.Image = Properties.Resources.ptic_gor;
                    }
                    else
                    {
                        ptic.Image = Properties.Resources.ptic_dol;
                    }
                }                
            }
            if (koliko_trenutkov_ptic <= 0)
            {
                koliko_trenutkov_ptic = KDAJ_ZAMENJAJ_SLIKO_PTICA;
            }
            levo_gor = !levo_gor;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    // x je slika ovire
                    if (new string[] { "kaktus", "ptic", "luknja" }.Contains(x.Tag))
                    {
                        // x se premika v levo (proti dinotu) s hitrostjo ovire
                        x.Left -= HITROST_OVIRE;

                        // ovire ni več na zaslonu => prestavimo jo daleč na desno, da se bo lahko ponovno pojavila
                        if (x.Left + x.Width < -100)
                        {                            
                            x.Left = this.Width + rand.Next(200, 1000);
                            // poskrbimo, da se ne prekriva z ostalimi ovirami
                            Nastavi_polozaj_ovire(x);

                            // premagali smo oviro
                            spremenljivke.Top_tocke = ++spremenljivke.Tocke;
                            if (x.Name == "kaktus_mini")
                            {
                                kaktus_mini.Image = mini_kaktusi[rand.Next(0, mini_kaktusi.Count())];
                            }
                            if (x.Name == "kaktus_velik")
                            {
                                kaktus_velik.Image = veliki_kaktusi[rand.Next(0, veliki_kaktusi.Count())];
                            }
                        }
                        // dino zadane oviro
                        // ima orožje => ne umre, razen lahko pade v luknjo
                        // zadeli smo oviro (in nimamo ustreznega orožja) => konec igre
                        if (dino.Bounds.IntersectsWith(x.Bounds) && (!new int[] { 2, 5, 6, 7 }.Contains(akcija_v_uporabi) || x.Name == "luknja"))
                        {
                            // dino umre
                            stoparca.Stop();
                            dino.Image = Properties.Resources.dino_mrtev;
                            dino.Width = 36;
                            dino.Height = 39;
                            konec_igre = true;
                            Zdruzi_dinota_z_orozji();
                            // prikažemo okno, z možnostmi nadaljevanja
                            new konec().Show();
                            Close();
                            // -------------------------------------------------------------------------------------------------------------
                        }
                    }
                    else if ((x.Tag ?? "").ToString() == "oblak")
                    {
                        x.Left -= HITROST_OBLAKA;
                        // ko oblak pride do konca, ga prestavimo nekam pred začetek (desno)
                        if (x.Left + x.Width < -100)
                        {
                            // oblaki se lahko prekrivajo
                            x.Left = this.Width + rand.Next(5, 20);
                        }
                    }
                    // dino prejme orožje
                    else if ((x.Tag ?? "").ToString() == "orozje")
                    {
                        // dino je prejel akcijo => pojavi se "navodilo" za uporabo akcije
                        if (dino.Bounds.IntersectsWith(akcija.Bounds) && !new string[] { "orozje_gor", "orozje_sredina", "orozje_spodaj" }.Contains(x.Name))
                        {
                            st_trenutna_akcija = st_prihajajoca_akcija;
                                                        
                            // slika akcije za navodilo
                            orozje_ukaz_slika.Image = vsa_orozja[st_trenutna_akcija];
                            // pripadajoča črka za navodilo ukaza
                            orozje_ukaz.Text = spremenljivke.Ukaz_za_orozje(st_trenutna_akcija);

                            // nastavimo novo akcijo nekje na desni
                            st_prihajajoca_akcija = rand.Next(0, vsa_orozja.Count());
                            akcija.Image = vsa_orozja[st_prihajajoca_akcija];
                            x.Left += this.Width + rand.Next(1000, 4000);
                        }
                        // akcija je že izven zaslona
                        else if (x.Left + x.Width < -100)
                        {
                            x.Left = this.Width + rand.Next(500, 3000);
                            st_prihajajoca_akcija = rand.Next(0, vsa_orozja.Count());
                            akcija.Image = vsa_orozja[st_prihajajoca_akcija];
                        }
                    }
                }                              
            }

            if (dino.Top >= tla.Top - dino.Height && !skok)
            {
                // dino je pristal (konec skoka)
                sila = osnovna_sila;
                dino.Top = tla.Top - dino.Height + 1;
                hitrost_skoka = 0;
            }

            if (spremenljivke.Tocke == KDAJ_POVECAMO_HITROST)
            {
                // igralec se je ogrel => povečamo hitrost
                HITROST_OVIRE = 13;
                KDAJ_ZAMENJAJ_SLIKO_DINOTA = 3;
                KDAJ_ZAMENJAJ_SLIKO_PTICA = 7;
            }

            // združimo slike dinota in potencialnih orožij
            Zdruzi_dinota_z_orozji();
        }
    }
}