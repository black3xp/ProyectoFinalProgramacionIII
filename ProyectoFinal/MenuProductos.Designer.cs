namespace ProyectoFinal
{
    partial class frmMenuProductos
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
            this.dgvMenusPlatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxRestricciones = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxDisponibilidad = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdPlato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenusPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenusPlatos
            // 
            this.dgvMenusPlatos.AllowUserToAddRows = false;
            this.dgvMenusPlatos.AllowUserToDeleteRows = false;
            this.dgvMenusPlatos.AllowUserToResizeColumns = false;
            this.dgvMenusPlatos.AllowUserToResizeRows = false;
            this.dgvMenusPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMenusPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenusPlatos.Location = new System.Drawing.Point(566, 122);
            this.dgvMenusPlatos.Name = "dgvMenusPlatos";
            this.dgvMenusPlatos.ReadOnly = true;
            this.dgvMenusPlatos.RowHeadersVisible = false;
            this.dgvMenusPlatos.RowHeadersWidth = 51;
            this.dgvMenusPlatos.RowTemplate.Height = 29;
            this.dgvMenusPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenusPlatos.Size = new System.Drawing.Size(662, 578);
            this.dgvMenusPlatos.TabIndex = 28;
            this.dgvMenusPlatos.Click += new System.EventHandler(this.dgvMenusPlatos_Click);
            this.dgvMenusPlatos.DoubleClick += new System.EventHandler(this.dgvMenusPlatos_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(235, 651);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 49);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(382, 651);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 49);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxRestricciones
            // 
            this.cbxRestricciones.DropDownHeight = 245;
            this.cbxRestricciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRestricciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRestricciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxRestricciones.FormattingEnabled = true;
            this.cbxRestricciones.IntegralHeight = false;
            this.cbxRestricciones.ItemHeight = 28;
            this.cbxRestricciones.Items.AddRange(new object[] {
            "sin restricciones",
            "vegetariano",
            "vegano",
            "sin gluten"});
            this.cbxRestricciones.Location = new System.Drawing.Point(23, 409);
            this.cbxRestricciones.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxRestricciones.MinimumSize = new System.Drawing.Size(245, 0);
            this.cbxRestricciones.Name = "cbxRestricciones";
            this.cbxRestricciones.Size = new System.Drawing.Size(245, 36);
            this.cbxRestricciones.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Restricciones dietéticas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(278, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingredientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(278, 409);
            this.txtPrecio.MaximumSize = new System.Drawing.Size(245, 40);
            this.txtPrecio.MinimumSize = new System.Drawing.Size(245, 40);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(245, 40);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientes.Location = new System.Drawing.Point(23, 314);
            this.txtIngredientes.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtIngredientes.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(500, 40);
            this.txtIngredientes.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(23, 217);
            this.txtDescripcion.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtDescripcion.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(500, 40);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del plato";
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePlato.Location = new System.Drawing.Point(23, 122);
            this.txtNombrePlato.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtNombrePlato.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(500, 40);
            this.txtNombrePlato.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu de platos";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownHeight = 245;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.ItemHeight = 28;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Entrantes",
            "Postres",
            "Bebidas",
            "Menú infantil",
            "Vegetariano",
            "Especiales del chef",
            "Promociones"});
            this.cbxCategoria.Location = new System.Drawing.Point(20, 499);
            this.cbxCategoria.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxCategoria.MinimumSize = new System.Drawing.Size(245, 0);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(245, 36);
            this.cbxCategoria.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(278, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Disponibilidad";
            // 
            // cbxDisponibilidad
            // 
            this.cbxDisponibilidad.DropDownHeight = 245;
            this.cbxDisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDisponibilidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxDisponibilidad.FormattingEnabled = true;
            this.cbxDisponibilidad.IntegralHeight = false;
            this.cbxDisponibilidad.ItemHeight = 28;
            this.cbxDisponibilidad.Items.AddRange(new object[] {
            "disponible",
            "agotado",
            "temporalmente no disponible"});
            this.cbxDisponibilidad.Location = new System.Drawing.Point(275, 499);
            this.cbxDisponibilidad.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxDisponibilidad.MinimumSize = new System.Drawing.Size(245, 0);
            this.cbxDisponibilidad.Name = "cbxDisponibilidad";
            this.cbxDisponibilidad.Size = new System.Drawing.Size(245, 36);
            this.cbxDisponibilidad.TabIndex = 25;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(88, 651);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(141, 49);
            this.btnSeleccionar.TabIndex = 30;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(927, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(927, 69);
            this.txtBuscar.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtBuscar.MinimumSize = new System.Drawing.Size(300, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 40);
            this.txtBuscar.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(708, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Id Plato";
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPlato.Location = new System.Drawing.Point(708, 69);
            this.txtIdPlato.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtIdPlato.MinimumSize = new System.Drawing.Size(200, 40);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.Size = new System.Drawing.Size(200, 40);
            this.txtIdPlato.TabIndex = 33;
            // 
            // frmMenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 719);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIdPlato);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvMenusPlatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxDisponibilidad);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxRestricciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombrePlato);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProductos";
            this.Load += new System.EventHandler(this.frmMenuProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenusPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMenusPlatos;
        private Button btnEliminar;
        private Button btnGuardar;
        private ComboBox cbxRestricciones;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtPrecio;
        private TextBox txtIngredientes;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombrePlato;
        private Label label1;
        private ComboBox cbxCategoria;
        private Label label9;
        private ComboBox cbxDisponibilidad;
        private Button btnSeleccionar;
        private Label label10;
        private TextBox txtBuscar;
        private Label label11;
        private TextBox txtIdPlato;
    }
}