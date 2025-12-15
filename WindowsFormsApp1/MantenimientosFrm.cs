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
            // Cargar equipos
            combobEquipoID.DataSource = Equipo.Obtener();
            combobEquipoID.DisplayMember = "nombre";
            combobEquipoID.ValueMember = "id";
            combobEquipoID.SelectedIndex = -1;

            // Cargar técnicos
            combobTecnicoID.DataSource = Tecnico.Obtener();
            combobTecnicoID.DisplayMember = "nombre";
            combobTecnicoID.ValueMember = "id";
            combobTecnicoID.SelectedIndex = -1;

            // Cargar mantenimientos
            dataGridView1.DataSource = Mantenimiento.Obtener();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }

        // ======================= GUARDAR =======================
        private void buttGuardar_Click(object sender, EventArgs e)
        {
            // VALIDAR EQUIPO
            int equipo_id;
            if (!int.TryParse(combobEquipoID.SelectedValue?.ToString(), out equipo_id))
            {
                MessageBox.Show("Seleccione un equipo válido.");
                return;
            }

            // VALIDAR TÉCNICO
            int tecnico_id;
            if (!int.TryParse(combobTecnicoID.SelectedValue?.ToString(), out tecnico_id))
            {
                MessageBox.Show("Seleccione un técnico válido.");
                return;
            }

            string tipo = txtTipo.Text;
            DateTime fecha_inicio = dateTimeFechaInicio.Value;
            DateTime fecha_fin = dateTimeFechaFin.Value;

            if (fecha_fin < fecha_inicio)
            {
                MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio.");
                return;
            }

            string descripcion_problema = txtDescripcionProblema.Text;
            string acciones_realizadas = txtAccionesRealizadas.Text;
            string estado = txtEstado.Text;
            string informe_tecnico = txtInformeTecnico.Text;

            decimal costo_total;
            if (!decimal.TryParse(txtCostoTotal.Text, out costo_total))
            {
                MessageBox.Show("Ingrese un costo total válido.");
                return;
            }

            int tiempo_inactividad;
            if (!int.TryParse(txtTiempoInactividad.Text, out tiempo_inactividad))
            {
                MessageBox.Show("Ingrese un tiempo de inactividad válido.");
                return;
            }

            bool resultado;

            if (MantenimientoID == 0)
            {
                resultado = Mantenimiento.Crear(
                    equipo_id,
                    tecnico_id,
                    tipo,
                    fecha_inicio,
                    fecha_fin,
                    descripcion_problema,
                    acciones_realizadas,
                    costo_total,
                    tiempo_inactividad,
                    estado,
                    informe_tecnico
                );
            }
            else
            {
                resultado = Mantenimiento.Editar(
                    MantenimientoID,
                    equipo_id,
                    tecnico_id,
                    tipo,
                    fecha_inicio,
                    fecha_fin,
                    descripcion_problema,
                    acciones_realizadas,
                    costo_total,
                    tiempo_inactividad,
                    estado,
                    informe_tecnico
                );
            }

            if (resultado)
            {
                MessageBox.Show("Mantenimiento guardado correctamente.");
                dataGridView1.DataSource = Mantenimiento.Obtener();
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el mantenimiento.");
            }
        }

        // ======================= EDITAR =======================
        private void buttEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            MantenimientoID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            combobEquipoID.SelectedValue = dataGridView1.CurrentRow.Cells["equipo_id"].Value;
            combobTecnicoID.SelectedValue = dataGridView1.CurrentRow.Cells["tecnico_id"].Value;

            txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
            txtDescripcionProblema.Text = dataGridView1.CurrentRow.Cells["descripcion_problema"].Value.ToString();
            txtAccionesRealizadas.Text = dataGridView1.CurrentRow.Cells["acciones_realizadas"].Value.ToString();
            txtCostoTotal.Text = dataGridView1.CurrentRow.Cells["costo_total"].Value.ToString();
            txtTiempoInactividad.Text = dataGridView1.CurrentRow.Cells["tiempo_inactividad"].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            txtInformeTecnico.Text = dataGridView1.CurrentRow.Cells["informe_tecnico"].Value.ToString();

            dateTimeFechaInicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_inicio"].Value);
            dateTimeFechaFin.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_fin"].Value);
        }

        // ======================= ELIMINAR =======================
        private void buttEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un mantenimiento.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este mantenimiento?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                if (Mantenimiento.Eliminar(id))
                {
                    MessageBox.Show("Mantenimiento eliminado correctamente.");
                    dataGridView1.DataSource = Mantenimiento.Obtener();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        // ======================= LIMPIAR =======================
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

            combobEquipoID.SelectedIndex = -1;
            combobTecnicoID.SelectedIndex = -1;

            MantenimientoID = 0;
        }

        // ======================= EVENTOS (NECESARIOS PARA EL DESIGNER) =======================
        private void combobEquipoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Método vacío para evitar error del Designer
        }

        private void combobTecnicoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Método vacío para evitar error del Designer
        }
    }
}