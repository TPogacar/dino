
namespace dinozaver
{
    partial class konec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(konec));
            this.rezultat = new System.Windows.Forms.TextBox();
            this.da = new System.Windows.Forms.Button();
            this.ne = new System.Windows.Forms.Button();
            this.ustrajam = new System.Windows.Forms.Label();
            this.naj_rezultat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rezultat
            // 
            resources.ApplyResources(this.rezultat, "rezultat");
            this.rezultat.ForeColor = System.Drawing.Color.Red;
            this.rezultat.Name = "rezultat";
            // 
            // da
            // 
            resources.ApplyResources(this.da, "da");
            this.da.BackColor = System.Drawing.Color.Silver;
            this.da.Name = "da";
            this.da.UseVisualStyleBackColor = false;
            this.da.Click += new System.EventHandler(this.da_Click);
            // 
            // ne
            // 
            resources.ApplyResources(this.ne, "ne");
            this.ne.BackColor = System.Drawing.Color.Silver;
            this.ne.Name = "ne";
            this.ne.UseVisualStyleBackColor = false;
            this.ne.Click += new System.EventHandler(this.ne_Click);
            // 
            // ustrajam
            // 
            resources.ApplyResources(this.ustrajam, "ustrajam");
            this.ustrajam.Name = "ustrajam";
            // 
            // naj_rezultat
            // 
            resources.ApplyResources(this.naj_rezultat, "naj_rezultat");
            this.naj_rezultat.Name = "naj_rezultat";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // konec
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.da);
            this.Controls.Add(this.ne);
            this.Controls.Add(this.ustrajam);
            this.Controls.Add(this.naj_rezultat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "konec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Button ne;
        private System.Windows.Forms.Label ustrajam;
        private System.Windows.Forms.Label naj_rezultat;
        private System.Windows.Forms.Label label1;
    }
}