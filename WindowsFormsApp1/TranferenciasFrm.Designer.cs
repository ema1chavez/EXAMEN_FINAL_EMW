namespace WindowsFormsApp1
{
    partial class TranferenciasFrm
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
            this.TRANSFERENCIAS = new System.Windows.Forms.Label();
            this.cbResponsableRecibe = new System.Windows.Forms.ComboBox();
            this.cbResponsableEntrega = new System.Windows.Forms.ComboBox();
            this.cbUbicacionDestino = new System.Windows.Forms.ComboBox();
            this.cbUbicacionOrigen = new System.Windows.Forms.ComboBox();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimeFechaTransferencia = new System.Windows.Forms.DateTimePicker();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoRespaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.TRANSFERENCIAS);
            this.splitContainer1.Panel1.Controls.Add(this.cbResponsableRecibe);
            this.splitContainer1.Panel1.Controls.Add(this.cbResponsableEntrega);
            this.splitContainer1.Panel1.Controls.Add(this.cbUbicacionDestino);
            this.splitContainer1.Panel1.Controls.Add(this.cbUbicacionOrigen);
            this.splitContainer1.Panel1.Controls.Add(this.cbEquipo);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeFechaTransferencia);
            this.splitContainer1.Panel1.Controls.Add(this.btEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btEditar);
            this.splitContainer1.Panel1.Controls.Add(this.btGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.txtObservaciones);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDocumentoRespaldo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(813, 535);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 0;
            // 
            // TRANSFERENCIAS
            // 
            this.TRANSFERENCIAS.AutoSize = true;
            this.TRANSFERENCIAS.Location = new System.Drawing.Point(112, 13);
            this.TRANSFERENCIAS.Name = "TRANSFERENCIAS";
            this.TRANSFERENCIAS.Size = new System.Drawing.Size(104, 13);
            this.TRANSFERENCIAS.TabIndex = 24;
            this.TRANSFERENCIAS.Text = "TRANSFERENCIAS";
            // 
            // cbResponsableRecibe
            // 
            this.cbResponsableRecibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsableRecibe.FormattingEnabled = true;
            this.cbResponsableRecibe.Location = new System.Drawing.Point(200, 414);
            this.cbResponsableRecibe.Name = "cbResponsableRecibe";
            this.cbResponsableRecibe.Size = new System.Drawing.Size(149, 21);
            this.cbResponsableRecibe.TabIndex = 23;
            // 
            // cbResponsableEntrega
            // 
            this.cbResponsableEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsableEntrega.FormattingEnabled = true;
            this.cbResponsableEntrega.Location = new System.Drawing.Point(42, 414);
            this.cbResponsableEntrega.Name = "cbResponsableEntrega";
            this.cbResponsableEntrega.Size = new System.Drawing.Size(137, 21);
            this.cbResponsableEntrega.TabIndex = 22;
            // 
            // cbUbicacionDestino
            // 
            this.cbUbicacionDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbicacionDestino.FormattingEnabled = true;
            this.cbUbicacionDestino.Location = new System.Drawing.Point(200, 297);
            this.cbUbicacionDestino.Name = "cbUbicacionDestino";
            this.cbUbicacionDestino.Size = new System.Drawing.Size(149, 21);
            this.cbUbicacionDestino.TabIndex = 21;
            // 
            // cbUbicacionOrigen
            // 
            this.cbUbicacionOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbicacionOrigen.FormattingEnabled = true;
            this.cbUbicacionOrigen.Location = new System.Drawing.Point(42, 297);
            this.cbUbicacionOrigen.Name = "cbUbicacionOrigen";
            this.cbUbicacionOrigen.Size = new System.Drawing.Size(137, 21);
            this.cbUbicacionOrigen.TabIndex = 20;
            // 
            // cbEquipo
            // 
            this.cbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(130, 189);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(96, 21);
            this.cbEquipo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Entrega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Recibe";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Origen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "RESPONSABLE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UBICACION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "EQUIPO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // datetimeFechaTransferencia
            // 
            this.datetimeFechaTransferencia.Location = new System.Drawing.Point(12, 59);
            this.datetimeFechaTransferencia.Name = "datetimeFechaTransferencia";
            this.datetimeFechaTransferencia.Size = new System.Drawing.Size(167, 20);
            this.datetimeFechaTransferencia.TabIndex = 11;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btEliminar.Location = new System.Drawing.Point(259, 473);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(90, 38);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btEditar.Location = new System.Drawing.Point(144, 472);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(80, 36);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(22, 472);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(92, 35);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(183, 111);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(177, 20);
            this.txtObservaciones.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observaciones";
            // 
            // txtDocumentoRespaldo
            // 
            this.txtDocumentoRespaldo.Location = new System.Drawing.Point(9, 111);
            this.txtDocumentoRespaldo.Name = "txtDocumentoRespaldo";
            this.txtDocumentoRespaldo.Size = new System.Drawing.Size(170, 20);
            this.txtDocumentoRespaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento_respaldo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(185, 59);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(175, 20);
            this.txtMotivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha_Transferencia";
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
            this.dataGridView1.Size = new System.Drawing.Size(436, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // TranferenciasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 535);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TranferenciasFrm";
            this.Text = "TranferenciasFrm";
            this.Load += new System.EventHandler(this.TranferenciasFrm_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentoRespaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker datetimeFechaTransferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbResponsableRecibe;
        private System.Windows.Forms.ComboBox cbResponsableEntrega;
        private System.Windows.Forms.ComboBox cbUbicacionDestino;
        private System.Windows.Forms.ComboBox cbUbicacionOrigen;
        private System.Windows.Forms.Label TRANSFERENCIAS;
    }
}