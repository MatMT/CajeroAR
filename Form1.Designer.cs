namespace CajeroAR
{
    partial class CajeroAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnAbrirSucursal;
        private GroupBox gbIngresoCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Button btnAgregarCola;
        private GroupBox gbCajeros;
        private ListBox lbCajero1;
        private ListBox lbCajero2;
        private ListBox lbCajero3;
        private GroupBox gbClientesAtendidos;
        private ListBox lbClientesAtendidos;

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
            btnAbrirSucursal = new Button();
            gbIngresoCliente = new GroupBox();
            btnAgregarCola = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbCajeros = new GroupBox();
            lblTiempoCajero3 = new Label();
            lblTiempoCajero2 = new Label();
            lblTiempoCajero1 = new Label();
            lblCajero3 = new Label();
            lbCajero3 = new ListBox();
            lblCajero2 = new Label();
            lbCajero2 = new ListBox();
            lblCajero1 = new Label();
            lbCajero1 = new ListBox();
            gbClientesAtendidos = new GroupBox();
            lbClientesAtendidos = new ListBox();
            gbIngresoCliente.SuspendLayout();
            gbCajeros.SuspendLayout();
            gbClientesAtendidos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirSucursal
            // 
            btnAbrirSucursal.Location = new Point(230, 12);
            btnAbrirSucursal.Name = "btnAbrirSucursal";
            btnAbrirSucursal.Size = new Size(400, 30);
            btnAbrirSucursal.TabIndex = 0;
            btnAbrirSucursal.Text = "Abrir Sucursal";
            btnAbrirSucursal.UseVisualStyleBackColor = true;
            btnAbrirSucursal.Click += btnAbrirSucursal_Click;
            // 
            // gbIngresoCliente
            // 
            gbIngresoCliente.Controls.Add(btnAgregarCola);
            gbIngresoCliente.Controls.Add(txtApellido);
            gbIngresoCliente.Controls.Add(lblApellido);
            gbIngresoCliente.Controls.Add(txtNombre);
            gbIngresoCliente.Controls.Add(lblNombre);
            gbIngresoCliente.Location = new Point(20, 70);
            gbIngresoCliente.Name = "gbIngresoCliente";
            gbIngresoCliente.Size = new Size(200, 150);
            gbIngresoCliente.TabIndex = 1;
            gbIngresoCliente.TabStop = false;
            gbIngresoCliente.Text = "Ingreso de Cliente";
            // 
            // btnAgregarCola
            // 
            btnAgregarCola.Enabled = false;
            btnAgregarCola.Location = new Point(10, 100);
            btnAgregarCola.Name = "btnAgregarCola";
            btnAgregarCola.Size = new Size(180, 30);
            btnAgregarCola.TabIndex = 4;
            btnAgregarCola.Text = "Agregar a Cola";
            btnAgregarCola.UseVisualStyleBackColor = true;
            btnAgregarCola.Click += btnAgregarCola_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(70, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(120, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(10, 60);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbCajeros
            // 
            gbCajeros.Controls.Add(lblTiempoCajero3);
            gbCajeros.Controls.Add(lblTiempoCajero2);
            gbCajeros.Controls.Add(lblTiempoCajero1);
            gbCajeros.Controls.Add(lblCajero3);
            gbCajeros.Controls.Add(lbCajero3);
            gbCajeros.Controls.Add(lblCajero2);
            gbCajeros.Controls.Add(lbCajero2);
            gbCajeros.Controls.Add(lblCajero1);
            gbCajeros.Controls.Add(lbCajero1);
            gbCajeros.Location = new Point(230, 48);
            gbCajeros.Name = "gbCajeros";
            gbCajeros.Size = new Size(400, 390);
            gbCajeros.TabIndex = 2;
            gbCajeros.TabStop = false;
            gbCajeros.Text = "CAJEROS (Atención a Clientes)";
            // 
            // lblTiempoCajero3
            // 
            lblTiempoCajero3.AutoSize = true;
            lblTiempoCajero3.Location = new Point(266, 39);
            lblTiempoCajero3.Name = "lblTiempoCajero3";
            lblTiempoCajero3.Size = new Size(16, 15);
            lblTiempoCajero3.TabIndex = 8;
            lblTiempoCajero3.Text = "...";
            // 
            // lblTiempoCajero2
            // 
            lblTiempoCajero2.AutoSize = true;
            lblTiempoCajero2.Location = new Point(140, 39);
            lblTiempoCajero2.Name = "lblTiempoCajero2";
            lblTiempoCajero2.Size = new Size(16, 15);
            lblTiempoCajero2.TabIndex = 7;
            lblTiempoCajero2.Text = "...";
            // 
            // lblTiempoCajero1
            // 
            lblTiempoCajero1.AutoSize = true;
            lblTiempoCajero1.Location = new Point(14, 39);
            lblTiempoCajero1.Name = "lblTiempoCajero1";
            lblTiempoCajero1.Size = new Size(16, 15);
            lblTiempoCajero1.TabIndex = 6;
            lblTiempoCajero1.Text = "...";
            // 
            // lblCajero3
            // 
            lblCajero3.AutoSize = true;
            lblCajero3.Location = new Point(288, 22);
            lblCajero3.Name = "lblCajero3";
            lblCajero3.Size = new Size(50, 15);
            lblCajero3.TabIndex = 4;
            lblCajero3.Text = "Cajero 3";
            // 
            // lbCajero3
            // 
            lbCajero3.FormattingEnabled = true;
            lbCajero3.ItemHeight = 15;
            lbCajero3.Location = new Point(266, 57);
            lbCajero3.Name = "lbCajero3";
            lbCajero3.Size = new Size(120, 304);
            lbCajero3.TabIndex = 5;
            // 
            // lblCajero2
            // 
            lblCajero2.AutoSize = true;
            lblCajero2.Location = new Point(162, 22);
            lblCajero2.Name = "lblCajero2";
            lblCajero2.Size = new Size(50, 15);
            lblCajero2.TabIndex = 2;
            lblCajero2.Text = "Cajero 2";
            // 
            // lbCajero2
            // 
            lbCajero2.FormattingEnabled = true;
            lbCajero2.ItemHeight = 15;
            lbCajero2.Location = new Point(140, 57);
            lbCajero2.Name = "lbCajero2";
            lbCajero2.Size = new Size(120, 304);
            lbCajero2.TabIndex = 3;
            // 
            // lblCajero1
            // 
            lblCajero1.AutoSize = true;
            lblCajero1.Location = new Point(36, 22);
            lblCajero1.Name = "lblCajero1";
            lblCajero1.Size = new Size(50, 15);
            lblCajero1.TabIndex = 0;
            lblCajero1.Text = "Cajero 1";
            // 
            // lbCajero1
            // 
            lbCajero1.FormattingEnabled = true;
            lbCajero1.ItemHeight = 15;
            lbCajero1.Location = new Point(14, 57);
            lbCajero1.Name = "lbCajero1";
            lbCajero1.Size = new Size(120, 304);
            lbCajero1.TabIndex = 1;
            // 
            // gbClientesAtendidos
            // 
            gbClientesAtendidos.Controls.Add(lbClientesAtendidos);
            gbClientesAtendidos.Location = new Point(640, 70);
            gbClientesAtendidos.Name = "gbClientesAtendidos";
            gbClientesAtendidos.Size = new Size(140, 368);
            gbClientesAtendidos.TabIndex = 3;
            gbClientesAtendidos.TabStop = false;
            gbClientesAtendidos.Text = "Clientes ya atendidos";
            // 
            // lbClientesAtendidos
            // 
            lbClientesAtendidos.FormattingEnabled = true;
            lbClientesAtendidos.ItemHeight = 15;
            lbClientesAtendidos.Location = new Point(10, 20);
            lbClientesAtendidos.Name = "lbClientesAtendidos";
            lbClientesAtendidos.Size = new Size(120, 319);
            lbClientesAtendidos.TabIndex = 0;
            // 
            // CajeroAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirSucursal);
            Controls.Add(gbIngresoCliente);
            Controls.Add(gbCajeros);
            Controls.Add(gbClientesAtendidos);
            Name = "CajeroAR";
            Text = "CajeroAR";
            gbIngresoCliente.ResumeLayout(false);
            gbIngresoCliente.PerformLayout();
            gbCajeros.ResumeLayout(false);
            gbCajeros.PerformLayout();
            gbClientesAtendidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCajero1;
        private Label lblCajero2;
        private Label lblCajero3;
        private Label lblTiempoCajero1;
        private Label lblTiempoCajero3;
        private Label lblTiempoCajero2;
    }
}