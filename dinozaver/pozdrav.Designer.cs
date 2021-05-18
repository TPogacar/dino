
namespace dinozaver
{
    partial class pozdrav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pozdrav));
            this.zacni = new System.Windows.Forms.Button();
            this.nastavi_ukaze = new System.Windows.Forms.Button();
            this.opis = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zacni
            // 
            resources.ApplyResources(this.zacni, "zacni");
            this.zacni.BackColor = System.Drawing.Color.LightGray;
            this.zacni.Name = "zacni";
            this.zacni.UseVisualStyleBackColor = false;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // nastavi_ukaze
            // 
            resources.ApplyResources(this.nastavi_ukaze, "nastavi_ukaze");
            this.nastavi_ukaze.BackColor = System.Drawing.Color.LightGray;
            this.nastavi_ukaze.Name = "nastavi_ukaze";
            this.nastavi_ukaze.UseVisualStyleBackColor = false;
            this.nastavi_ukaze.Click += new System.EventHandler(this.nastavi_ukaze_Click);
            // 
            // opis
            // 
            resources.ApplyResources(this.opis, "opis");
            this.opis.Name = "opis";
            // 
            // naslov
            // 
            resources.ApplyResources(this.naslov, "naslov");
            this.naslov.Name = "naslov";
            // 
            // pozdrav
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.nastavi_ukaze);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.naslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pozdrav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.Button nastavi_ukaze;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.Label naslov;
    }
}