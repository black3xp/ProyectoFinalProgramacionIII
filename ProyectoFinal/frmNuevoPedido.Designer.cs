namespace ProyectoFinal
{
    partial class frmNuevoPedido
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
            this.dgvNuevoPedido = new System.Windows.Forms.DataGridView();
            this.MenuPlatoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxMesa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.timeHora = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNuevoPedido
            // 
            this.dgvNuevoPedido.AllowUserToAddRows = false;
            this.dgvNuevoPedido.AllowUserToDeleteRows = false;
            this.dgvNuevoPedido.AllowUserToResizeColumns = false;
            this.dgvNuevoPedido.AllowUserToResizeRows = false;
            this.dgvNuevoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuevoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuPlatoId,
            this.Cantidad,
            this.Descripcion,
            this.Precio});
            this.dgvNuevoPedido.Location = new System.Drawing.Point(555, 114);
            this.dgvNuevoPedido.Name = "dgvNuevoPedido";
            this.dgvNuevoPedido.ReadOnly = true;
            this.dgvNuevoPedido.RowHeadersVisible = false;
            this.dgvNuevoPedido.RowHeadersWidth = 51;
            this.dgvNuevoPedido.RowTemplate.Height = 29;
            this.dgvNuevoPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuevoPedido.Size = new System.Drawing.Size(662, 483);
            this.dgvNuevoPedido.TabIndex = 42;
            // 
            // MenuPlatoId
            // 
            this.MenuPlatoId.HeaderText = "MenuPlatoId";
            this.MenuPlatoId.MinimumWidth = 6;
            this.MenuPlatoId.Name = "MenuPlatoId";
            this.MenuPlatoId.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 49);
            this.button2.TabIndex = 41;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 40;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxMesa
            // 
            this.cbxMesa.DropDownHeight = 200;
            this.cbxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMesa.FormattingEnabled = true;
            this.cbxMesa.IntegralHeight = false;
            this.cbxMesa.ItemHeight = 28;
            this.cbxMesa.Location = new System.Drawing.Point(21, 402);
            this.cbxMesa.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxMesa.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(100, 36);
            this.cbxMesa.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(21, 303);
            this.txtDireccion.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtDireccion.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(500, 40);
            this.txtDireccion.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Detalles / Observaciones";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Location = new System.Drawing.Point(21, 208);
            this.txtDetalles.MaximumSize = new System.Drawing.Size(500, 40);
            this.txtDetalles.MinimumSize = new System.Drawing.Size(500, 40);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(500, 40);
            this.txtDetalles.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(970, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "No. Pedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPedido.Location = new System.Drawing.Point(970, 59);
            this.txtIdPedido.MaximumSize = new System.Drawing.Size(245, 40);
            this.txtIdPedido.MinimumSize = new System.Drawing.Size(245, 40);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(245, 40);
            this.txtIdPedido.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 40);
            this.button3.TabIndex = 46;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(21, 114);
            this.txtCliente.MaximumSize = new System.Drawing.Size(200, 40);
            this.txtCliente.MinimumSize = new System.Drawing.Size(350, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(350, 40);
            this.txtCliente.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cliente";
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
            "Nuevo pedido",
            "En proceso",
            "Realizado"});
            this.cbxEstado.Location = new System.Drawing.Point(279, 402);
            this.cbxEstado.MaximumSize = new System.Drawing.Size(245, 0);
            this.cbxEstado.MinimumSize = new System.Drawing.Size(245, 0);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(245, 36);
            this.cbxEstado.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(279, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Estado";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(686, 59);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(136, 40);
            this.dtFecha.TabIndex = 50;
            // 
            // timeHora
            // 
            this.timeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHora.Location = new System.Drawing.Point(828, 59);
            this.timeHora.MinimumSize = new System.Drawing.Size(0, 40);
            this.timeHora.Name = "timeHora";
            this.timeHora.Size = new System.Drawing.Size(136, 40);
            this.timeHora.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(500, 40);
            this.button4.TabIndex = 53;
            this.button4.Text = "Agregar menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAgregarMesa
            // 
            this.btnAgregarMesa.Location = new System.Drawing.Point(127, 402);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.Size = new System.Drawing.Size(94, 36);
            this.btnAgregarMesa.TabIndex = 54;
            this.btnAgregarMesa.Tag = "agregar";
            this.btnAgregarMesa.Text = "+";
            this.btnAgregarMesa.UseVisualStyleBackColor = true;
            this.btnAgregarMesa.Click += new System.EventHandler(this.btnAgregarMesa_Click);
            // 
            // frmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 618);
            this.Controls.Add(this.btnAgregarMesa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.timeHora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.dgvNuevoPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxMesa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label1);
            this.Name = "frmNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNuevoPedido_FormClosed);
            this.Load += new System.EventHandler(this.frmNuevoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvNuevoPedido;
        private Button button2;
        private Button button1;
        private ComboBox cbxMesa;
        private Label label5;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtDetalles;
        private Label label1;
        private Label label4;
        private TextBox txtIdPedido;
        private Button button3;
        private TextBox txtCliente;
        private Label label6;
        private ComboBox cbxEstado;
        private Label label9;
        private DateTimePicker dtFecha;
        private DateTimePicker timeHora;
        private Button button4;
        private DataGridViewTextBoxColumn MenuPlatoId;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Button btnAgregarMesa;
    }
}