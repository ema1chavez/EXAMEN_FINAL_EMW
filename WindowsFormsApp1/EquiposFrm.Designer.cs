namespace WindowsFormsApp1
{
    partial class EquiposFrm
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
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textbObservacion = new System.Windows.Forms.TextBox();
            this.textbModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbValorAdquisicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbNumeroSerie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datetFechaUltimaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.datetFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
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
            this.splitContainer1.Panel1.Controls.Add(this.datetFechaAdquisicion);
            this.splitContainer1.Panel1.Controls.Add(this.datetFechaUltimaActualizacion);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textbObservacion);
            this.splitContainer1.Panel1.Controls.Add(this.textbModelo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textbValorAdquisicion);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textbEstado);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.textbNumeroSerie);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(824, 335);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "AGREGAR EQUIPOS";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(225, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 34;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(118, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 33;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(15, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textbObservacion
            // 
            this.textbObservacion.Location = new System.Drawing.Point(100, 204);
            this.textbObservacion.Name = "textbObservacion";
            this.textbObservacion.Size = new System.Drawing.Size(200, 20);
            this.textbObservacion.TabIndex = 30;
            // 
            // textbModelo
            // 
            this.textbModelo.Location = new System.Drawing.Point(21, 106);
            this.textbModelo.Name = "textbModelo";
            this.textbModelo.Size = new System.Drawing.Size(135, 20);
            this.textbModelo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Numero_serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // textbValorAdquisicion
            // 
            this.textbValorAdquisicion.Location = new System.Drawing.Point(114, 169);
            this.textbValorAdquisicion.Name = "textbValorAdquisicion";
            this.textbValorAdquisicion.Size = new System.Drawing.Size(186, 20);
            this.textbValorAdquisicion.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha_adquisicion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor_adquisicion";
            // 
            // textbEstado
            // 
            this.textbEstado.Location = new System.Drawing.Point(165, 106);
            this.textbEstado.Name = "textbEstado";
            this.textbEstado.Size = new System.Drawing.Size(135, 20);
            this.textbEstado.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha_ultima_actualizacion";
            // 
            // textbNumeroSerie
            // 
            this.textbNumeroSerie.Location = new System.Drawing.Point(100, 62);
            this.textbNumeroSerie.Name = "textbNumeroSerie";
            this.textbNumeroSerie.Size = new System.Drawing.Size(200, 20);
            this.textbNumeroSerie.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Observaciones";
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
            this.dataGridView1.Size = new System.Drawing.Size(485, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // datetFechaUltimaActualizacion
            // 
            this.datetFechaUltimaActualizacion.Location = new System.Drawing.Point(30, 252);
            this.datetFechaUltimaActualizacion.Name = "datetFechaUltimaActualizacion";
            this.datetFechaUltimaActualizacion.Size = new System.Drawing.Size(135, 20);
            this.datetFechaUltimaActualizacion.TabIndex = 36;
            // 
            // datetFechaAdquisicion
            // 
            this.datetFechaAdquisicion.Location = new System.Drawing.Point(118, 132);
            this.datetFechaAdquisicion.Name = "datetFechaAdquisicion";
            this.datetFechaAdquisicion.Size = new System.Drawing.Size(182, 20);
            this.datetFechaAdquisicion.TabIndex = 37;
            // 
            // EquiposFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 335);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EquiposFrm";
            this.Text = "EquiposFrm";
            this.Load += new System.EventHandler(this.EquiposFrm_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbObservacion;
        private System.Windows.Forms.TextBox textbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbValorAdquisicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbNumeroSerie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker datetFechaUltimaActualizacion;
        private System.Windows.Forms.DateTimePicker datetFechaAdquisicion;
    }
}