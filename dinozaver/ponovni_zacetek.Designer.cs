
namespace dinozaver
{
    partial class ponovni_zacetek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ponovni_zacetek));
            this.ne = new System.Windows.Forms.Button();
            this.da = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ne
            // 
            resources.ApplyResources(this.ne, "ne");
            this.ne.BackColor = System.Drawing.Color.Silver;
            this.ne.Name = "ne";
            this.ne.UseVisualStyleBackColor = false;
            this.ne.Click += new System.EventHandler(this.ne_Click);
            // 
            // da
            // 
            resources.ApplyResources(this.da, "da");
            this.da.BackColor = System.Drawing.Color.Silver;
            this.da.Name = "da";
            this.da.UseVisualStyleBackColor = false;
            this.da.Click += new System.EventHandler(this.da_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ponovni_zacetek
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ne);
            this.Controls.Add(this.da);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ponovni_zacetek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ne;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Label label1;
    }
}