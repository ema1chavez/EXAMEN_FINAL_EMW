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
    public partial class ProveedoresFmr : Form
    {
        int proveedor_id = 0;

        public ProveedoresFmr()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProveedoresFmr_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // ===================== CARGAR =====================
        private void CargarDatos()
        {
            dataGridView1.DataSource = Proveedore.Obtener();

            if (dataGridView1.Columns.Contains("id"))
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        // ===================== GUARDAR =====================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string razon = txtRazon_social.Text.Trim();
            string ruc = txtRuc.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrEmpty(razon) || string.IsNullOrEmpty(ruc))
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }

            bool resultado;

            if (proveedor_id == 0)
            {
                resultado = Proveedore.Crear(razon, ruc, telefono, email, direccion);
            }
            else
            {
                resultado = Proveedore.Editar(proveedor_id, razon, ruc, telefono, email, direccion);
            }

            if (resultado)
            {
                MessageBox.Show("Operación realizada correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación");
            }
        }

        // ===================== EDITAR =====================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            proveedor_id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            txtRazon_social.Text =
                dataGridView1.CurrentRow.Cells["Razon_social"].Value.ToString();

            txtRuc.Text =
                dataGridView1.CurrentRow.Cells["Ruc"].Value.ToString();

            txtTelefono.Text =
                dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();

            txtEmail.Text =
                dataGridView1.CurrentRow.Cells["Email"].Value.ToString();

            txtDireccion.Text =
                dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
        }

        // ===================== ELIMINAR =====================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este proveedor?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                if (Proveedore.Eliminar(id))
                {
                    MessageBox.Show("Proveedor eliminado correctamente");
                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(
                        "No se puede eliminar el proveedor.\n" +
                        "Puede tener equipos asociados."
                    );
                }
            }
        }

        // ===================== LIMPIAR =====================
        private void Limpiar()
        {
            txtRazon_social.Clear();
            txtRuc.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            proveedor_id = 0;
        }
    }
}