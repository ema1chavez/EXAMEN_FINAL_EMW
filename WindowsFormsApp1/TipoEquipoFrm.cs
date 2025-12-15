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
    public partial class TipoEquipoFrm : Form
    {
        int tipo_equipo_id = 0;

        public TipoEquipoFrm()
        {
            InitializeComponent();
        }

        private void TipoEquipoFrm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Tipo_Equipo.Obtener();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del tipo de equipo");
                return;
            }

            bool resultado;

            if (tipo_equipo_id == 0)
            {
                resultado = Tipo_Equipo.Crear(txtNombre.Text);
            }
            else
            {
                resultado = Tipo_Equipo.Editar(tipo_equipo_id, txtNombre.Text);
            }

            if (resultado)
            {
                MessageBox.Show("Guardado correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ocurrió un error");
            }
        }


        // ================= EDITAR =================
        private void buttEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            tipo_equipo_id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            txtNombre.Text =
                dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
        }

        // ================= ELIMINAR =================
        private void buttEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult r = MessageBox.Show(
                "¿Desea eliminar este tipo de equipo?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                bool eliminado = Tipo_Equipo.Eliminar(id);

                if (eliminado)
                {
                    MessageBox.Show("Eliminado correctamente");
                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(
                        "No se puede eliminar porque está siendo usado",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            tipo_equipo_id = 0;
        }
    }
}
