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
        // =========================
        // OBTENER
        // =========================
        public static DataTable Obtener()
        {
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "SELECT * FROM Bajas ORDER BY id DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener bajas\n" + ex.Message);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // =========================
        // CREAR
        // =========================
        public static bool Crear(
            string motivo,
            string documentoRespaldo,
            string informeTecnico,
            DateTime fechaBaja,
            string tipoDisposicion,
            int equipoId,
            int responsableId)
        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection conn = cnn.Conectar();

                string sql = @"INSERT INTO Bajas
                (motivo, Documento_Respaldo, Informe_tecnico, Fecha_Baja,
                 Tipo_Disposicion, Equipo_id, Responsable_autorizacion_id)
                VALUES
                (@motivo, @Documento_Respaldo, @Informe_tecnico, @Fecha_Baja,
                 @Tipo_Disposicion, @Equipo_id, @Responsable_autorizacion_id)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@motivo", SqlDbType.VarChar).Value = motivo;
                    cmd.Parameters.Add("@Documento_Respaldo", SqlDbType.VarChar).Value = documentoRespaldo;
                    cmd.Parameters.Add("@Informe_tecnico", SqlDbType.VarChar).Value = informeTecnico;
                    cmd.Parameters.Add("@Fecha_Baja", SqlDbType.Date).Value = fechaBaja;
                    cmd.Parameters.Add("@Tipo_Disposicion", SqlDbType.VarChar).Value = tipoDisposicion;
                    cmd.Parameters.Add("@Equipo_id", SqlDbType.Int).Value = equipoId;
                    cmd.Parameters.Add("@Responsable_autorizacion_id", SqlDbType.Int).Value = responsableId;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear baja\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // =========================
        // EDITAR
        // =========================
        public static bool Editar(
            int id,
            string motivo,
            string documentoRespaldo,
            string informeTecnico,
            DateTime fechaBaja,
            string tipoDisposicion,
            int equipoId,
            int responsableId)
        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection conn = cnn.Conectar();

                string sql = @"UPDATE Bajas SET
                motivo=@motivo,
                Documento_Respaldo=@Documento_Respaldo,
                Informe_tecnico=@Informe_tecnico,
                Fecha_Baja=@Fecha_Baja,
                Tipo_Disposicion=@Tipo_Disposicion,
                Equipo_id=@Equipo_id,
                Responsable_autorizacion_id=@Responsable_autorizacion_id
                WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@motivo", SqlDbType.VarChar).Value = motivo;
                    cmd.Parameters.Add("@Documento_Respaldo", SqlDbType.VarChar).Value = documentoRespaldo;
                    cmd.Parameters.Add("@Informe_tecnico", SqlDbType.VarChar).Value = informeTecnico;
                    cmd.Parameters.Add("@Fecha_Baja", SqlDbType.Date).Value = fechaBaja;
                    cmd.Parameters.Add("@Tipo_Disposicion", SqlDbType.VarChar).Value = tipoDisposicion;
                    cmd.Parameters.Add("@Equipo_id", SqlDbType.Int).Value = equipoId;
                    cmd.Parameters.Add("@Responsable_autorizacion_id", SqlDbType.Int).Value = responsableId;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar baja\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        // =========================
        // ELIMINAR
        // =========================
        public static bool Eliminar(int id)
        {
            Conexion cnn = new Conexion();

            try
            {
                SqlConnection conn = cnn.Conectar();
                string sql = "DELETE FROM Bajas WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar baja\n" + ex.Message);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}