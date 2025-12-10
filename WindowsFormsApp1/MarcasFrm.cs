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
    public partial class MarcasFrm : Form
    {
        int marca_id = 0;
        public MarcasFrm()
        {
            InitializeComponent();
        }

        private void MarcasFrm_Load(object sender, EventArgs e)
        {
            {
                dataGridView1.DataSource = Marca.Obtener();
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id"].Visible = false;

                }
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                string nombres = txtNombres.Text;
                bool resultado = false;
                if (marca_id == 0)
                {
                  resultado = Marca.Crear(nombres);
                }
                else
                {
                   resultado = Marca.Editar(marca_id, nombres);
                }

                dataGridView1.DataSource = Marca.Obtener();
                limpiar();
            }
        }
        private void limpiar()
        {
        txtNombres.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            marca_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            bool resultado = Marca.Eliminar(id);
            dataGridView1.DataSource = Marca.Obtener();
        }
    }
}
