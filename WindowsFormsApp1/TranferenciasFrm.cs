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

            // cargar el combobox de equipo 
            cbEquipo.DataSource = Equipo.Obtener();
            cbEquipo.DisplayMember = "nombre";  // campo que se ve en la lista
            cbEquipo.ValueMember = ""; 

            // cargar el combobox de ubicacion origen
            cbUbicacionOrigen.DataSource = Ubicacione.Obtener();
            cbUbicacionOrigen.DisplayMember = "area";
            cbUbicacionOrigen.ValueMember = "";   // <-- corregido aquí

            // cargar el combobox de ubicacion destino
            cbUbicacionDestino.DataSource = Ubicacione.Obtener();
            cbUbicacionDestino.DisplayMember = "area";
            cbUbicacionDestino.ValueMember = "id";  // <-- corregido aquí

            // cargar el combobox de responsable entrega
            cbResponsableEntrega.DataSource = Responsable.Obtener();
            cbResponsableEntrega.DisplayMember = "nombre";
            cbResponsableEntrega.ValueMember = "id";  // <-- corregido aquí

            // cargar el combobox de responsable recibe
            cbResponsableRecibe.DataSource = Responsable.Obtener();
            cbResponsableRecibe.DisplayMember = "nombre";
            cbResponsableRecibe.ValueMember = "id";   // <-- corregido aquí
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        //guardamos los datos de la transferencia en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            int equipo_id = Convert.ToInt32(cbEquipo.SelectedValue);
            int ubicacion_origen_id = Convert.ToInt32(cbUbicacionOrigen.SelectedValue);
            int ubicacion_destino_id = Convert.ToInt32(cbUbicacionDestino.SelectedValue);
            int responsable_entrega_id = Convert.ToInt32(cbResponsableEntrega.SelectedValue);
            int responsable_recibe_id = Convert.ToInt32(cbResponsableRecibe.SelectedValue);

            DateTime fecha_transferencia = datetimeFechaTransferencia.Value;

            string motivo = txtMotivo.Text;
            string documentoRespaldo = txtDocumentoRespaldo.Text;
            string observaciones = txtObservaciones.Text;

            bool resultado = false;

            if (transferencias_id == 0)
            {
                resultado = Transferencia.Crear(
                    equipo_id,
                    ubicacion_origen_id,
                    ubicacion_destino_id,
                    responsable_entrega_id,
                    responsable_recibe_id,
                    fecha_transferencia,
                    motivo,
                    documentoRespaldo,
                    observaciones
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
                    motivo,
                    documentoRespaldo,
                    observaciones
                );
            }

            if (resultado)
            {
                dataGridView1.DataSource = Transferencia.Obtener();
                limpiar();
            }
        }



        private void limpiar()
        {
            txtMotivo.Clear();
            txtDocumentoRespaldo.Clear();
            txtObservaciones.Clear();
            cbEquipo.SelectedIndex = 0;
            cbUbicacionOrigen.SelectedIndex = 0;
            cbUbicacionDestino.SelectedIndex = 0;
            cbResponsableEntrega.SelectedIndex = 0;
            cbResponsableRecibe.SelectedIndex = 0;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
