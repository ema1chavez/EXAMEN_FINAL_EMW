namespace WindowsFormsApp1
{
    partial class UbicacionesFrm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttEliminar = new System.Windows.Forms.Button();
            this.buttEditar = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.textbDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbPiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbArea = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.buttEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.buttEditar);
            this.splitContainer1.Panel1.Controls.Add(this.buttGuardar);
            this.splitContainer1.Panel1.Controls.Add(this.textbDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textbPiso);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textbArea);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 192);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Edificio_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UBICACION DE EQUIPOS";
            // 
            // buttEliminar
            // 
            this.buttEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttEliminar.Location = new System.Drawing.Point(319, 121);
            this.buttEliminar.Name = "buttEliminar";
            this.buttEliminar.Size = new System.Drawing.Size(79, 33);
            this.buttEliminar.TabIndex = 8;
            this.buttEliminar.Text = "Eliminar";
            this.buttEliminar.UseVisualStyleBackColor = false;
            // 
            // buttEditar
            // 
            this.buttEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttEditar.Location = new System.Drawing.Point(319, 80);
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(78, 35);
            this.buttEditar.TabIndex = 7;
            this.buttEditar.Text = "Editar";
            this.buttEditar.UseVisualStyleBackColor = false;
            // 
            // buttGuardar
            // 
            this.buttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttGuardar.Location = new System.Drawing.Point(321, 39);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(77, 35);
            this.buttGuardar.TabIndex = 6;
            this.buttGuardar.Text = "Guardar";
            this.buttGuardar.UseVisualStyleBackColor = false;
            // 
            // textbDescripcion
            // 
            this.textbDescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbDescripcion.Location = new System.Drawing.Point(12, 134);
            this.textbDescripcion.Name = "textbDescripcion";
            this.textbDescripcion.Size = new System.Drawing.Size(286, 20);
            this.textbDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // textbPiso
            // 
            this.textbPiso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbPiso.Location = new System.Drawing.Point(161, 77);
            this.textbPiso.Name = "textbPiso";
            this.textbPiso.Size = new System.Drawing.Size(137, 20);
            this.textbPiso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Piso";
            // 
            // textbArea
            // 
            this.textbArea.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbArea.Location = new System.Drawing.Point(12, 77);
            this.textbArea.Name = "textbArea";
            this.textbArea.Size = new System.Drawing.Size(121, 20);
            this.textbArea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
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
            this.dataGridView1.Size = new System.Drawing.Size(394, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // UbicacionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UbicacionesFrm";
            this.Text = "UbicacionesFrm";
            this.Load += new System.EventHandler(this.UbicacionesFrm_Load);
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
        private System.Windows.Forms.TextBox textbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.TextBox textbDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbPiso;
        private System.Windows.Forms.Button buttEliminar;
        private System.Windows.Forms.Button buttEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}