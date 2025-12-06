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
            {
                dataGridView1.DataSource = Proveedore.Obtener();
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id"].Visible = false;

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Razon_social = txtRazon_social.Text;
            string Ruc = txtRuc.Text;
            string Telefono = txtTelefono.Text;
            string Email = txtEmail.Text;
            string Direccion = txtDireccion.Text;
            bool resultado = false;
            if (proveedor_id == 0)
            {
                resultado = Proveedore.Crear(Razon_social, Ruc, Telefono, Email, Direccion);
            }
            else
            {
                resultado = Proveedore.Editar(proveedor_id, Razon_social, Ruc, Telefono, Email, Direccion);
            }
            if (resultado)
            {
                dataGridView1.DataSource = Proveedore.Obtener();
                limpiar();
            }
        }
        private void limpiar()
        {
            txtRazon_social.Clear();
            txtRuc.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtRazon_social.Text = dataGridView1.CurrentRow.Cells["Razon_social"].Value.ToString();
            txtRuc.Text = dataGridView1.CurrentRow.Cells["Ruc"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            proveedor_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            bool resultado = Proveedore.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
                dataGridView1.DataSource = Proveedore.Obtener();
            }
        }
    }

