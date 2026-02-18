namespace _2doparcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.Producto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.buttonCobrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Location = new System.Drawing.Point(40, 29);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(44, 13);
            this.labelClientes.TabIndex = 1;
            this.labelClientes.Text = "Clientes";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(43, 58);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(43, 93);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(42, 13);
            this.labelImporte.TabIndex = 3;
            this.labelImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(100, 93);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 4;
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(40, 133);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 5;
            this.Producto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(100, 133);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 6;
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.Location = new System.Drawing.Point(43, 179);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(91, 23);
            this.buttonAgregarCliente.TabIndex = 7;
            this.buttonAgregarCliente.Text = "Agregar Cliente";
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // buttonCobrar
            // 
            this.buttonCobrar.Location = new System.Drawing.Point(141, 178);
            this.buttonCobrar.Name = "buttonCobrar";
            this.buttonCobrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCobrar.TabIndex = 8;
            this.buttonCobrar.Text = "Cobrar";
            this.buttonCobrar.UseVisualStyleBackColor = true;
            this.buttonCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clientes en Cola";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(222, 55);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(185, 225);
            this.lstCola.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCobrar);
            this.Controls.Add(this.buttonAgregarCliente);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.Button buttonCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCola;
    }
}

