using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// usa a la clase Timer
using System.Windows.Forms;

namespace CajeroAR
{
    public class Cajero
    {
        private string nom;
        private string apell;
        private EstadoCajero estado = EstadoCajero.disponible;
        private ColaCliente? colaAtencion;
        private int tiempoAtencion;
        private System.Windows.Forms.Timer relojAtencion;
        private Random? numAleatorio;
        private Cliente? clienteActual;
        private ListBox lstVistaCola;
        private ListBox lstColaSalida;
        // Propiedades añadidas para tiempo visual
        private Label lblTiempoAtencion;
        private int tiempoTranscurrido;

        public Cajero(string nom, string apell, ListBox VistaCola, ListBox ClientesServidos)
        {
            this.nom = nom;
            this.apell = apell;
            lstVistaCola = VistaCola;
            lstColaSalida = ClientesServidos;

            // Inicializar objetos auxiliares
            colaAtencion = new ColaCliente();
            numAleatorio = new Random();
            relojAtencion = new System.Windows.Forms.Timer();

            // Relacionar el evento Tick con Finalizar Cliente
            relojAtencion.Tick += new EventHandler(FinalizarCliente);

        }

        public Cajero(string nom, string apell, ListBox VistaCola, ListBox ClientesServidos, Label LblTiempo)
        {
            this.nom = nom;
            this.apell = apell;
            lstVistaCola = VistaCola;
            lstColaSalida = ClientesServidos;
            lblTiempoAtencion = LblTiempo;

            // Inicializar objetos auxiliares
            colaAtencion = new ColaCliente();
            numAleatorio = new Random();
            relojAtencion = new System.Windows.Forms.Timer();
            relojAtencion.Interval = 1000;  
            relojAtencion.Start();  

            // Relacionar el evento Tick con Finalizar Cliente
            relojAtencion.Tick += new EventHandler(ActualizarTiempo);
            relojAtencion.Tick += new EventHandler(FinalizarCliente);

        }

        // Agrega el nodo recibido a su cola de clientes.
        public void EncolarCliente(Cliente NueCli)
        {
            // Agregar el cliente a la cola del cajero
            colaAtencion.AgregarCli(NueCli);
            colaAtencion.AnotarClientes(lstVistaCola);

            if(estado == EstadoCajero.disponible)
            {
                AtenderCliente();
            }
        }

        public void AtenderCliente()
        {
            // Si la cola esta vacia y el estado del cajero es diferente a disponible
            // if(colaAtencion.EstaVacia() || estado == EstadoCajero.disponible)
            if(estado == EstadoCajero.disponible) {
                // El cajero ahora esta atendiendo a un cliente
                estado = EstadoCajero.atendiendo;
                clienteActual = colaAtencion.ClienteInc();

                // Se genera un nuevo tiempo de atención
                tiempoAtencion = GenerarSemilla();

                // Configurar e iniciar el nuevo timer
                relojAtencion.Interval = tiempoAtencion;
                relojAtencion.Start();
            }
        }

        private int GenerarSemilla()
        {
            if (numAleatorio == null)
                throw new ArgumentNullException(nameof(numAleatorio), "El generador de números aleatorios no ha sido inicializado.");

            // (10000 a 50001 ms)
            return numAleatorio.Next(10000, 15001);
        }

        private void FinalizarCliente(object sender,  EventArgs e)
        {
            if (clienteActual == null)
            {
                return;
            }

            // Detener el timer
            relojAtencion.Stop();

            // El cliente es atendido y este sale de la cola de atención
            clienteActual = colaAtencion.RemoverCli();
            colaAtencion.AnotarClientes(lstVistaCola);

            // Mover cliente a la lista de atendidos
            lstColaSalida.Items.Add(clienteActual.NombreCompleto());

            // El cajero ahora se encuentra disponible para atender
            estado = EstadoCajero.disponible;
            lblTiempoAtencion.Text = "Esperando cliente...";
            clienteActual = null;

            // Si la cola no esta vacia y hay más por atender
            if (!colaAtencion.EstaVacia())
            {
                AtenderCliente();
            }
        }

        // Métodos auxiliares añadidos

        private void ActualizarTiempo(object sender, EventArgs e)
        {
            tiempoTranscurrido++;
            lblTiempoAtencion.Text = $"Tiempo: {tiempoTranscurrido} s";

            return;
            if (estado == EstadoCajero.atendiendo && clienteActual != null)
            {
                tiempoTranscurrido += 1000; 
                int segundosRestantes = (tiempoAtencion - tiempoTranscurrido) / 1000;
                lblTiempoAtencion.Text = $"Tiempo restante: {segundosRestantes} segundos";
            }
            else
            {
                lblTiempoAtencion.Text = "Esperando clientes...";
            }
        }

        public int contarClientesColaAtencion()
        {
            return colaAtencion.TotalClientes();
        }

        public string NombreCompleto()
        {
            return $"{this.nom} {this.apell}";
        }

    }
}
