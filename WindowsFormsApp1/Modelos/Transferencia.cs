using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modelos
{
    internal class Transferencia
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Transferencias order by id desc";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
