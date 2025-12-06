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
    internal class Tecnico
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Tecnicos order by id desc";
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

        public static bool Crear(string Nombre, string Dni, string Empresa, string Telefono, string Email)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "INSERT INTO Tecnicos (Nombre,Dni,Empresa, Telefono, Email) VALUES (@Nombre, @Dni,@Empresa, @Telefono, @Email)";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Dni", Dni);
                comando.Parameters.AddWithValue("@Empresa", Empresa);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);

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

        public static bool Editar(int id, string Nombre, string Dni, string Empresa, string Telefono, string Email)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "UPDATE Tecnicos SET Nombre = @Nombre, Dni = @Dni, Empresa = @Empresa, Telefono = @Telefono, Email = @Email WHERE id = @id";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Dni", Dni);
                comando.Parameters.AddWithValue("@Empresa", Empresa);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Email", Email);
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
                String consulta = "DELETE FROM Tecnicos WHERE id = @id";
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