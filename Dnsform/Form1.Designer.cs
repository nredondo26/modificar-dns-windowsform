namespace Dnsform
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.opendns = new System.Windows.Forms.Button();
            this.nortodns = new System.Windows.Forms.Button();
            this.Originales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.googlesafesearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opendns
            // 
            this.opendns.Location = new System.Drawing.Point(8, 48);
            this.opendns.Name = "opendns";
            this.opendns.Size = new System.Drawing.Size(95, 23);
            this.opendns.TabIndex = 1;
            this.opendns.Text = "Open DNS";
            this.opendns.UseVisualStyleBackColor = true;
            this.opendns.Click += new System.EventHandler(this.opendns_Click);
            // 
            // nortodns
            // 
            this.nortodns.Location = new System.Drawing.Point(8, 77);
            this.nortodns.Name = "nortodns";
            this.nortodns.Size = new System.Drawing.Size(95, 23);
            this.nortodns.TabIndex = 2;
            this.nortodns.Text = "Norton DNS";
            this.nortodns.UseVisualStyleBackColor = true;
            this.nortodns.Click += new System.EventHandler(this.nortodns_Click);
            // 
            // Originales
            // 
            this.Originales.Location = new System.Drawing.Point(8, 19);
            this.Originales.Name = "Originales";
            this.Originales.Size = new System.Drawing.Size(95, 23);
            this.Originales.TabIndex = 0;
            this.Originales.Text = "AUTO - NDS";
            this.Originales.UseVisualStyleBackColor = true;
            this.Originales.Click += new System.EventHandler(this.Originales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opendns);
            this.groupBox1.Controls.Add(this.nortodns);
            this.groupBox1.Controls.Add(this.Originales);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNS";
            // 
            // googlesafesearch
            // 
            this.googlesafesearch.Location = new System.Drawing.Point(140, 31);
            this.googlesafesearch.Name = "googlesafesearch";
            this.googlesafesearch.Size = new System.Drawing.Size(103, 23);
            this.googlesafesearch.TabIndex = 4;
            this.googlesafesearch.Text = "Google Seguro";
            this.googlesafesearch.UseVisualStyleBackColor = true;
            this.googlesafesearch.Click += new System.EventHandler(this.googlesafesearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 318);
            this.Controls.Add(this.googlesafesearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opendns;
        private System.Windows.Forms.Button nortodns;
        private System.Windows.Forms.Button Originales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button googlesafesearch;
    }
}

