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
                string consulta = "SELECT * FROM Mantenimiento ORDER BY id DESC";
                SqlCommand comando = new SqlCommand(consulta, cnn.Conectar());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================== CREAR ==================
        public static bool Crear(
            int equipo_id,
            int tecnico_id,
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

                string consulta = @"
                INSERT INTO Mantenimiento 
                (equipo_id, tecnico_id, tipo, fecha_inicio, fecha_fin,
                 descripcion_problema, acciones_realizadas,
                 costo_total, tiempo_inactividad, estado, informe_tecnico)
                VALUES
                (@equipo_id, @tecnico_id, @tipo, @fecha_inicio, @fecha_fin,
                 @descripcion_problema, @acciones_realizadas,
                 @costo_total, @tiempo_inactividad, @estado, @informe_tecnico)";

                SqlCommand comando = new SqlCommand(consulta, con);

                comando.Parameters.AddWithValue("@equipo_id", equipo_id);
                comando.Parameters.AddWithValue("@tecnico_id", tecnico_id);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@acciones_realizadas", acciones_realizadas);
                comando.Parameters.AddWithValue("@costo_total", costo_total);
                comando.Parameters.AddWithValue("@tiempo_inactividad", tiempo_inactividad);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@informe_tecnico", informe_tecnico);

                return comando.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear mantenimiento: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================== EDITAR ==================
        public static bool Editar(
            int id,
            int equipo_id,
            int tecnico_id,
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

                string consulta = @"
                UPDATE Mantenimiento SET
                    equipo_id = @equipo_id,
                    tecnico_id = @tecnico_id,
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
                comando.Parameters.AddWithValue("@equipo_id", equipo_id);
                comando.Parameters.AddWithValue("@tecnico_id", tecnico_id);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                comando.Parameters.AddWithValue("@descripcion_problema", descripcion_problema);
                comando.Parameters.AddWithValue("@acciones_realizadas", acciones_realizadas);
                comando.Parameters.AddWithValue("@costo_total", costo_total);
                comando.Parameters.AddWithValue("@tiempo_inactividad", tiempo_inactividad);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@informe_tecnico", informe_tecnico);

                return comando.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar mantenimiento: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // ================== ELIMINAR ==================
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection con = cnn.Conectar();

                string consulta = "DELETE FROM Mantenimiento WHERE id = @id";
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@id", id);

                return comando.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar mantenimiento: " + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
