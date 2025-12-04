namespace WindowsFormsApp1
{
    partial class TipoEquipoFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttEliminar = new System.Windows.Forms.Button();
            this.buttEditar = new System.Windows.Forms.Button();
            this.buttAgregar = new System.Windows.Forms.Button();
            this.textbMarca = new System.Windows.Forms.TextBox();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.labMarca = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.buttEditar);
            this.splitContainer1.Panel1.Controls.Add(this.buttAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.textbMarca);
            this.splitContainer1.Panel1.Controls.Add(this.textbNombre);
            this.splitContainer1.Panel1.Controls.Add(this.labMarca);
            this.splitContainer1.Panel1.Controls.Add(this.labNombre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(581, 159);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIPOS DE EQUIPOS";
            // 
            // buttEliminar
            // 
            this.buttEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttEliminar.Location = new System.Drawing.Point(213, 103);
            this.buttEliminar.Name = "buttEliminar";
            this.buttEliminar.Size = new System.Drawing.Size(75, 38);
            this.buttEliminar.TabIndex = 6;
            this.buttEliminar.Text = "ELIMINAR";
            this.buttEliminar.UseVisualStyleBackColor = false;
            // 
            // buttEditar
            // 
            this.buttEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttEditar.Location = new System.Drawing.Point(211, 59);
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(75, 38);
            this.buttEditar.TabIndex = 5;
            this.buttEditar.Text = "EDITAR";
            this.buttEditar.UseVisualStyleBackColor = false;
            // 
            // buttAgregar
            // 
            this.buttAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttAgregar.Location = new System.Drawing.Point(211, 15);
            this.buttAgregar.Name = "buttAgregar";
            this.buttAgregar.Size = new System.Drawing.Size(75, 38);
            this.buttAgregar.TabIndex = 4;
            this.buttAgregar.Text = "AGREGAR";
            this.buttAgregar.UseVisualStyleBackColor = false;
            // 
            // textbMarca
            // 
            this.textbMarca.Location = new System.Drawing.Point(29, 115);
            this.textbMarca.Name = "textbMarca";
            this.textbMarca.Size = new System.Drawing.Size(147, 20);
            this.textbMarca.TabIndex = 3;
            // 
            // textbNombre
            // 
            this.textbNombre.Location = new System.Drawing.Point(29, 69);
            this.textbNombre.Name = "textbNombre";
            this.textbNombre.Size = new System.Drawing.Size(147, 20);
            this.textbNombre.TabIndex = 2;
            // 
            // labMarca
            // 
            this.labMarca.AutoSize = true;
            this.labMarca.Location = new System.Drawing.Point(26, 98);
            this.labMarca.Name = "labMarca";
            this.labMarca.Size = new System.Drawing.Size(37, 13);
            this.labMarca.TabIndex = 1;
            this.labMarca.Text = "Marca";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(26, 52);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(44, 13);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre";
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
            this.dataGridView1.Size = new System.Drawing.Size(287, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // TipoEquipoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 159);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TipoEquipoFrm";
            this.Text = "TipoEquipoFrm";
            this.Load += new System.EventHandler(this.TipoEquipoFrm_Load);
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
        private System.Windows.Forms.TextBox textbMarca;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label labMarca;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttEliminar;
        private System.Windows.Forms.Button buttEditar;
        private System.Windows.Forms.Button buttAgregar;
        private System.Windows.Forms.Label label1;
    }
}