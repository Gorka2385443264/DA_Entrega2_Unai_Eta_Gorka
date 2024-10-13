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
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtAbizena = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2_arduraduna = new System.Windows.Forms.Label();
            this.textBox1_arduraduna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Langilea gehitu";
            // 
            // btnGehitu
            // 
            this.btnGehitu.Location = new System.Drawing.Point(324, 329);
            this.btnGehitu.Name = "btnGehitu";
            this.btnGehitu.Size = new System.Drawing.Size(75, 23);
            this.btnGehitu.TabIndex = 1;
            this.btnGehitu.Text = "Gehitu";
            this.btnGehitu.UseVisualStyleBackColor = true;
            this.btnGehitu.Click += new System.EventHandler(this.btnGehitu_Click);
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(352, 173);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(100, 22);
            this.txtIzena.TabIndex = 3;
            // 
            // txtAbizena
            // 
            this.txtAbizena.Location = new System.Drawing.Point(352, 201);
            this.txtAbizena.Name = "txtAbizena";
            this.txtAbizena.Size = new System.Drawing.Size(100, 22);
            this.txtAbizena.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(352, 229);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 5;
            // 
            // txtNan
            // 
            this.txtNan.Location = new System.Drawing.Point(352, 145);
            this.txtNan.Name = "txtNan";
            this.txtNan.Size = new System.Drawing.Size(100, 22);
            this.txtNan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Izena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Abizena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefonoa";
            // 
            // label2_arduraduna
            // 
            this.label2_arduraduna.AutoSize = true;
            this.label2_arduraduna.Location = new System.Drawing.Point(179, 268);
            this.label2_arduraduna.Name = "label2_arduraduna";
            this.label2_arduraduna.Size = new System.Drawing.Size(156, 16);
            this.label2_arduraduna.TabIndex = 16;
            this.label2_arduraduna.Text = "Arduraduna (0 EZ / 1 BAI)";
            // 
            // textBox1_arduraduna
            // 
            this.textBox1_arduraduna.Location = new System.Drawing.Point(352, 268);
            this.textBox1_arduraduna.Name = "textBox1_arduraduna";
            this.textBox1_arduraduna.Size = new System.Drawing.Size(100, 22);
            this.textBox1_arduraduna.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1_arduraduna);
            this.Controls.Add(this.label2_arduraduna);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAbizena);
            this.Controls.Add(this.txtIzena);
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
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtAbizena;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2_arduraduna;
        private System.Windows.Forms.TextBox textBox1_arduraduna;
    }
}