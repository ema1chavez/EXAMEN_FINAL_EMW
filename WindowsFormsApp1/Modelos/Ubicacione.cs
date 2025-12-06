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
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "select u.*,e.nombre as edificio from Ubicaciones u inner join Edificios e on u.edificio_id = e.id order by id desc";
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

        public static bool Crear(string area, string piso, string descripcion, int edificio_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "INSERT INTO Ubicaciones (area,piso, descripcion, edificio_id) VALUES (@area, @piso, @descripcion,@edificio_id)";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@piso", piso);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@edificio_id", edificio_id);
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

        public static bool Editar(int id, string area, string piso, string descripcion, int edificio_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "UPDATE Ubicaciones SET area=@area, piso=@piso, descripcion=@descripcion, edificio=@edificio_id WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@piso", piso);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@edificio_id", edificio_id);
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
                String consulta = "DELETE FROM Ubicaciones WHERE id=@id";
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
