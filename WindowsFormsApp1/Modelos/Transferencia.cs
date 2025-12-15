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

        public static bool Crear(
     int equipo_id,
     int ubicacion_origen_id,
     int ubicacion_destino_id,
     int responsable_entrega_id,
     int responsable_recibe_id,
     DateTime fecha_transferencia,
     string motivo,
     string documento_respaldo,
     string observaciones
 )
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = @"INSERT INTO Transferencias 
            (equipo_id, ubicacion_origen_id, ubicacion_destino_id, responsable_entrega_id,
             responsable_recibe_id, fecha_transferencia, motivo, documento_respaldo, observaciones)
            VALUES 
            (@equipo_id, @ubicacion_origen_id, @ubicacion_destino_id, @responsable_entrega_id,
             @responsable_recibe_id, @fecha_transferencia, @motivo, @documento_respaldo, @observaciones)";

                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());

                comando.Parameters.AddWithValue("@equipo_id", equipo_id);
                comando.Parameters.AddWithValue("@ubicacion_origen_id", ubicacion_origen_id);
                comando.Parameters.AddWithValue("@ubicacion_destino_id", ubicacion_destino_id);
                comando.Parameters.AddWithValue("@responsable_entrega_id", responsable_entrega_id);
                comando.Parameters.AddWithValue("@responsable_recibe_id", responsable_recibe_id);
                comando.Parameters.AddWithValue("@fecha_transferencia", fecha_transferencia);

                comando.Parameters.AddWithValue("@motivo", motivo);
                comando.Parameters.AddWithValue("@documento_respaldo", documento_respaldo);
                comando.Parameters.AddWithValue("@observaciones", observaciones);

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


        public static bool Editar(
      int id,
      int equipo_id,
      int ubicacion_origen_id,
      int ubicacion_destino_id,
      int responsable_entrega_id,
      int responsable_recibe_id,
      DateTime fecha_transferencia,
      string motivo,
      string documento_respaldo,
      string observaciones)
        {
            Conexion cnn = new Conexion();

            try
            {
                cnn.Conectar();

                string consulta = @"UPDATE Transferencias SET
                equipo_id = @equipo_id,
                ubicacion_origen_id = @ubicacion_origen_id,
                ubicacion_destino_id = @ubicacion_destino_id,
                responsable_entrega_id = @responsable_entrega_id,
                responsable_recibe_id = @responsable_recibe_id,
                fecha_transferencia = @fecha_transferencia,
                motivo = @motivo,
                documento_respaldo = @documento_respaldo,
                observaciones = @observaciones
            WHERE id = @id";

                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@equipo_id", equipo_id);
                comando.Parameters.AddWithValue("@ubicacion_origen_id", ubicacion_origen_id);
                comando.Parameters.AddWithValue("@ubicacion_destino_id", ubicacion_destino_id);
                comando.Parameters.AddWithValue("@responsable_entrega_id", responsable_entrega_id);
                comando.Parameters.AddWithValue("@responsable_recibe_id", responsable_recibe_id);
                comando.Parameters.AddWithValue("@fecha_transferencia", fecha_transferencia);
                comando.Parameters.AddWithValue("@motivo", motivo);
                comando.Parameters.AddWithValue("@documento_respaldo", documento_respaldo);
                comando.Parameters.AddWithValue("@observaciones", observaciones);

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
                using (var conn = new SqlConnection("Data Source=.;Initial Catalog=TuBaseDeDatos;Integrated Security=True"))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM Transferencias WHERE id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
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

    }

}
