namespace SesliSessizApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.bBul = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(61, 6);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(217, 23);
            this.tbKelime.TabIndex = 1;
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Location = new System.Drawing.Point(61, 35);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(48, 19);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.TabStop = true;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Location = new System.Drawing.Point(115, 35);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(55, 19);
            this.rbSessiz.TabIndex = 3;
            this.rbSessiz.TabStop = true;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // bBul
            // 
            this.bBul.Location = new System.Drawing.Point(284, 5);
            this.bBul.Name = "bBul";
            this.bBul.Size = new System.Drawing.Size(75, 23);
            this.bBul.TabIndex = 4;
            this.bBul.Text = "Bul";
            this.bBul.UseVisualStyleBackColor = true;
            this.bBul.Click += new System.EventHandler(this.bBul_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(284, 31);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 5;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Location = new System.Drawing.Point(9, 60);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(350, 78);
            this.rtbSonuc.TabIndex = 6;
            this.rtbSonuc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 145);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bBul);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sesli Sessiz App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbKelime;
        private RadioButton rbSesli;
        private RadioButton rbSessiz;
        private Button bBul;
        private Button bTemizle;
        private RichTextBox rtbSonuc;
    }
}