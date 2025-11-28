using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrincipalForm1 : Form
    {
        public PrincipalForm1()
        {
            InitializeComponent();
        }

        private void toolsEquipos_Click(object sender, EventArgs e)
        {
            EquiposFrm frm = new EquiposFrm();
            frm.MdiParent = this; //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsMantenimientos_Click(object sender, EventArgs e)
        {
            MantenimientosFrm frm = new MantenimientosFrm();
            frm.MdiParent = this; //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsTecnicos_Click(object sender, EventArgs e)
        {
            TecnicosFrm frm = new TecnicosFrm();
            frm.MdiParent = this; //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsProvedores_Click(object sender, EventArgs e)
        {
            ProveedoresFmr frm = new ProveedoresFmr();
            frm.MdiParent = this; //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsUbicaciones_Click(object sender, EventArgs e)
        {
            UbicacionesFrm frm = new UbicacionesFrm();
            frm.MdiParent = this; //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsEdificios_Click(object sender, EventArgs e)
        {
            EdificiosFrm frm = new EdificiosFrm();
            frm.MdiParent = this;  //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsBajas_Click(object sender, EventArgs e)
        {
            BajasFrm frm = new BajasFrm();
            frm.MdiParent = this;  //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsRepuestos_Click(object sender, EventArgs e)
        {
            RepuestosFrm frm = new RepuestosFrm();
            frm.MdiParent = this;  //lo abre dentro del formulario principal
            frm.Show();

        }

        private void toolsTransferencias_Click(object sender, EventArgs e)
        {
            TranferenciasFrm frm = new TranferenciasFrm();
            frm.MdiParent = this;  //lo abre dentro del formulario principal
            frm.Show();
        }

        private void toolsTipoEquipo_Click(object sender, EventArgs e)
        {
            TipoEquipoFrm frm = new TipoEquipoFrm();
            frm.MdiParent = this;  //lo abre dentro del formulario principal
            frm.Show();
        }
    }
}
