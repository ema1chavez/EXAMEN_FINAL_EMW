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
    public partial class TecnicosFrm : Form
    {
        int Tecnico_Id = 0;
        public TecnicosFrm()
        {
            InitializeComponent();
        }

        private void TecnicosFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tecnico.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string Dni = textBox2.Text;
            string Empresa = textBox3.Text;
            string Telefono = textBox4.Text;
            string Email = textBox5.Text;
            if (Tecnico_Id == 0)
            {
                Tecnico.Crear(Nombre, Dni, Empresa, Telefono, Email);
            }
            else
            {
                Tecnico.Editar(Tecnico_Id, Nombre, Dni, Empresa, Telefono, Email);
            }

            dataGridView1.DataSource = Tecnico.Obtener();
            limpiar();
        }
    


private void limpiar()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Dni"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Empresa"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            Tecnico_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Tecnico.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
            dataGridView1.DataSource = Tecnico.Obtener();
            limpiar();
        }
    }
}




