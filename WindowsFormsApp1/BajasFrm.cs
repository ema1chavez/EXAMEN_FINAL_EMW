using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class BajasFrm : Form
    {
        int Baja_id = 0;

        public BajasFrm()
        {
            InitializeComponent();
        }

        // =========================
        // LOAD
        // =========================
        private void BajasFrm_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarGrid();
        }

        // =========================
        // CARGAR COMBOS
        // =========================
        private void CargarCombos()
        {
            // EQUIPOS
            cbEquipo.DataSource = null;
            cbEquipo.DataSource = Equipo.Obtener();
            cbEquipo.DisplayMember = "nombre";
            cbEquipo.ValueMember = "id";
            cbEquipo.SelectedIndex = -1;

            // RESPONSABLES
            cbResponsable.DataSource = null;
            cbResponsable.DataSource = Responsable.Obtener();
            cbResponsable.DisplayMember = "nombre";
            cbResponsable.ValueMember = "id";
            cbResponsable.SelectedIndex = -1;
        }

        // =========================
        // CARGAR GRID
        // =========================
        private void CargarGrid()
        {
            dataGridView1.DataSource = Baja.Obtener();

            if (dataGridView1.Columns.Count > 0)
                dataGridView1.Columns["id"].Visible = false;
        }

        // =========================
        // GUARDAR / EDITAR
        // =========================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbEquipo.SelectedIndex == -1 || cbResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione equipo y responsable");
                return;
            }

            int equipoId = Convert.ToInt32(cbEquipo.SelectedValue);
            int responsableId = Convert.ToInt32(cbResponsable.SelectedValue);

            bool resultado;

            if (Baja_id == 0)
            {
                resultado = Baja.Crear(
                    txtMotivo.Text,
                    txtDocumento_Respaldo.Text,
                    txtInforme_tecnico.Text,
                    datetFechaBajas.Value,
                    txtTipoDispocision.Text,
                    equipoId,
                    responsableId
                );
            }
            else
            {
                resultado = Baja.Editar(
                    Baja_id,
                    txtMotivo.Text,
                    txtDocumento_Respaldo.Text,
                    txtInforme_tecnico.Text,
                    datetFechaBajas.Value,
                    txtTipoDispocision.Text,
                    equipoId,
                    responsableId
                );
            }

            if (resultado)
            {
                MessageBox.Show("Operación realizada correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        // =========================
        // EDITAR
        // =========================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Baja_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            txtMotivo.Text = dataGridView1.CurrentRow.Cells["motivo"].Value.ToString();
            txtDocumento_Respaldo.Text = dataGridView1.CurrentRow.Cells["Documento_Respaldo"].Value.ToString();
            txtInforme_tecnico.Text = dataGridView1.CurrentRow.Cells["Informe_tecnico"].Value.ToString();
            datetFechaBajas.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha_Baja"].Value);
            txtTipoDispocision.Text = dataGridView1.CurrentRow.Cells["Tipo_Disposicion"].Value.ToString();

            cbEquipo.SelectedValue =
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Equipo_id"].Value);

            cbResponsable.SelectedValue =
                Convert.ToInt32(dataGridView1.CurrentRow.Cells["Responsable_autorizacion_id"].Value);
        }

        // =========================
        // ELIMINAR
        // =========================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una baja");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar esta baja?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                if (Baja.Eliminar(id))
                {
                    MessageBox.Show("Baja eliminada correctamente");
                    CargarGrid();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la baja");
                }
            }
        }

        // =========================
        // LIMPIAR
        // =========================
        private void Limpiar()
        {
            txtMotivo.Clear();
            txtDocumento_Respaldo.Clear();
            txtInforme_tecnico.Clear();
            txtTipoDispocision.Clear();

            datetFechaBajas.Value = DateTime.Now;
            cbEquipo.SelectedIndex = -1;
            cbResponsable.SelectedIndex = -1;

            Baja_id = 0;
        }
    }
}