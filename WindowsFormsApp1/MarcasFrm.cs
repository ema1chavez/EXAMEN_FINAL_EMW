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
    }
}
