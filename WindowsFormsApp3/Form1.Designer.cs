namespace WindowsFormsApp3
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
            this.Naslov = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Godina_Izdanja = new System.Windows.Forms.TextBox();
            this.Spremi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Naslov
            // 
            this.Naslov.Location = new System.Drawing.Point(97, 72);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(100, 20);
            this.Naslov.TabIndex = 0;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(97, 118);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(100, 20);
            this.Autor.TabIndex = 1;
            // 
            // Godina_Izdanja
            // 
            this.Godina_Izdanja.Location = new System.Drawing.Point(97, 159);
            this.Godina_Izdanja.Name = "Godina_Izdanja";
            this.Godina_Izdanja.Size = new System.Drawing.Size(100, 20);
            this.Godina_Izdanja.TabIndex = 2;
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(97, 209);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(100, 59);
            this.Spremi.TabIndex = 3;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(265, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.Godina_Izdanja);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Naslov);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Naslov;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox Godina_Izdanja;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

