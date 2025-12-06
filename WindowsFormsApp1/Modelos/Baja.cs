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
    internal class Baja
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Bajas order by id desc";
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
        public static bool Crear(string Motivo,string Documento_Respaldo,string Informe_tecnico,string Fecha_Baja,string Tipo_Disposicion,
     string Equipo_id,
     string Responsable_autorizacion_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                SqlConnection conexion = cnn.Conectar();

                string Consulta = @"INSERT INTO Bajas 
            (motivo, Documento_Respaldo, Informe_tecnico, Fecha_Baja, 
             Tipo_Disposicion, Equipo_id, Responsable_autorizacion_id) 
            VALUES 
            (@motivo, @Documento_Respaldo, @Informe_tecnico, @Fecha_Baja, 
             @Tipo_Disposicion, @Equipo_id, @Responsable_autorizacion_id)";

                using (SqlCommand comando = new SqlCommand(Consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@motivo", Motivo);
                    comando.Parameters.AddWithValue("@Documento_Respaldo", Documento_Respaldo);
                    comando.Parameters.AddWithValue("@Informe_tecnico", Informe_tecnico);
                    comando.Parameters.AddWithValue("@Fecha_Baja", Fecha_Baja);
                    comando.Parameters.AddWithValue("@Tipo_Disposicion", Tipo_Disposicion);
                    comando.Parameters.AddWithValue("@Equipo_id", Equipo_id);
                    comando.Parameters.AddWithValue("@Responsable_autorizacion_id", Responsable_autorizacion_id);

                    int filas = comando.ExecuteNonQuery();

                    return true;
                }
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

        public static bool Editar(int id, string motivo, string Documento_Respaldo, string Informe_tecnico, string Fecha_Baja, string Tipo_Disposicion, string Equipo_id, string Responsable_autorizacion_id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "UPDATE Bajas SET motivo=@motivo, Documento_Respaldo=@Documento_Respaldo, Informe_tecnico=@Informe_tecnico, Fecha_Baja=@Fecha_Baja, Tipo_Disposicion=@Tipo_Disposicion, Equipo_id=@Equipo_id, Responsable_autorizacion_id=@Responsable_autorizacion_id WHERE id=@id";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@motivo", motivo);
                comando.Parameters.AddWithValue("@Documento_Respaldo", Documento_Respaldo);
                comando.Parameters.AddWithValue("@Informe_tecnico", Informe_tecnico);
                comando.Parameters.AddWithValue("@Fecha_Baja", Fecha_Baja);
                comando.Parameters.AddWithValue("@Tipo_Disposicion", Tipo_Disposicion);
                comando.Parameters.AddWithValue("@Equipo_id", Equipo_id);
                comando.Parameters.AddWithValue("@Responsable_autorizacion_id", Responsable_autorizacion_id);
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
                String consulta = "DELETE FROM Bajas WHERE id = @id";
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
