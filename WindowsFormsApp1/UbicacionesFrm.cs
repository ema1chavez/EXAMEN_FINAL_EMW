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
    public partial class UbicacionesFrm : Form
    {
        int ubicacion_id = 0;
        public UbicacionesFrm()
        {
            InitializeComponent();
        }

        private void UbicacionesFrm_Load(object sender, EventArgs e)
        {
            {
                dataGridView1.DataSource = Ubicacione.Obtener();
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["edificio_id"].Visible = false;
                }
                cbEdificios.DataSource = Edificio.Obtener();
                cbEdificios.DisplayMember = "nombre";
                cbEdificios.ValueMember = "id";
            }

        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            string area = textbArea.Text;
            string piso = textbPiso.Text;
            string descripcion = textbDescripcion.Text;
            int edificio_id =Convert.ToInt32(cbEdificios.SelectedValue);
            bool resultado = false;
            if (ubicacion_id == 0)
            {
                resultado = Ubicacione.Crear(area, piso, descripcion, edificio_id);
            }
            else
            {
                resultado = Ubicacione.Editar(ubicacion_id, area, piso, descripcion, edificio_id);
            }
            if (resultado)
            {
                dataGridView1.DataSource = Ubicacione.Obtener();
                limpiar();
            }
        }
        private void limpiar()
        {
            textbArea.Clear();
            textbPiso.Clear();
            textbDescripcion.Clear();
            cbEdificios.SelectedIndex = -1;
            cbEdificios.Text = "";
            ubicacion_id = 0;

        }

        private void buttEditar_Click(object sender, EventArgs e)
        {
            textbArea.Text = dataGridView1.CurrentRow.Cells["area"].Value.ToString();
            textbPiso.Text = dataGridView1.CurrentRow.Cells["piso"].Value.ToString();
            textbDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            cbEdificios.Text = dataGridView1.CurrentRow.Cells["edificio_id"].Value.ToString();
            ubicacion_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void buttEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            bool resultado = Ubicacione.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
                dataGridView1.DataSource = Ubicacione.Obtener();
            limpiar();
           }
        }
    }


