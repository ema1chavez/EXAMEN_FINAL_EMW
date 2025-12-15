using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1.Modelos
{
    internal class Ubicacione
    {
        // ===================== OBTENER =====================
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string consulta = @"
                SELECT u.*, e.nombre AS edificio
                FROM Ubicaciones u
                INNER JOIN Edificios e ON u.edificio_id = e.id
                ORDER BY u.id DESC";

                SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ubicaciones:\n" + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ===================== CREAR =====================
        public static bool Crear(string area, string piso, string descripcion, int edificio_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = @"INSERT INTO Ubicaciones
                (area, piso, descripcion, edificio_id)
                VALUES (@area, @piso, @descripcion, @edificio_id)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@area", area);
                cmd.Parameters.AddWithValue("@piso", piso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@edificio_id", edificio_id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear ubicación:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ===================== EDITAR =====================
        public static bool Editar(int id, string area, string piso, string descripcion, int edificio_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = @"UPDATE Ubicaciones SET
                area=@area,
                piso=@piso,
                descripcion=@descripcion,
                edificio_id=@edificio_id
                WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@area", area);
                cmd.Parameters.AddWithValue("@piso", piso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@edificio_id", edificio_id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar ubicación:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ===================== ELIMINAR =====================
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "DELETE FROM Ubicaciones WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ubicación:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
