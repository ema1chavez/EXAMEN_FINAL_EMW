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
       SqlConnection connection = new SqlConnection(" Database=inventario_de_equipos informaticos;Data Source=192.168.10.2;UserId=sa;Password=Hyp3r10nPr0_;TrustServerCertificate=True");
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    MessageBox.Show("Conexión abierta correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            return connection;
        }
        public SqlConnection CerrarConexion()
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
