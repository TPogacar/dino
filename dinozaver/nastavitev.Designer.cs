
namespace dinozaver
{
    partial class nastavitev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nastavitev));
            this.navodila_ime = new System.Windows.Forms.Label();
            this.da = new System.Windows.Forms.Button();
            this.ne = new System.Windows.Forms.Button();
            this.izbira_top_tock = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.ime_napis = new System.Windows.Forms.Label();
            this.navodila = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navodila_ime
            // 
            this.navodila_ime.AutoSize = true;
            this.navodila_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.navodila_ime.ForeColor = System.Drawing.Color.DimGray;
            this.navodila_ime.Location = new System.Drawing.Point(265, 243);
            this.navodila_ime.Name = "navodila_ime";
            this.navodila_ime.Size = new System.Drawing.Size(165, 17);
            this.navodila_ime.TabIndex = 17;
            this.navodila_ime.Text = "Ime ne sme vsebovati `;`!";
            // 
            // da
            // 
            this.da.BackColor = System.Drawing.Color.Silver;
            this.da.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.da.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.da.Location = new System.Drawing.Point(232, 337);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(115, 44);
            this.da.TabIndex = 16;
            this.da.Text = "DA";
            this.da.UseVisualStyleBackColor = false;
            this.da.Click += new System.EventHandler(this.da_Click);
            // 
            // ne
            // 
            this.ne.BackColor = System.Drawing.Color.Silver;
            this.ne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ne.Location = new System.Drawing.Point(93, 337);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(115, 44);
            this.ne.TabIndex = 15;
            this.ne.Text = "NE";
            this.ne.UseVisualStyleBackColor = false;
            this.ne.Click += new System.EventHandler(this.ne_Click);
            // 
            // izbira_top_tock
            // 
            this.izbira_top_tock.AutoSize = true;
            this.izbira_top_tock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.izbira_top_tock.Location = new System.Drawing.Point(19, 285);
            this.izbira_top_tock.Name = "izbira_top_tock";
            this.izbira_top_tock.Size = new System.Drawing.Size(317, 25);
            this.izbira_top_tock.TabIndex = 14;
            this.izbira_top_tock.Text = "Ali želiš tekmovati z ostalimi igralci?";
            // 
            // ime
            // 
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ime.Location = new System.Drawing.Point(93, 234);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(166, 30);
            this.ime.TabIndex = 13;
            this.ime.Text = "nov_igralec";
            // 
            // ime_napis
            // 
            this.ime_napis.AutoSize = true;
            this.ime_napis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ime_napis.Location = new System.Drawing.Point(19, 236);
            this.ime_napis.Name = "ime_napis";
            this.ime_napis.Size = new System.Drawing.Size(57, 25);
            this.ime_napis.TabIndex = 12;
            this.ime_napis.Text = "IME:";
            // 
            // navodila
            // 
            this.navodila.AutoSize = true;
            this.navodila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.navodila.Location = new System.Drawing.Point(16, 69);
            this.navodila.Name = "navodila";
            this.navodila.Size = new System.Drawing.Size(756, 140);
            this.navodila.TabIndex = 11;
            this.navodila.Text = resources.GetString("navodila.Text");
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.naslov.Location = new System.Drawing.Point(12, 9);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(335, 38);
            this.naslov.TabIndex = 10;
            this.naslov.Text = "NASTAVITEV IGRE:";
            // 
            // nastavitev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(780, 397);
            this.Controls.Add(this.navodila_ime);
            this.Controls.Add(this.da);
            this.Controls.Add(this.ne);
            this.Controls.Add(this.izbira_top_tock);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.ime_napis);
            this.Controls.Add(this.navodila);
            this.Controls.Add(this.naslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nastavitev";
            this.Text = "nastavitev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label navodila_ime;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Button ne;
        private System.Windows.Forms.Label izbira_top_tock;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label ime_napis;
        private System.Windows.Forms.Label navodila;
        private System.Windows.Forms.Label naslov;
    }
}