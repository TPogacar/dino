
namespace dinozaver
{
    partial class igra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tocke = new System.Windows.Forms.Label();
            this.stoparca = new System.Windows.Forms.Timer(this.components);
            this.top_tocke = new System.Windows.Forms.Label();
            this.orozje_spodaj = new System.Windows.Forms.PictureBox();
            this.luknja = new System.Windows.Forms.PictureBox();
            this.tla = new System.Windows.Forms.PictureBox();
            this.dino = new System.Windows.Forms.PictureBox();
            this.oblak_1 = new System.Windows.Forms.PictureBox();
            this.oblak_2 = new System.Windows.Forms.PictureBox();
            this.oblak_3 = new System.Windows.Forms.PictureBox();
            this.ptic3 = new System.Windows.Forms.PictureBox();
            this.ptic2 = new System.Windows.Forms.PictureBox();
            this.ptic1 = new System.Windows.Forms.PictureBox();
            this.kaktus_mini = new System.Windows.Forms.PictureBox();
            this.kaktus_velik = new System.Windows.Forms.PictureBox();
            this.orozje_ukaz_slika = new System.Windows.Forms.PictureBox();
            this.orozje_ukaz = new System.Windows.Forms.Label();
            this.akcija = new System.Windows.Forms.PictureBox();
            this.orozje_sredina = new System.Windows.Forms.PictureBox();
            this.orozje_gor = new System.Windows.Forms.PictureBox();
            this.dino_z_dodatki = new System.Windows.Forms.PictureBox();
            this.igralec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_spodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luknja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus_velik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_ukaz_slika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_sredina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_gor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino_z_dodatki)).BeginInit();
            this.SuspendLayout();
            // 
            // tocke
            // 
            this.tocke.AutoSize = true;
            this.tocke.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tocke.Location = new System.Drawing.Point(12, 50);
            this.tocke.Name = "tocke";
            this.tocke.Size = new System.Drawing.Size(116, 28);
            this.tocke.TabIndex = 5;
            this.tocke.Text = "Točke: 0";
            // 
            // stoparca
            // 
            this.stoparca.Interval = 25;
            this.stoparca.Tick += new System.EventHandler(this.igra_cas);
            // 
            // top_tocke
            // 
            this.top_tocke.AutoSize = true;
            this.top_tocke.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.top_tocke.Location = new System.Drawing.Point(12, 9);
            this.top_tocke.Name = "top_tocke";
            this.top_tocke.Size = new System.Drawing.Size(285, 28);
            this.top_tocke.TabIndex = 6;
            this.top_tocke.Text = "Najboljši rezultat: 0";
            // 
            // orozje_spodaj
            // 
            this.orozje_spodaj.BackColor = System.Drawing.Color.Maroon;
            this.orozje_spodaj.Location = new System.Drawing.Point(127, 299);
            this.orozje_spodaj.Name = "orozje_spodaj";
            this.orozje_spodaj.Size = new System.Drawing.Size(28, 26);
            this.orozje_spodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orozje_spodaj.TabIndex = 15;
            this.orozje_spodaj.TabStop = false;
            this.orozje_spodaj.Tag = "orozje";
            // 
            // luknja
            // 
            this.luknja.BackColor = System.Drawing.Color.White;
            this.luknja.Location = new System.Drawing.Point(421, 328);
            this.luknja.Name = "luknja";
            this.luknja.Size = new System.Drawing.Size(89, 15);
            this.luknja.TabIndex = 14;
            this.luknja.TabStop = false;
            this.luknja.Tag = "luknja";
            // 
            // tla
            // 
            this.tla.BackColor = System.Drawing.Color.SlateGray;
            this.tla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tla.Location = new System.Drawing.Point(-15, 331);
            this.tla.Name = "tla";
            this.tla.Size = new System.Drawing.Size(840, 179);
            this.tla.TabIndex = 0;
            this.tla.TabStop = false;
            // 
            // dino
            // 
            this.dino.Image = global::dinozaver.Properties.Resources.dino_stoji;
            this.dino.Location = new System.Drawing.Point(98, 289);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(40, 43);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dino.TabIndex = 4;
            this.dino.TabStop = false;
            // 
            // oblak_1
            // 
            this.oblak_1.Image = global::dinozaver.Properties.Resources.oblak;
            this.oblak_1.Location = new System.Drawing.Point(677, 21);
            this.oblak_1.Name = "oblak_1";
            this.oblak_1.Size = new System.Drawing.Size(77, 31);
            this.oblak_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oblak_1.TabIndex = 13;
            this.oblak_1.TabStop = false;
            this.oblak_1.Tag = "oblak";
            // 
            // oblak_2
            // 
            this.oblak_2.Image = global::dinozaver.Properties.Resources.oblak;
            this.oblak_2.Location = new System.Drawing.Point(300, 119);
            this.oblak_2.Name = "oblak_2";
            this.oblak_2.Size = new System.Drawing.Size(77, 31);
            this.oblak_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oblak_2.TabIndex = 12;
            this.oblak_2.TabStop = false;
            this.oblak_2.Tag = "oblak";
            // 
            // oblak_3
            // 
            this.oblak_3.Image = global::dinozaver.Properties.Resources.oblak;
            this.oblak_3.Location = new System.Drawing.Point(88, 139);
            this.oblak_3.Name = "oblak_3";
            this.oblak_3.Size = new System.Drawing.Size(77, 31);
            this.oblak_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oblak_3.TabIndex = 11;
            this.oblak_3.TabStop = false;
            this.oblak_3.Tag = "oblak";
            // 
            // ptic3
            // 
            this.ptic3.Image = global::dinozaver.Properties.Resources.ptic_gor;
            this.ptic3.Location = new System.Drawing.Point(256, 267);
            this.ptic3.Name = "ptic3";
            this.ptic3.Size = new System.Drawing.Size(41, 30);
            this.ptic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptic3.TabIndex = 10;
            this.ptic3.TabStop = false;
            this.ptic3.Tag = "ptic";
            // 
            // ptic2
            // 
            this.ptic2.Image = global::dinozaver.Properties.Resources.ptic_dol;
            this.ptic2.Location = new System.Drawing.Point(553, 87);
            this.ptic2.Name = "ptic2";
            this.ptic2.Size = new System.Drawing.Size(41, 32);
            this.ptic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptic2.TabIndex = 8;
            this.ptic2.TabStop = false;
            this.ptic2.Tag = "ptic";
            // 
            // ptic1
            // 
            this.ptic1.Image = global::dinozaver.Properties.Resources.ptic_dol;
            this.ptic1.Location = new System.Drawing.Point(391, 33);
            this.ptic1.Name = "ptic1";
            this.ptic1.Size = new System.Drawing.Size(34, 25);
            this.ptic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptic1.TabIndex = 7;
            this.ptic1.TabStop = false;
            this.ptic1.Tag = "ptic";
            // 
            // kaktus_mini
            // 
            this.kaktus_mini.BackColor = System.Drawing.Color.Transparent;
            this.kaktus_mini.Image = global::dinozaver.Properties.Resources.kaktus_mini_6;
            this.kaktus_mini.Location = new System.Drawing.Point(370, 289);
            this.kaktus_mini.Name = "kaktus_mini";
            this.kaktus_mini.Size = new System.Drawing.Size(27, 46);
            this.kaktus_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaktus_mini.TabIndex = 3;
            this.kaktus_mini.TabStop = false;
            this.kaktus_mini.Tag = "kaktus";
            // 
            // kaktus_velik
            // 
            this.kaktus_velik.BackColor = System.Drawing.Color.Transparent;
            this.kaktus_velik.Image = global::dinozaver.Properties.Resources.kaktus_velik_3;
            this.kaktus_velik.Location = new System.Drawing.Point(553, 267);
            this.kaktus_velik.Name = "kaktus_velik";
            this.kaktus_velik.Size = new System.Drawing.Size(41, 65);
            this.kaktus_velik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaktus_velik.TabIndex = 2;
            this.kaktus_velik.TabStop = false;
            this.kaktus_velik.Tag = "kaktus";
            // 
            // orozje_ukaz_slika
            // 
            this.orozje_ukaz_slika.BackColor = System.Drawing.Color.Transparent;
            this.orozje_ukaz_slika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orozje_ukaz_slika.Image = global::dinozaver.Properties.Resources.sablja;
            this.orozje_ukaz_slika.Location = new System.Drawing.Point(17, 87);
            this.orozje_ukaz_slika.Name = "orozje_ukaz_slika";
            this.orozje_ukaz_slika.Size = new System.Drawing.Size(46, 41);
            this.orozje_ukaz_slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orozje_ukaz_slika.TabIndex = 16;
            this.orozje_ukaz_slika.TabStop = false;
            this.orozje_ukaz_slika.Tag = "orozje";
            // 
            // orozje_ukaz
            // 
            this.orozje_ukaz.AutoSize = true;
            this.orozje_ukaz.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orozje_ukaz.Location = new System.Drawing.Point(69, 91);
            this.orozje_ukaz.Name = "orozje_ukaz";
            this.orozje_ukaz.Size = new System.Drawing.Size(0, 28);
            this.orozje_ukaz.TabIndex = 18;
            this.orozje_ukaz.Tag = "orozje";
            // 
            // akcija
            // 
            this.akcija.BackColor = System.Drawing.Color.Transparent;
            this.akcija.Image = global::dinozaver.Properties.Resources.pistola;
            this.akcija.Location = new System.Drawing.Point(411, 181);
            this.akcija.Name = "akcija";
            this.akcija.Size = new System.Drawing.Size(30, 30);
            this.akcija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.akcija.TabIndex = 19;
            this.akcija.TabStop = false;
            this.akcija.Tag = "orozje";
            // 
            // orozje_sredina
            // 
            this.orozje_sredina.BackColor = System.Drawing.Color.Tan;
            this.orozje_sredina.Location = new System.Drawing.Point(134, 286);
            this.orozje_sredina.Name = "orozje_sredina";
            this.orozje_sredina.Size = new System.Drawing.Size(22, 19);
            this.orozje_sredina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orozje_sredina.TabIndex = 20;
            this.orozje_sredina.TabStop = false;
            this.orozje_sredina.Tag = "orozje";
            // 
            // orozje_gor
            // 
            this.orozje_gor.BackColor = System.Drawing.Color.Cyan;
            this.orozje_gor.Location = new System.Drawing.Point(114, 278);
            this.orozje_gor.Name = "orozje_gor";
            this.orozje_gor.Size = new System.Drawing.Size(24, 22);
            this.orozje_gor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orozje_gor.TabIndex = 21;
            this.orozje_gor.TabStop = false;
            this.orozje_gor.Tag = "orozje";
            // 
            // dino_z_dodatki
            // 
            this.dino_z_dodatki.BackColor = System.Drawing.Color.Transparent;
            this.dino_z_dodatki.Location = new System.Drawing.Point(98, 278);
            this.dino_z_dodatki.Name = "dino_z_dodatki";
            this.dino_z_dodatki.Size = new System.Drawing.Size(67, 55);
            this.dino_z_dodatki.TabIndex = 22;
            this.dino_z_dodatki.TabStop = false;
            // 
            // igralec
            // 
            this.igralec.AutoSize = true;
            this.igralec.BackColor = System.Drawing.Color.SlateGray;
            this.igralec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.igralec.Location = new System.Drawing.Point(12, 404);
            this.igralec.Name = "igralec";
            this.igralec.Size = new System.Drawing.Size(104, 25);
            this.igralec.TabIndex = 23;
            this.igralec.Text = "IGRALEC:";
            // 
            // igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.igralec);
            this.Controls.Add(this.luknja);
            this.Controls.Add(this.tla);
            this.Controls.Add(this.dino_z_dodatki);
            this.Controls.Add(this.akcija);
            this.Controls.Add(this.ptic3);
            this.Controls.Add(this.ptic2);
            this.Controls.Add(this.ptic1);
            this.Controls.Add(this.kaktus_mini);
            this.Controls.Add(this.kaktus_velik);
            this.Controls.Add(this.orozje_spodaj);
            this.Controls.Add(this.orozje_gor);
            this.Controls.Add(this.orozje_sredina);
            this.Controls.Add(this.orozje_ukaz);
            this.Controls.Add(this.orozje_ukaz_slika);
            this.Controls.Add(this.top_tocke);
            this.Controls.Add(this.tocke);
            this.Controls.Add(this.oblak_1);
            this.Controls.Add(this.oblak_2);
            this.Controls.Add(this.oblak_3);
            this.Controls.Add(this.dino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "igra";
            this.Tag = "";
            this.Text = "Moj dinozaver";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pritisnjen);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spuscen);
            ((System.ComponentModel.ISupportInitialize)(this.orozje_spodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luknja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus_velik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_ukaz_slika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_sredina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orozje_gor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino_z_dodatki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tla;
        private System.Windows.Forms.PictureBox kaktus_velik;
        private System.Windows.Forms.PictureBox kaktus_mini;
        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.Label tocke;
        private System.Windows.Forms.Timer stoparca;
        private System.Windows.Forms.Label top_tocke;
        private System.Windows.Forms.PictureBox ptic1;
        private System.Windows.Forms.PictureBox ptic2;
        private System.Windows.Forms.PictureBox ptic3;
        private System.Windows.Forms.PictureBox oblak_3;
        private System.Windows.Forms.PictureBox oblak_2;
        private System.Windows.Forms.PictureBox oblak_1;
        private System.Windows.Forms.PictureBox luknja;
        private System.Windows.Forms.PictureBox orozje_spodaj;
        private System.Windows.Forms.PictureBox orozje_ukaz_slika;
        private System.Windows.Forms.Label orozje_ukaz;
        private System.Windows.Forms.PictureBox akcija;
        private System.Windows.Forms.PictureBox orozje_sredina;
        private System.Windows.Forms.PictureBox orozje_gor;
        private System.Windows.Forms.PictureBox dino_z_dodatki;
        private System.Windows.Forms.Label igralec;
    }
}

