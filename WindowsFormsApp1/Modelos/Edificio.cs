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
    internal class Edificio
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                using (SqlConnection conn = cnn.Conectar())
                {
                    string sql = "SELECT id, nombre, direccion FROM Edificios ORDER BY id DESC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener edificios:\n" + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        public static bool Crear(string nombre, string direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                using (SqlConnection conn = cnn.Conectar())
                {
                    string sql = "INSERT INTO Edificios (nombre, direccion) VALUES (@nombre, @direccion)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear edificio:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        public static bool Editar(int id, string nombre, string direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                using (SqlConnection conn = cnn.Conectar())
                {
                    string sql = "UPDATE Edificios SET nombre=@nombre, direccion=@direccion WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar edificio:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                using (SqlConnection conn = cnn.Conectar())
                {
                    string sql = "DELETE FROM Edificios WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar edificio:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
