namespace CajeroAR
{
    public partial class CajeroAR : Form
    {
        private Cajero cajeroME;
        private Cajero cajeroJM;
        private Cajero cajeroMC;

        public CajeroAR()
        {
            InitializeComponent();
        }

        private void btnAbrirSucursal_Click(object sender, EventArgs e)
        {
            // Inicializar a los cajeros
            cajeroME = new Cajero("Mateo", "Elias", lbCajero1, lbClientesAtendidos, lblTiempoCajero1);
            cajeroJM = new Cajero("Javier", "Mejia", lbCajero2, lbClientesAtendidos, lblTiempoCajero2);
            cajeroMC = new Cajero("Martin", "Carbajal", lbCajero3, lbClientesAtendidos, lblTiempoCajero3);

            lblCajero1.Text = cajeroME.NombreCompleto();
            lblCajero2.Text = cajeroJM.NombreCompleto();
            lblCajero3.Text = cajeroMC.NombreCompleto();

            btnAbrirSucursal.Enabled = false;
            btnAgregarCola.Enabled = true;
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor ingresa el Nombre y Apellido del cliente");
                return;
            }

            // Crear al nuevo cliente
            Cliente nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text);

            // Obtener el cajero con menos clientes
            Cajero cajeroSeleccionado = ObtenerCajeroMenosClientes();
            cajeroSeleccionado.EncolarCliente(nuevoCliente);

            // Limpiar los campos
            txtNombre.Clear();
            txtApellido.Clear();
            txtNombre.Focus();
        }

        private Cajero ObtenerCajeroMenosClientes()
        {
            return new[] { cajeroME, cajeroJM, cajeroMC }
                .OrderBy(c => c.contarClientesColaAtencion())
                .First();
        }
    }
}