namespace LatvanyossagokApplication
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
            this.components = new System.ComponentModel.Container();
            this.textBoxVarosNev = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxLakossag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVarosHozzaad = new System.Windows.Forms.Button();
            this.listBoxVaros = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLatvanyossagNev = new System.Windows.Forms.TextBox();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.buttonLatvanyossagHozzaad = new System.Windows.Forms.Button();
            this.listBoxLatvanyossag = new System.Windows.Forms.ListBox();
            this.buttonVarosTorles = new System.Windows.Forms.Button();
            this.buttonLatvanyossagTorles = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnModositas2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVarosNev
            // 
            this.textBoxVarosNev.Location = new System.Drawing.Point(87, 33);
            this.textBoxVarosNev.Name = "textBoxVarosNev";
            this.textBoxVarosNev.Size = new System.Drawing.Size(122, 20);
            this.textBoxVarosNev.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxLakossag
            // 
            this.textBoxLakossag.Location = new System.Drawing.Point(87, 76);
            this.textBoxLakossag.Name = "textBoxLakossag";
            this.textBoxLakossag.Size = new System.Drawing.Size(122, 20);
            this.textBoxLakossag.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lakosság:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Város";
            // 
            // buttonVarosHozzaad
            // 
            this.buttonVarosHozzaad.Location = new System.Drawing.Point(93, 116);
            this.buttonVarosHozzaad.Name = "buttonVarosHozzaad";
            this.buttonVarosHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonVarosHozzaad.TabIndex = 6;
            this.buttonVarosHozzaad.Text = "Hozzáad";
            this.buttonVarosHozzaad.UseVisualStyleBackColor = true;
            this.buttonVarosHozzaad.Click += new System.EventHandler(this.buttonVarosHozzaad_Click);
            // 
            // listBoxVaros
            // 
            this.listBoxVaros.FormattingEnabled = true;
            this.listBoxVaros.Location = new System.Drawing.Point(25, 145);
            this.listBoxVaros.Name = "listBoxVaros";
            this.listBoxVaros.Size = new System.Drawing.Size(184, 108);
            this.listBoxVaros.TabIndex = 7;
            this.listBoxVaros.SelectedIndexChanged += new System.EventHandler(this.listBoxVaros_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Látványosság";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Leírás:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ár:";
            // 
            // textBoxLatvanyossagNev
            // 
            this.textBoxLatvanyossagNev.Location = new System.Drawing.Point(362, 33);
            this.textBoxLatvanyossagNev.Name = "textBoxLatvanyossagNev";
            this.textBoxLatvanyossagNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatvanyossagNev.TabIndex = 12;
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(362, 76);
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeiras.TabIndex = 13;
            // 
            // textBoxAr
            // 
            this.textBoxAr.Location = new System.Drawing.Point(362, 116);
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.Size = new System.Drawing.Size(100, 20);
            this.textBoxAr.TabIndex = 14;
            // 
            // buttonLatvanyossagHozzaad
            // 
            this.buttonLatvanyossagHozzaad.Location = new System.Drawing.Point(333, 161);
            this.buttonLatvanyossagHozzaad.Name = "buttonLatvanyossagHozzaad";
            this.buttonLatvanyossagHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonLatvanyossagHozzaad.TabIndex = 15;
            this.buttonLatvanyossagHozzaad.Text = "Hozzáad";
            this.buttonLatvanyossagHozzaad.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagHozzaad.Click += new System.EventHandler(this.buttonLatvanyossagHozzaad_Click);
            // 
            // listBoxLatvanyossag
            // 
            this.listBoxLatvanyossag.FormattingEnabled = true;
            this.listBoxLatvanyossag.Location = new System.Drawing.Point(290, 190);
            this.listBoxLatvanyossag.Name = "listBoxLatvanyossag";
            this.listBoxLatvanyossag.Size = new System.Drawing.Size(172, 108);
            this.listBoxLatvanyossag.TabIndex = 16;
            // 
            // buttonVarosTorles
            // 
            this.buttonVarosTorles.Location = new System.Drawing.Point(12, 116);
            this.buttonVarosTorles.Name = "buttonVarosTorles";
            this.buttonVarosTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonVarosTorles.TabIndex = 17;
            this.buttonVarosTorles.Text = "Törlés";
            this.buttonVarosTorles.UseVisualStyleBackColor = true;
            this.buttonVarosTorles.Click += new System.EventHandler(this.buttonVarosTorles_Click);
            // 
            // buttonLatvanyossagTorles
            // 
            this.buttonLatvanyossagTorles.Location = new System.Drawing.Point(252, 161);
            this.buttonLatvanyossagTorles.Name = "buttonLatvanyossagTorles";
            this.buttonLatvanyossagTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonLatvanyossagTorles.TabIndex = 18;
            this.buttonLatvanyossagTorles.Text = "Törlés";
            this.buttonLatvanyossagTorles.UseVisualStyleBackColor = true;
            this.buttonLatvanyossagTorles.Click += new System.EventHandler(this.buttonLatvanyossagTorles_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(174, 116);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(75, 23);
            this.btnModositas.TabIndex = 19;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnModositas2
            // 
            this.btnModositas2.Location = new System.Drawing.Point(414, 161);
            this.btnModositas2.Name = "btnModositas2";
            this.btnModositas2.Size = new System.Drawing.Size(75, 23);
            this.btnModositas2.TabIndex = 20;
            this.btnModositas2.Text = "Módosítás";
            this.btnModositas2.UseVisualStyleBackColor = true;
            this.btnModositas2.Click += new System.EventHandler(this.btnModositas2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.btnModositas2);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.buttonLatvanyossagTorles);
            this.Controls.Add(this.buttonVarosTorles);
            this.Controls.Add(this.listBoxLatvanyossag);
            this.Controls.Add(this.buttonLatvanyossagHozzaad);
            this.Controls.Add(this.textBoxAr);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.textBoxLatvanyossagNev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxVaros);
            this.Controls.Add(this.buttonVarosHozzaad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLakossag);
            this.Controls.Add(this.textBoxVarosNev);
            this.Name = "Form1";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVarosNev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxLakossag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVarosHozzaad;
        private System.Windows.Forms.ListBox listBoxVaros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLatvanyossagNev;
        private System.Windows.Forms.TextBox textBoxLeiras;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.Button buttonLatvanyossagHozzaad;
        private System.Windows.Forms.ListBox listBoxLatvanyossag;
        private System.Windows.Forms.Button buttonVarosTorles;
        private System.Windows.Forms.Button buttonLatvanyossagTorles;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnModositas2;
    }
}

