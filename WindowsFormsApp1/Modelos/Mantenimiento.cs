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
    internal class Mantenimiento
    {
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM Mantenimiento order by id desc";
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
     string tipo,
     DateTime fecha_inicio,
     DateTime fecha_fin,
     string descripcion_problema,
     string acciones_realizadas,
     decimal costo_total,
     int tiempo_inactividad,
     string estado,
     string informe_tecnico
          
            )


        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection con = cnn.Conectar();

                string consulta = @"INSERT INTO Mantenimiento 
                (tipo, fecha_inicio, fecha_fin, descripcion_problema, acciones_realizadas,
                 costo_total, tiempo_inactividad, estado, informe_tecnico)
                VALUES 
                (@tipo, @fecha_inicio, @fecha_fin, @descripcion_problema, @acciones_realizadas,
                 @costo_total, @tiempo_inactividad, @estado, @informe_tecnico)";

                SqlCommand comando = new SqlCommand(consulta, con);

                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@acciones_realizadas", acciones_realizadas);
                comando.Parameters.AddWithValue("@costo_total", costo_total);
                comando.Parameters.AddWithValue("@tiempo_inactividad", tiempo_inactividad);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@informe_tecnico", informe_tecnico);
             
;

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool Editar(
     int id,
     string tipo,
     DateTime fecha_inicio,
     DateTime fecha_fin,
     string descripcion_problema,
     string acciones_realizadas,
     decimal costo_total,
     int tiempo_inactividad,
     string estado,
     string informe_tecnico)
        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection con = cnn.Conectar();

                string consulta = @"UPDATE Mantenimiento SET
                tipo = @tipo,
                fecha_inicio = @fecha_inicio,
                fecha_fin = @fecha_fin,
                descripcion_problema = @descripcion_problema,
                acciones_realizadas = @acciones_realizadas,
                costo_total = @costo_total,
                tiempo_inactividad = @tiempo_inactividad,
                estado = @estado,
                informe_tecnico = @informe_tecnico
            WHERE id = @id";

                SqlCommand comando = new SqlCommand(consulta, con);

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@acciones_realizadas", acciones_realizadas);
                comando.Parameters.AddWithValue("@costo_total", costo_total);
                comando.Parameters.AddWithValue("@tiempo_inactividad", tiempo_inactividad);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@informe_tecnico", informe_tecnico);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                SqlConnection con = cnn.Conectar();

                string consulta = "DELETE FROM Mantenimiento WHERE id = @id";

                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@id", id);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

    }
}

