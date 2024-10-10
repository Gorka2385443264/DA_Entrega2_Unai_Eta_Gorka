using System;
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
        private void VerificarConexion()
        {
            string connectionString = "server=localhost:3306;database=entrega2_da;user=root;password=1WMG2023;";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error al conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
