namespace DA_Entrega2_Unai_Eta_Gorka
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGehitu = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtAbizena = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLangilea = new System.Windows.Forms.TextBox();
            this.txtIdErabiltzailea = new System.Windows.Forms.TextBox();
            this.btnGehitu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Langilea gehitu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGehitu
            // 
            this.btnGehitu.Location = new System.Drawing.Point(137, 279);
            this.btnGehitu.Name = "btnGehitu";
            this.btnGehitu.Size = new System.Drawing.Size(75, 23);
            this.btnGehitu.TabIndex = 1;
            this.btnGehitu.Text = "Gehitu";
            this.btnGehitu.UseVisualStyleBackColor = true;
            this.btnGehitu.Click += new System.EventHandler(this.btnGehitu_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 127);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "id";
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(132, 183);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(100, 22);
            this.txtIzena.TabIndex = 3;
            this.txtIzena.Text = "Izena";
            // 
            // txtAbizena
            // 
            this.txtAbizena.Location = new System.Drawing.Point(132, 211);
            this.txtAbizena.Name = "txtAbizena";
            this.txtAbizena.Size = new System.Drawing.Size(100, 22);
            this.txtAbizena.TabIndex = 4;
            this.txtAbizena.Text = "Abizena";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 239);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 5;
            this.txtTel.Text = "Telefonoa";
            // 
            // txtNan
            // 
            this.txtNan.Location = new System.Drawing.Point(132, 155);
            this.txtNan.Name = "txtNan";
            this.txtNan.Size = new System.Drawing.Size(100, 22);
            this.txtNan.TabIndex = 6;
            this.txtNan.Text = "NAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Erabiltzailea gehitu";
            // 
            // txtIdLangilea
            // 
            this.txtIdLangilea.Location = new System.Drawing.Point(409, 127);
            this.txtIdLangilea.Name = "txtIdLangilea";
            this.txtIdLangilea.Size = new System.Drawing.Size(100, 22);
            this.txtIdLangilea.TabIndex = 8;
            this.txtIdLangilea.Text = "id langilea";
            // 
            // txtIdErabiltzailea
            // 
            this.txtIdErabiltzailea.Location = new System.Drawing.Point(409, 155);
            this.txtIdErabiltzailea.Name = "txtIdErabiltzailea";
            this.txtIdErabiltzailea.Size = new System.Drawing.Size(100, 22);
            this.txtIdErabiltzailea.TabIndex = 9;
            this.txtIdErabiltzailea.Text = "id erabiltzailea";
            // 
            // btnGehitu2
            // 
            this.btnGehitu2.Location = new System.Drawing.Point(409, 195);
            this.btnGehitu2.Name = "btnGehitu2";
            this.btnGehitu2.Size = new System.Drawing.Size(75, 23);
            this.btnGehitu2.TabIndex = 10;
            this.btnGehitu2.Text = "Gehitu";
            this.btnGehitu2.UseVisualStyleBackColor = true;
            this.btnGehitu2.Click += new System.EventHandler(this.btnGehitu2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGehitu2);
            this.Controls.Add(this.txtIdErabiltzailea);
            this.Controls.Add(this.txtIdLangilea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAbizena);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGehitu);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGehitu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtAbizena;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLangilea;
        private System.Windows.Forms.TextBox txtIdErabiltzailea;
        private System.Windows.Forms.Button btnGehitu2;
    }
}