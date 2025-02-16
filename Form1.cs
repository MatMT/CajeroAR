/*
 * DESARROLLO DE HABILIDADES - GU�A 4 PED104G08L
 * 
 * Oscar Mateo El�as L�pez      - EL232710
 * Javier Enrique Mej�a Flores  - MF232724
 * 
 */

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
            cajeroME = new Cajero("Mateo", "Elias", lbCajero1, lbClientesAtendidos, lblTiempoCajero1, lblCajero1);
            cajeroJM = new Cajero("Javier", "Mejia", lbCajero2, lbClientesAtendidos, lblTiempoCajero2, lblCajero2);
            cajeroMC = new Cajero("Martin", "Carbajal", lbCajero3, lbClientesAtendidos, lblTiempoCajero3, lblCajero3);

            lblCajero1.Text = cajeroME.NombreCompleto();
            lblCajero2.Text = cajeroJM.NombreCompleto();
            lblCajero3.Text = cajeroMC.NombreCompleto();

            btnAbrirSucursal.Enabled = false;
            btnAgregarCola.Enabled = btnDemo.Enabled = true;

            lblCajero1.BackColor = lblCajero2.BackColor = lblCajero3.BackColor = lblTiempoCajero1.BackColor = lblTiempoCajero2.BackColor = lblTiempoCajero3.BackColor = Color.Green;
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

            // Desactivar opci�n de Demostraci�n �gil
            btnDemo.Visible = false;
        }

        private Cajero ObtenerCajeroMenosClientes()
        {
            return new[] { cajeroME, cajeroJM, cajeroMC }
                .OrderBy(c => c.contarClientesColaAtencion())
                .First();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmaci�n
            DialogResult respuesta = MessageBox.Show(
                "�Desea iniciar la demostraci�n? Se agregar�n clientes de prueba.",
                "Confirmar Demostraci�n",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Cancel) return;

            // Si el usuario confirma, procedemos con la demo
            if (respuesta == DialogResult.OK)
            {
                // Ocultar el bot�n de demo
                btnDemo.Visible = false;

                // Crear y agregar los 15 clientes
                Cliente nuevoCliente;

                nuevoCliente = new Cliente("Eleazar", "Amaya");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Pedro", "Infante");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Luis", "Miguel");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Marcelo", "Menj�var");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Daniela", "Mart�nez");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Hazel", "Moreno");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("V�ctor", "Garc�a");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Maggie", "Murillo");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Ronald", "Nolasco");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Brandon", "Zepeda");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Mar�a", "Gutierrez");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Diana", "Flores");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Harold", "Merino");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Flor", "Salazar");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();

                nuevoCliente = new Cliente("Eleonora", "Marroqu�n");
                ObtenerCajeroMenosClientes().EncolarCliente(nuevoCliente);
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }
    }
}