using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class Responsables : Form
    {
        int Responsable_id = 0;
        public Responsables()
        {
            InitializeComponent();
        }

        private void Responsables_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Responsable.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string Dni = textBox2.Text;
            string Cargo = txtca.Text;
            string Telefono = textBox3.Text;
            string Email = textBox4.Text;
            bool resultado = false;
            if (Responsable_id == 0)
            {
                resultado = Responsable.Crear(nombre, Dni, Cargo, Telefono, Email);
            }
            else
            {
                resultado = Responsable.Editar(Responsable_id, nombre, Dni, Cargo, Telefono, Email);
            }

            dataGridView1.DataSource = Responsable.Obtener();
            Limpiar();
        }

        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["dni"].Value.ToString();
            txtca.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            Responsable_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void txtca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Responsable.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
            dataGridView1.DataSource = Responsable.Obtener();
            Limpiar();
        }
    }
}




    