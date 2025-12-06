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

        private void BajasFrm_Load(object sender, EventArgs e)
        {
            {
                dataGridView1.DataSource = Baja.Obtener();
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id"].Visible = false;

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                string Motivo= txtMotivo.Text;
                string Documento_Respaldo = txtDocumento_Respaldo.Text;
                string Informe_Tecnico = txtInforme_tecnico.Text;
                string Fecha_Baja = datetFechaBajas.Value.ToString("yyyy-MM-dd"); ;
                string Tipo_Disposicion = txtTipo_disposicion.Text;
                string Equipo_id = textBox1.Text;
                string Responsable_autorizacion_id = textBox2.Text;
                bool resultado = false;
                if (Baja_id == 0)
                {
                    resultado = Baja.Crear(Motivo, Documento_Respaldo,Informe_Tecnico,Fecha_Baja,Tipo_Disposicion,Equipo_id,Responsable_autorizacion_id);
                }
                else
                {
                    resultado = Baja.Editar(Baja_id,Motivo, Documento_Respaldo, Informe_Tecnico, Fecha_Baja, Tipo_Disposicion, Equipo_id, Responsable_autorizacion_id);
                }

                dataGridView1.DataSource = Baja.Obtener();
                limpiar();
            }
        }
        private void limpiar()
        {
            txtMotivo.Clear();
            txtDocumento_Respaldo.Clear();
            txtInforme_tecnico.Clear();
            datetFechaBajas.Text = "";
            txtTipo_disposicion.Clear();
            textBox1.Clear();
            textBox2.Clear();
            Baja_id = 0;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Baja_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                txtMotivo.Text = dataGridView1.CurrentRow.Cells["motivo"].Value.ToString();
                txtDocumento_Respaldo.Text = dataGridView1.CurrentRow.Cells["documento_respaldo"].Value.ToString();
                txtInforme_tecnico.Text = dataGridView1.CurrentRow.Cells["informe_tecnico"].Value.ToString();
                datetFechaBajas.Text = dataGridView1.CurrentRow.Cells["fecha_baja"].Value.ToString();
                txtTipo_disposicion.Text = dataGridView1.CurrentRow.Cells["tipo_disposicion"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["equipo_id"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["responsable_autorizacion_id"].Value.ToString();
            }

        }
        private void  btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bajaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                bool resultado = Baja.Eliminar(bajaId);
                if (resultado)
                {
                    dataGridView1.DataSource = Baja.Obtener();
                    limpiar();
                }
            }

        }
    }
}
