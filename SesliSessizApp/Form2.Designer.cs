namespace SesliSessizApp
{
    partial class Form2
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
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.tbCumle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Location = new System.Drawing.Point(12, 63);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(350, 78);
            this.rtbSonuc.TabIndex = 10;
            this.rtbSonuc.Text = "";
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(287, 8);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bGuncelle.TabIndex = 9;
            this.bGuncelle.Text = "Güncelle";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // tbCumle
            // 
            this.tbCumle.Location = new System.Drawing.Point(64, 9);
            this.tbCumle.Name = "tbCumle";
            this.tbCumle.Size = new System.Drawing.Size(217, 23);
            this.tbCumle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cümle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 152);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.tbCumle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbSonuc;
        private Button bGuncelle;
        private TextBox tbCumle;
        private Label label1;
    }
}