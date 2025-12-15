using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class EdificiosFrm : Form
    {
        int edificio_id = 0;

        public EdificiosFrm()
        {
            InitializeComponent();
        }

        private void EdificiosFrm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Edificio.Obtener();

            if (dataGridView1.Columns.Contains("id"))
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        // ===================== GUARDAR =====================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            bool resultado;

            if (edificio_id == 0)
            {
                resultado = Edificio.Crear(nombre, direccion);
            }
            else
            {
                resultado = Edificio.Editar(edificio_id, nombre, direccion);
            }

            if (resultado)
            {
                MessageBox.Show("Operación realizada correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        // ===================== EDITAR =====================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un edificio");
                return;
            }

            edificio_id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            txtNombre.Text =
                dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();

            txtDireccion.Text =
                dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
        }

        // ===================== ELIMINAR =====================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un edificio");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este edificio?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (Edificio.Eliminar(id))   // ✅ CORRECTO
                {
                    MessageBox.Show("Edificio eliminado");
                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
        }

        // ===================== LIMPIAR =====================
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            edificio_id = 0;
        }
    }
}