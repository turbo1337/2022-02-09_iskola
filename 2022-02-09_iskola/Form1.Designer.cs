
namespace _2022_02_09_iskola
{
    partial class Form1
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
            this.btntörlés = new System.Windows.Forms.Button();
            this.btnmentés = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnbetöltés = new System.Windows.Forms.Button();
            this.btnkilépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntörlés
            // 
            this.btntörlés.Location = new System.Drawing.Point(22, 313);
            this.btntörlés.Name = "btntörlés";
            this.btntörlés.Size = new System.Drawing.Size(75, 23);
            this.btntörlés.TabIndex = 0;
            this.btntörlés.Text = "Törlés";
            this.btntörlés.UseVisualStyleBackColor = true;
            this.btntörlés.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmentés
            // 
            this.btnmentés.Location = new System.Drawing.Point(124, 313);
            this.btnmentés.Name = "btnmentés";
            this.btnmentés.Size = new System.Drawing.Size(75, 23);
            this.btnmentés.TabIndex = 1;
            this.btnmentés.Text = "Mentés";
            this.btnmentés.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 264);
            this.listBox1.TabIndex = 2;
            // 
            // btnbetöltés
            // 
            this.btnbetöltés.Location = new System.Drawing.Point(22, 355);
            this.btnbetöltés.Name = "btnbetöltés";
            this.btnbetöltés.Size = new System.Drawing.Size(75, 23);
            this.btnbetöltés.TabIndex = 3;
            this.btnbetöltés.Text = "Betöltés";
            this.btnbetöltés.UseVisualStyleBackColor = true;
            this.btnbetöltés.Click += new System.EventHandler(this.btnbetöltés_Click);
            // 
            // btnkilépés
            // 
            this.btnkilépés.Location = new System.Drawing.Point(124, 355);
            this.btnkilépés.Name = "btnkilépés";
            this.btnkilépés.Size = new System.Drawing.Size(75, 23);
            this.btnkilépés.TabIndex = 4;
            this.btnkilépés.Text = "Kilépés";
            this.btnkilépés.UseVisualStyleBackColor = true;
            this.btnkilépés.Click += new System.EventHandler(this.btnkilépés_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 390);
            this.Controls.Add(this.btnkilépés);
            this.Controls.Add(this.btnbetöltés);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnmentés);
            this.Controls.Add(this.btntörlés);
            this.Name = "Form1";
            this.Text = "Iskola GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntörlés;
        private System.Windows.Forms.Button btnmentés;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnbetöltés;
        private System.Windows.Forms.Button btnkilépés;
    }
}

