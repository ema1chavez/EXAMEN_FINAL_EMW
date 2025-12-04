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
    public partial class TipoEquipoFrm : Form
    {
        public TipoEquipoFrm()
        {
            InitializeComponent();
        }

        private void TipoEquipoFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tipo_Equipo.Obtener();
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }
    }
}
