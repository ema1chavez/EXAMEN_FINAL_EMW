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
    internal class Proveedore
    {
        // ===================== OBTENER =====================
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string consulta = "SELECT * FROM Proveedores ORDER BY id DESC";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener proveedores:\n" + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ===================== CREAR =====================
        public static bool Crear(string razonSocial, string ruc, string telefono, string email, string direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = @"INSERT INTO Proveedores
                               (Razon_social, Ruc, Telefono, Email, Direccion)
                               VALUES (@Razon_social, @Ruc, @Telefono, @Email, @Direccion)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Razon_social", razonSocial);
                cmd.Parameters.AddWithValue("@Ruc", ruc);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear proveedor:\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ===================== EDITAR =====================
        public static bool Editar(int id, string razonSocial, string ruc, string telefono, string email, string direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = @"UPDATE Proveedores 
                               SET Razon_social=@Razon_social,
                                   Ruc=@Ruc,
                                   Telefono=@Telefono,
                                   Email=@Email,
                                   Direccion=@Direccion
                               WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Razon_social", razonSocial);
                cmd.Parameters.AddWithValue("@Ruc", ruc);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar proveedor:\n" + ex.Message);
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
                string sql = "DELETE FROM Proveedores WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se puede eliminar el proveedor.\n" +
                    "Puede tener equipos asociados.\n\n" +
                    ex.Message
                );
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}

