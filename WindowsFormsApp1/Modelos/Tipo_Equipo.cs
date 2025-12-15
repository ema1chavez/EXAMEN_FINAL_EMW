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
    internal class Tipo_Equipo
    {
        // ================= OBTENER =================
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "SELECT * FROM TipoEquipos ORDER BY id DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipos de equipo\n" + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================= CREAR =================
        public static bool Crear(string nombre)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "INSERT INTO TipoEquipos (nombre) VALUES (@nombre)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================= EDITAR =================
        public static bool Editar(int id, string nombre)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "UPDATE TipoEquipos SET nombre = @nombre WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================= ELIMINAR =================
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "DELETE FROM TipoEquipos WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // FOREIGN KEY
                {
                    MessageBox.Show(
                        "No se puede eliminar este tipo de equipo\n" +
                        "porque está asignado a uno o más equipos.",
                        "Restricción",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show("Error:\n" + ex.Message);
                }
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

    }
}
