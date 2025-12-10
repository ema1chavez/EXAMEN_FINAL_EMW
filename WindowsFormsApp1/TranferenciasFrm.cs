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
    public partial class TranferenciasFrm : Form
    {
        int transferencias_id = 0;
        public TranferenciasFrm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TranferenciasFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Transferencia.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;

            }
            //cargar el combobox de equipo 
            cbEquipo.DataSource = Equipo.Obtener();
            cbEquipo.DisplayMember = "nombre";
            cbEquipo.ValueMember = "";

            //cargar el combobox de ubicacion origen
            cbUbicacionOrigen.DataSource = Ubicacione.Obtener();
            cbUbicacionOrigen.DisplayMember = "area";
            cbUbicacionOrigen.ValueMember = "";

            //cargar el combobox de ubicacion destino
            cbUbicacionDestino.DataSource = Ubicacione.Obtener();
            cbUbicacionDestino .DisplayMember = "area";
            cbUbicacionDestino .ValueMember = "";

            //cargar el combobox de responsable entrega
            cbResponsableEntrega.DataSource = Responsable.Obtener();
            cbResponsableEntrega.DisplayMember = "nombre";
            cbResponsableEntrega.ValueMember = "";

            //cargar el combobox de responsable recibe
            cbResponsableRecibe.DataSource = Responsable.Obtener();
            cbResponsableRecibe.DisplayMember = "nombre";
            cbResponsableRecibe.ValueMember = "";


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
         }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
