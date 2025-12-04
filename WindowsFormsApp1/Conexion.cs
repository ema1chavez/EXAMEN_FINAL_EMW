using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Conexion
    {
       SqlConnection connection = new SqlConnection("Database=inventario_de equipos informaticos;Data Source=172.16.0.20;User Id=sa;Password=Hyp3r10nPr0_;TrustServerCertificate=True");
        public SqlConnection Conectar()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            return connection;
        }
        public SqlConnection Desconectar()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
            return connection;
        }
    }
}
