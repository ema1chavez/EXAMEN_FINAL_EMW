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
    public partial class MantenimientosFrm : Form
    {
        int MantenimientoID = 0;

        public MantenimientosFrm()
        {
            InitializeComponent();
        }

        private void MantenimientosFrm_Load(object sender, EventArgs e)
        {

            //optener la lista de ID del Equipo 
            combobEquipoID.DataSource = Equipo.Obtener();
            combobEquipoID.DisplayMember = "id";     // Lo que se muestra
            combobEquipoID.ValueMember = "id";       // El valor real

            //optener la lista de id del tecnico
            combobTecnicoID.DataSource = Tecnico.Obtener();
            combobTecnicoID.DisplayMember = "id";
            combobTecnicoID.ValueMember = "id";

            dataGridView1.DataSource = Mantenimiento.Obtener();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        private void buttGuardar_Click(object sender, EventArgs e)
        {
            string tipo = txtTipo.Text;
            DateTime fecha_inicio = dateTimeFechaInicio.Value;
            DateTime fecha_fin = dateTimeFechaFin.Value;
            string descripcion_problema = txtDescripcionProblema.Text;
            string acciones_realizadas = txtAccionesRealizadas.Text;

            // VALIDAR DECIMAL
            decimal costo_total;
            if (!decimal.TryParse(txtCostoTotal.Text, out costo_total))
            {
                MessageBox.Show("Ingrese un costo total válido.");
                return;
            }

            // VALIDAR INT
            int tiempo_inactividad;
            if (!int.TryParse(txtTiempoInactividad.Text, out tiempo_inactividad))
            {
                MessageBox.Show("Ingrese un tiempo de inactividad válido (número entero).");
                return;
            }

            string estado = txtEstado.Text;
            string informe_tecnico = txtInformeTecnico.Text;
          

            bool resultado = false;

            if (MantenimientoID == 0)
            {
                resultado = Mantenimiento.Crear(
                    tipo, fecha_inicio, fecha_fin, descripcion_problema,
                    acciones_realizadas, costo_total, tiempo_inactividad,
                    estado, informe_tecnico
                );
            }
            else
            {
                resultado = Mantenimiento.Editar(
                    MantenimientoID, tipo, fecha_inicio, fecha_fin,
                    descripcion_problema, acciones_realizadas,
                    costo_total, tiempo_inactividad, estado, informe_tecnico
                );
            }

            dataGridView1.DataSource = Mantenimiento.Obtener();
            limpiar();
        }

        private void limpiar()
        {
            txtTipo.Clear();
            txtDescripcionProblema.Clear();
            txtAccionesRealizadas.Clear();
            txtCostoTotal.Clear();
            txtTiempoInactividad.Clear();
            txtEstado.Clear();
            txtInformeTecnico.Clear();

            dateTimeFechaInicio.Value = DateTime.Now;
            dateTimeFechaFin.Value = DateTime.Now;

            MantenimientoID = 0;
        }

        private void buttEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            // Obtener ID del mantenimiento seleccionado
            MantenimientoID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            // Cargar los campos en el formulario
            txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
            txtDescripcionProblema.Text = dataGridView1.CurrentRow.Cells["descripcion_problema"].Value.ToString();
            txtAccionesRealizadas.Text = dataGridView1.CurrentRow.Cells["acciones_realizadas"].Value.ToString();
            txtCostoTotal.Text = dataGridView1.CurrentRow.Cells["costo_total"].Value.ToString();
            txtTiempoInactividad.Text = dataGridView1.CurrentRow.Cells["tiempo_inactividad"].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            txtInformeTecnico.Text = dataGridView1.CurrentRow.Cells["informe_tecnico"].Value.ToString();

            // Fechas
            dateTimeFechaInicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_inicio"].Value);
            dateTimeFechaFin.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_fin"].Value);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado  = Mantenimiento.Eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado Correctamente");
            }
            dataGridView1.DataSource = Mantenimiento.Obtener();
            limpiar();
        }

        private void combobEquipoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobEquipoID.SelectedValue == null)
                return;

            // Evita que SelectedValue sea DataRowView
            if (combobEquipoID.SelectedValue is DataRowView)
                return;

            int equipoID = Convert.ToInt32(combobEquipoID.SelectedValue);
           
        }

        private void combobTecnicoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobTecnicoID.SelectedValue == null)
                return;

            if (combobTecnicoID.SelectedValue is DataRowView)
                return;

            int tecnicoID = Convert.ToInt32(combobTecnicoID.SelectedValue);
           

        }
    }
}