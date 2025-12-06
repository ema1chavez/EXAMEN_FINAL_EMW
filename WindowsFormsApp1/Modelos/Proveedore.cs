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
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Proveedores order by id desc";
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

        public static bool Crear(string Razon_social, string Ruc, string Telefono, string Email, string Direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "INSERT INTO Proveedores (Razon_social, Ruc, Telefono, Email) VALUES (@Razon_social, @Ruc,@Telefono,@Email)";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@Razon_social", Razon_social);
                comando.Parameters.AddWithValue("@Ruc", Ruc);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }


        public static bool Editar(int id, string Razon_social, string Ruc, string Telefono, string Email, string Direccion)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "UPDATE Proveedores SET Razon_social=@Razon_social, Ruc=@Ruc, Telefono=@Telefono, Email=@Email, Direccion=@Direccion WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@Razon_social", Razon_social);
                comando.Parameters.AddWithValue("@Ruc", Ruc);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
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
                cnn.Conectar();
                String consulta = "DELETE FROM Proveedores WHERE id = @id";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}

