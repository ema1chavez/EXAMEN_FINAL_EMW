namespace WindowsFormsApp1
{
    partial class MantenimientosFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.combobTecnicoID = new System.Windows.Forms.ComboBox();
            this.combobEquipoID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.buttEliminar = new System.Windows.Forms.Button();
            this.buttEditar = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.txtInformeTecnico = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTiempoInactividad = new System.Windows.Forms.TextBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.txtAccionesRealizadas = new System.Windows.Forms.TextBox();
            this.txtDescripcionProblema = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.combobTecnicoID);
            this.splitContainer1.Panel1.Controls.Add(this.combobEquipoID);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeFechaInicio);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.buttEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.buttEditar);
            this.splitContainer1.Panel1.Controls.Add(this.buttGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.txtInformeTecnico);
            this.splitContainer1.Panel1.Controls.Add(this.txtEstado);
            this.splitContainer1.Panel1.Controls.Add(this.txtTiempoInactividad);
            this.splitContainer1.Panel1.Controls.Add(this.txtCostoTotal);
            this.splitContainer1.Panel1.Controls.Add(this.txtAccionesRealizadas);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcionProblema);
            this.splitContainer1.Panel1.Controls.Add(this.txtTipo);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 468);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 0;
            // 
            // combobTecnicoID
            // 
            this.combobTecnicoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobTecnicoID.FormattingEnabled = true;
            this.combobTecnicoID.Location = new System.Drawing.Point(218, 359);
            this.combobTecnicoID.Name = "combobTecnicoID";
            this.combobTecnicoID.Size = new System.Drawing.Size(121, 21);
            this.combobTecnicoID.TabIndex = 29;
            this.combobTecnicoID.SelectedIndexChanged += new System.EventHandler(this.combobTecnicoID_SelectedIndexChanged);
            // 
            // combobEquipoID
            // 
            this.combobEquipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobEquipoID.FormattingEnabled = true;
            this.combobEquipoID.Location = new System.Drawing.Point(16, 361);
            this.combobEquipoID.Name = "combobEquipoID";
            this.combobEquipoID.Size = new System.Drawing.Size(121, 21);
            this.combobEquipoID.TabIndex = 28;
            this.combobEquipoID.SelectedIndexChanged += new System.EventHandler(this.combobEquipoID_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tecnico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Equipo";
            // 
            // dateTimeFechaFin
            // 
            this.dateTimeFechaFin.Location = new System.Drawing.Point(187, 123);
            this.dateTimeFechaFin.Name = "dateTimeFechaFin";
            this.dateTimeFechaFin.Size = new System.Drawing.Size(191, 20);
            this.dateTimeFechaFin.TabIndex = 24;
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(11, 123);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(167, 20);
            this.dateTimeFechaInicio.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "MANTENIMIENTOS REALIZADOS";
            // 
            // buttEliminar
            // 
            this.buttEliminar.BackColor = System.Drawing.Color.Red;
            this.buttEliminar.Location = new System.Drawing.Point(258, 417);
            this.buttEliminar.Name = "buttEliminar";
            this.buttEliminar.Size = new System.Drawing.Size(75, 39);
            this.buttEliminar.TabIndex = 21;
            this.buttEliminar.Text = "ELIMINAR";
            this.buttEliminar.UseVisualStyleBackColor = false;
            // 
            // buttEditar
            // 
            this.buttEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttEditar.Location = new System.Drawing.Point(127, 417);
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(75, 39);
            this.buttEditar.TabIndex = 20;
            this.buttEditar.Text = "EDITAR";
            this.buttEditar.UseVisualStyleBackColor = false;
            this.buttEditar.Click += new System.EventHandler(this.buttEditar_Click);
            // 
            // buttGuardar
            // 
            this.buttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttGuardar.Location = new System.Drawing.Point(18, 417);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(75, 39);
            this.buttGuardar.TabIndex = 19;
            this.buttGuardar.Text = "GUARDAR";
            this.buttGuardar.UseVisualStyleBackColor = false;
            this.buttGuardar.Click += new System.EventHandler(this.buttGuardar_Click);
            // 
            // txtInformeTecnico
            // 
            this.txtInformeTecnico.Location = new System.Drawing.Point(12, 306);
            this.txtInformeTecnico.Name = "txtInformeTecnico";
            this.txtInformeTecnico.Size = new System.Drawing.Size(366, 20);
            this.txtInformeTecnico.TabIndex = 18;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(215, 265);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(163, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // txtTiempoInactividad
            // 
            this.txtTiempoInactividad.Location = new System.Drawing.Point(12, 265);
            this.txtTiempoInactividad.Name = "txtTiempoInactividad";
            this.txtTiempoInactividad.Size = new System.Drawing.Size(190, 20);
            this.txtTiempoInactividad.TabIndex = 16;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(246, 219);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(132, 20);
            this.txtCostoTotal.TabIndex = 15;
            // 
            // txtAccionesRealizadas
            // 
            this.txtAccionesRealizadas.Location = new System.Drawing.Point(11, 219);
            this.txtAccionesRealizadas.Name = "txtAccionesRealizadas";
            this.txtAccionesRealizadas.Size = new System.Drawing.Size(227, 20);
            this.txtAccionesRealizadas.TabIndex = 14;
            // 
            // txtDescripcionProblema
            // 
            this.txtDescripcionProblema.Location = new System.Drawing.Point(11, 170);
            this.txtDescripcionProblema.Name = "txtDescripcionProblema";
            this.txtDescripcionProblema.Size = new System.Drawing.Size(367, 20);
            this.txtDescripcionProblema.TabIndex = 13;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(11, 72);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(136, 20);
            this.txtTipo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Informe_tecnico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha_inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha_fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion_problema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Acciones_realizadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo_total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo_inactividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // MantenimientosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 468);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MantenimientosFrm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MantenimientosFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInformeTecnico;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTiempoInactividad;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.TextBox txtAccionesRealizadas;
        private System.Windows.Forms.TextBox txtDescripcionProblema;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttEliminar;
        private System.Windows.Forms.Button buttEditar;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combobTecnicoID;
        private System.Windows.Forms.ComboBox combobEquipoID;
    }
}