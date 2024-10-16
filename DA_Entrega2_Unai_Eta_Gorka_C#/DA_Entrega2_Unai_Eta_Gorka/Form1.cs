﻿using System;
using System.IO; 
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DA_Entrega2_Unai_Eta_Gorka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enter_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string nombreUsuario = textBox1_usuraio.Text;
                    string dniUsuario = textBox2_contraseña.Text;

                    string query = "SELECT COUNT(*) FROM langilea WHERE izena = @nombre AND nan = @dni AND arduraduna = 1 AND is_deleted = 0";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                        comando.Parameters.AddWithValue("@dni", dniUsuario);

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());

                        if (resultado > 0)
                        {
                            Form2 nuevaPagina = new Form2(nombreUsuario);
                            nuevaPagina.Show();
                            this.Hide();

                            
                            LogAction($"{nombreUsuario} ha iniciado sesión a la hora {DateTime.Now}");
                        }
                        else
                        {
                            MessageBox.Show("EZ ZARA ARDURADUNA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al conectar o consultar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LogAction(string message)
        {
            string filePath = "aldaketakLOG.txt"; 

            
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(message);
            }
        }
    }
}
