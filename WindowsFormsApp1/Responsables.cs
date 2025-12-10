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
            cbResponsable.DataSource = Responsable.Obtener();
            if (cbResponsable.Columns.Count > 0)
            {
                cbResponsable.Columns["id"].Visible = false;



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

            cbResponsable.DataSource = Responsable.Obtener();
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
            textBox1.Text = cbResponsable.CurrentRow.Cells["nombre"].Value.ToString();
            textBox2.Text = cbResponsable.CurrentRow.Cells["dni"].Value.ToString();
            txtca.Text = cbResponsable.CurrentRow.Cells["Cargo"].Value.ToString();
            textBox3.Text = cbResponsable.CurrentRow.Cells["Telefono"].Value.ToString();
            textBox4.Text = cbResponsable.CurrentRow.Cells["Email"].Value.ToString();
            Responsable_id = Convert.ToInt32(cbResponsable.CurrentRow.Cells["id"].Value);
        }

        private void txtca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbResponsable.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Responsable.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
            cbResponsable.DataSource = Responsable.Obtener();
            Limpiar();
        }

        private void cbResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbResponsable_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




    