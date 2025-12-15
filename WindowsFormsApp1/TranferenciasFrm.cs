using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class TranferenciasFrm : Form
    {
        int transferencias_id = 0;
        private object dateTimeFechaTransferencia;

        public TranferenciasFrm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TranferenciasFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Transferencia.Obtener();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["equipo_id"].Visible = false;
                dataGridView1.Columns["ubicacion_origen_id"].Visible = false;
                dataGridView1.Columns["ubicacion_destino_id"].Visible = false;
            }

            // EQUIPO
            cbEquipo.DataSource = Equipo.Obtener();
            cbEquipo.DisplayMember = "nombre";
            cbEquipo.ValueMember = "id";   // ✅ CORREGIDO

            // UBICACIÓN ORIGEN
            cbUbicacionOrigen.DataSource = Ubicacione.Obtener();
            cbUbicacionOrigen.DisplayMember = "area";
            cbUbicacionOrigen.ValueMember = "id";   // ✅ CORREGIDO

            // UBICACIÓN DESTINO
            cbUbicacionDestino.DataSource = Ubicacione.Obtener();
            cbUbicacionDestino.DisplayMember = "area";
            cbUbicacionDestino.ValueMember = "id";

            // RESPONSABLE ENTREGA
            cbResponsableEntrega.DataSource = Responsable.Obtener();
            cbResponsableEntrega.DisplayMember = "nombre";
            cbResponsableEntrega.ValueMember = "id";

            // RESPONSABLE RECIBE
            cbResponsableRecibe.DataSource = Responsable.Obtener();
            cbResponsableRecibe.DisplayMember = "nombre";
            cbResponsableRecibe.ValueMember = "id";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        // ================= GUARDAR =================
        private void button1_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN MÍNIMA (no cambia diseño)
            if (
                cbEquipo.SelectedIndex == -1 ||
                cbUbicacionOrigen.SelectedIndex == -1 ||
                cbUbicacionDestino.SelectedIndex == -1 ||
                cbResponsableEntrega.SelectedIndex == -1 ||
                cbResponsableRecibe.SelectedIndex == -1
            )
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int equipo_id = Convert.ToInt32(cbEquipo.SelectedValue);
            int ubicacion_origen_id = Convert.ToInt32(cbUbicacionOrigen.SelectedValue);
            int ubicacion_destino_id = Convert.ToInt32(cbUbicacionDestino.SelectedValue);
            int responsable_entrega_id = Convert.ToInt32(cbResponsableEntrega.SelectedValue);
            int responsable_recibe_id = Convert.ToInt32(cbResponsableRecibe.SelectedValue);

            DateTime fecha_transferencia = datetimeFechaTransferencia.Value;

            bool resultado;

            if (transferencias_id == 0)
            {
                resultado = Transferencia.Crear(
                    equipo_id,
                    ubicacion_origen_id,
                    ubicacion_destino_id,
                    responsable_entrega_id,
                    responsable_recibe_id,
                    fecha_transferencia,
                    txtMotivo.Text,
                    txtDocumentoRespaldo.Text,
                    txtObservaciones.Text
                );
            }
            else
            {
                resultado = Transferencia.Editar(
                    transferencias_id,
                    equipo_id,
                    ubicacion_origen_id,
                    ubicacion_destino_id,
                    responsable_entrega_id,
                    responsable_recibe_id,
                    fecha_transferencia,
                    txtMotivo.Text,
                    txtDocumentoRespaldo.Text,
                    txtObservaciones.Text
                );
            }

            if (resultado)
            {
                dataGridView1.DataSource = Transferencia.Obtener();
                limpiar();
            }
        }

        // ================= LIMPIAR =================
        private void limpiar()
        {
            txtMotivo.Clear();
            txtDocumentoRespaldo.Clear();
            txtObservaciones.Clear();

            cbEquipo.SelectedIndex = -1;
            cbUbicacionOrigen.SelectedIndex = -1;
            cbUbicacionDestino.SelectedIndex = -1;
            cbResponsableEntrega.SelectedIndex = -1;
            cbResponsableRecibe.SelectedIndex = -1;

            transferencias_id = 0;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            transferencias_id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value
            );

            cbEquipo.SelectedValue =
                dataGridView1.CurrentRow.Cells["equipo_id"].Value;

            cbUbicacionOrigen.SelectedValue =
                dataGridView1.CurrentRow.Cells["ubicacion_origen_id"].Value;

            cbUbicacionDestino.SelectedValue =
                dataGridView1.CurrentRow.Cells["ubicacion_destino_id"].Value;

            cbResponsableEntrega.SelectedValue =
                dataGridView1.CurrentRow.Cells["responsable_entrega_id"].Value;

            cbResponsableRecibe.SelectedValue =
                dataGridView1.CurrentRow.Cells["responsable_recibe_id"].Value;

            datetimeFechaTransferencia.Value =
                Convert.ToDateTime(
                    dataGridView1.CurrentRow.Cells["fecha_transferencia"].Value
                );

            txtMotivo.Text =
                dataGridView1.CurrentRow.Cells["motivo"].Value.ToString();

            txtDocumentoRespaldo.Text =
                dataGridView1.CurrentRow.Cells["documento_respaldo"].Value.ToString();

            txtObservaciones.Text =
                dataGridView1.CurrentRow.Cells["observaciones"].Value.ToString();
        }


        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value
            );

            DialogResult r = MessageBox.Show(
                "¿Desea eliminar la transferencia?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.Yes)
            {
                bool eliminado = Transferencia.Eliminar(id);

                if (eliminado)
                {
                    dataGridView1.DataSource = Transferencia.Obtener();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }

        }

    }
}
