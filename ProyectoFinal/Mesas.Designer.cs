namespace ProyectoFinal
{
    partial class frmMesas
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
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(555, 108);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersWidth = 51;
            this.dgvMesas.RowTemplate.Height = 29;
            this.dgvMesas.Size = new System.Drawing.Size(662, 483);
            this.dgvMesas.TabIndex = 28;
            this.dgvMesas.Click += new System.EventHandler(this.dgvMesas_Click);
            this.dgvMesas.DoubleClick += new System.EventHandler(this.dgvMesas_DoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 49);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(383, 542);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 49);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownHeight = 200;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.IntegralHeight = false;
            this.cbxEstado.ItemHeight = 28;
            this.cbxEstado.Items.AddRange(new object[] {
            "disponible",
            "ocupada",
            "reservada",
            "en limpieza"});
            this.cbxEstado.Location = new System.Drawing.Point(24, 395);
            this.cbxEstado.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxEstado.MinimumSize = new System.Drawing.Size(245, 0);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(245, 36);
            this.cbxEstado.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(27, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Numero de mesa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(282, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Capacidad";
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroMesa.Location = new System.Drawing.Point(27, 296);
            this.txtNumeroMesa.MaximumSize = new System.Drawing.Size(245, 40);
            this.txtNumeroMesa.MinimumSize = new System.Drawing.Size(245, 40);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(245, 40);
            this.txtNumeroMesa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ubicacion";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidad.Location = new System.Drawing.Point(282, 296);
            this.txtCapacidad.MaximumSize = new System.Drawing.Size(245, 40);
            this.txtCapacidad.MinimumSize = new System.Drawing.Size(245, 40);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(245, 40);
            this.txtCapacidad.TabIndex = 17;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacion.Location = new System.Drawing.Point(24, 203);
            this.txtUbicacion.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtUbicacion.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(500, 40);
            this.txtUbicacion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(24, 108);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(500, 40);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mesas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(972, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id Mesa";
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdMesa.Location = new System.Drawing.Point(972, 55);
            this.txtIdMesa.MaximumSize = new System.Drawing.Size(245, 40);
            this.txtIdMesa.MinimumSize = new System.Drawing.Size(245, 40);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(245, 40);
            this.txtIdMesa.TabIndex = 29;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(89, 542);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 49);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 613);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdMesa);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroMesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.frmMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMesas;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbxEstado;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox txtNumeroMesa;
        private Label label3;
        private TextBox txtCapacidad;
        private TextBox txtUbicacion;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label9;
        private TextBox txtIdMesa;
        private Button btnEliminar;
    }
}