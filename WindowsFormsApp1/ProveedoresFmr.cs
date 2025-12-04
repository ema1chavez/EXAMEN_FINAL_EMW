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
    public partial class ProveedoresFmr : Form
    {
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
    }
}
