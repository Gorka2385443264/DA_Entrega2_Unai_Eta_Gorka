﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DA_Entrega2_Unai_Eta_Gorka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";
        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";

            string izena = txtIzena.Text;
            string abizena = txtAbizena.Text;
            string tel = txtTel.Text;
            string nan = txtNan.Text;
            string arduraduna = textBox1_arduraduna.Text; // Captura el valor del TextBox arduraduna

            // Verifica si los campos están vacíos
            if (string.IsNullOrEmpty(izena) || string.IsNullOrEmpty(abizena) ||
                string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(nan) || string.IsNullOrEmpty(arduraduna))
            {
                MessageBox.Show("Datu guztiak sartu mesedez.");
                return;
            }

            // Inserta el nuevo langilea
            string queryLangilea = "INSERT INTO entrega2_da.langilea (nan, izena, abizena, arduraduna, telefonoa, is_deleted) VALUES (@nan, @izena, @abizena, @arduraduna, @telefonoa, 0); SELECT LAST_INSERT_ID();";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(queryLangilea, conexion))
                    {
                        comando.Parameters.AddWithValue("@nan", nan);
                        comando.Parameters.AddWithValue("@izena", izena);
                        comando.Parameters.AddWithValue("@abizena", abizena);
                        comando.Parameters.AddWithValue("@arduraduna", arduraduna);
                        comando.Parameters.AddWithValue("@telefonoa", tel);

                        // Ejecuta el comando y obtiene el id del nuevo langilea
                        long idLangilea = Convert.ToInt64(comando.ExecuteScalar());

                        if (idLangilea > 0)
                        {
                            MessageBox.Show("Langilea ondo gehitu da.");

                            // Verifica si arduraduna es 1 para hacer el insert en erabiltzailea
                            if (arduraduna == "1")
                            {
                                string queryErabiltzailea = "INSERT INTO entrega2_da.erabiltzailea (id_langilea, is_deleted) VALUES (@id_langilea, 0)";

                                using (MySqlCommand comandoErabiltzailea = new MySqlCommand(queryErabiltzailea, conexion))
                                {
                                    comandoErabiltzailea.Parameters.AddWithValue("@id_langilea", idLangilea);

                                    int result = comandoErabiltzailea.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Erabiltzailea ondo gehitu da.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Arazoa erabiltzailea gehitzerakoan.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Langilea gehitzerakoan arazoa egon da.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea: " + ex.Message + ex.StackTrace);
                }
            }
        }

        private void button1_kendu_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";
            string nan = txtNan.Text; 
            string hardDeleteInput = textBox1_hardDelete.Text; 

            if (string.IsNullOrEmpty(nan))
            {
                MessageBox.Show("Mesedez, NAN bat sartu.");
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string queryIdLangilea = "SELECT id_langilea FROM entrega2_da.langilea WHERE nan = @nan";
                    long? idLangilea = null;

                    using (MySqlCommand comandoIdLangilea = new MySqlCommand(queryIdLangilea, conexion))
                    {
                        comandoIdLangilea.Parameters.AddWithValue("@nan", nan);
                        object result = comandoIdLangilea.ExecuteScalar();
                        if (result != null)
                        {
                            idLangilea = Convert.ToInt64(result);
                        }
                        else
                        {
                            MessageBox.Show("NAN hau ez da existitzen.");
                            return;
                        }
                    }

                    if (hardDeleteInput == "1")
                    {
                        string queryLangilea = "DELETE FROM entrega2_da.langilea WHERE id_langilea = @id_langilea";
                        using (MySqlCommand comandoLangilea = new MySqlCommand(queryLangilea, conexion))
                        {
                            comandoLangilea.Parameters.AddWithValue("@id_langilea", idLangilea);
                            comandoLangilea.ExecuteNonQuery();
                        }

                        string queryErabiltzailea = "DELETE FROM entrega2_da.erabiltzailea WHERE id_langilea = @id_langilea";
                        using (MySqlCommand comandoErabiltzailea = new MySqlCommand(queryErabiltzailea, conexion))
                        {
                            comandoErabiltzailea.Parameters.AddWithValue("@id_langilea", idLangilea);
                            comandoErabiltzailea.ExecuteNonQuery();
                        }

                        MessageBox.Show("Langilea eta erabiltzailea ondo kendu dira (hard delete).");
                    }
                    else
                    {
                        string queryLangilea = "UPDATE entrega2_da.langilea SET is_deleted = 1 WHERE nan = @nan";
                        using (MySqlCommand comandoLangilea = new MySqlCommand(queryLangilea, conexion))
                        {
                            comandoLangilea.Parameters.AddWithValue("@nan", nan);
                            comandoLangilea.ExecuteNonQuery();
                        }

                        string queryErabiltzailea = "UPDATE entrega2_da.erabiltzailea SET is_deleted = 1 WHERE id_langilea = @id_langilea";
                        using (MySqlCommand comandoErabiltzailea = new MySqlCommand(queryErabiltzailea, conexion))
                        {
                            comandoErabiltzailea.Parameters.AddWithValue("@id_langilea", idLangilea);
                            comandoErabiltzailea.ExecuteNonQuery();
                        }

                        MessageBox.Show("Erabiltzailea eta langilea ondo kendu dira (soft delete).");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea: " + ex.Message + ex.StackTrace);
                }
            }
        }

    }
}