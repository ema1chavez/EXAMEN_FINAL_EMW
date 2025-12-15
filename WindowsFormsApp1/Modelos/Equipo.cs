using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modelos
{
    internal class Equipo
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                using (SqlConnection conn = cnn.Conectar())
                {
                    string consulta = @"
                SELECT 
                    e.id,
                    e.modelo AS nombre
                FROM equipos e
                ORDER BY e.id DESC;
            ";

                    SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener equipos:\n" + ex.Message);
                return null;
            }
        }
    }
}
