namespace DA_Entrega2_Unai_Eta_Gorka
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
            this.button1_Enter = new System.Windows.Forms.Button();
            this.label1_Login = new System.Windows.Forms.Label();
            this.label2_usuario = new System.Windows.Forms.Label();
            this.label3_contraseña = new System.Windows.Forms.Label();
            this.textBox1_usuraio = new System.Windows.Forms.TextBox();
            this.textBox2_contraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_Enter
            // 
            this.button1_Enter.Location = new System.Drawing.Point(313, 308);
            this.button1_Enter.Name = "button1_Enter";
            this.button1_Enter.Size = new System.Drawing.Size(75, 23);
            this.button1_Enter.TabIndex = 0;
            this.button1_Enter.Text = "ENTER";
            this.button1_Enter.UseVisualStyleBackColor = true;
            this.button1_Enter.Click += new System.EventHandler(this.button1_Enter_Click);
            // 
            // label1_Login
            // 
            this.label1_Login.AutoSize = true;
            this.label1_Login.Location = new System.Drawing.Point(326, 79);
            this.label1_Login.Name = "label1_Login";
            this.label1_Login.Size = new System.Drawing.Size(47, 16);
            this.label1_Login.TabIndex = 1;
            this.label1_Login.Text = "LOGIN";
            // 
            // label2_usuario
            // 
            this.label2_usuario.AutoSize = true;
            this.label2_usuario.Location = new System.Drawing.Point(326, 146);
            this.label2_usuario.Name = "label2_usuario";
            this.label2_usuario.Size = new System.Drawing.Size(54, 16);
            this.label2_usuario.TabIndex = 2;
            this.label2_usuario.Text = "Usuario";
            // 
            // label3_contraseña
            // 
            this.label3_contraseña.AutoSize = true;
            this.label3_contraseña.Location = new System.Drawing.Point(310, 223);
            this.label3_contraseña.Name = "label3_contraseña";
            this.label3_contraseña.Size = new System.Drawing.Size(76, 16);
            this.label3_contraseña.TabIndex = 3;
            this.label3_contraseña.Text = "Contraseña";
            // 
            // textBox1_usuraio
            // 
            this.textBox1_usuraio.Location = new System.Drawing.Point(304, 165);
            this.textBox1_usuraio.Name = "textBox1_usuraio";
            this.textBox1_usuraio.Size = new System.Drawing.Size(100, 22);
            this.textBox1_usuraio.TabIndex = 4;
            // 
            // textBox2_contraseña
            // 
            this.textBox2_contraseña.Location = new System.Drawing.Point(304, 242);
            this.textBox2_contraseña.Name = "textBox2_contraseña";
            this.textBox2_contraseña.Size = new System.Drawing.Size(100, 22);
            this.textBox2_contraseña.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_contraseña);
            this.Controls.Add(this.textBox1_usuraio);
            this.Controls.Add(this.label3_contraseña);
            this.Controls.Add(this.label2_usuario);
            this.Controls.Add(this.label1_Login);
            this.Controls.Add(this.button1_Enter);
            this.Name = "Form1";
            this.Text = "Conexión a Base de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Enter;
        private System.Windows.Forms.Label label1_Login;
        private System.Windows.Forms.Label label2_usuario;
        private System.Windows.Forms.Label label3_contraseña;
        private System.Windows.Forms.TextBox textBox2_contraseña;
        public System.Windows.Forms.TextBox textBox1_usuraio;
    }
}
