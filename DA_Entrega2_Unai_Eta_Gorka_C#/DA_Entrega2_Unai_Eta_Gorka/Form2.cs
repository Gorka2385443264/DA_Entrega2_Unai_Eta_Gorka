using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";

            string id = txtId.Text;
            string izena = txtIzena.Text;
            string abizena = txtAbizena.Text;
            string tel = txtTel.Text;
            string nan = txtNan.Text;
            string arduraduna = "0";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(izena) || string.IsNullOrEmpty(abizena) ||
                string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(nan))
            {
                MessageBox.Show("Datu guztiak sartu mesedez.");
                return;
            }

            string query = "INSERT INTO entrega2_da.langilea (id, nan, izena, abizena, arduraduna, telefonoa) VALUES (@id, @nan, @izena, @abizena, @arduraduna, @tel)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {

                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@nan", nan);
                        comando.Parameters.AddWithValue("@izena", izena);
                        comando.Parameters.AddWithValue("@abizena", abizena);
                        comando.Parameters.AddWithValue("@arduraduna", arduraduna);
                        comando.Parameters.AddWithValue("@telefonoa", tel);


                        int emaitza = comando.ExecuteNonQuery();

                        if (emaitza > 0)
                        {
                            MessageBox.Show("Langilea ondo gehitu da.");
                        }
                        else
                        {
                            MessageBox.Show("Langilea gehitzerakoan arazoa egon da.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea: " + ex.Message);
                }

            }
        }

        private void btnGehitu2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=entrega2_da;user=root;password=1WMG2023;";

            string id = txtIdLangilea.Text;
            string id2 = txtIdErabiltzailea.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(id2))
            {
                MessageBox.Show("Datu guztiak sartu mesedez.");
                return;
            }

            string query = "INSERT INTO entrega2_da.erabiltzailea (id_erabiltzailea, id_langilea) VALUES (@id, @id2)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {

                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@id2", id2);
                       
                        int emaitza = comando.ExecuteNonQuery();

                        if (emaitza > 0)
                        {
                            MessageBox.Show("Erabiltzailea ondo gehitu da.");
                        }
                        else
                        {
                            MessageBox.Show("Erabiltzailea gehitzerakoan arazoa egon da.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea: " + ex.Message);
                }

                string query2 = "UPDATE entrega2_da.langilea SET arduraduna = 1 WHERE id = "+id;

                using (MySqlConnection conexion2 = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conexion2.Open();

                        using (MySqlCommand comando = new MySqlCommand(query2, conexion2))
                        {

                            comando.Parameters.AddWithValue("@id", id);
                            comando.Parameters.AddWithValue("@id2", id2);

                            int emaitza = comando.ExecuteNonQuery();

                            if (emaitza > 0)
                            {
                                MessageBox.Show("Aldaketa ondo egin da.");
                            }
                            else
                            {
                                MessageBox.Show("Arazoa datuak aldatzerakoan.");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errorea: " + ex.Message);
                    }
                }
    }
}
