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

        // Propiedades adicionales
        private Label lblNombreCajero; // etiqueta para manipular la apariencia del encabezado del cajero
        private Label lblTiempoAtencion; // etiqueta para mostrar el tiempo de atención de cada cliente
        private int tiempoTranscurrido; // indicador del tiempo de atención que ha transcurrido para el cliente

        public Cajero(string nom, string apell, ListBox VistaCola, ListBox ClientesServidos, Label LblTiempo, Label LblNombre)
        {
            this.nom = nom;
            this.apell = apell;
            lstVistaCola = VistaCola;
            lstColaSalida = ClientesServidos;
            lblTiempoAtencion = LblTiempo;
            lblNombreCajero = LblNombre;

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
            colaAtencion.AnotarClientesEn(lstVistaCola);

            if(estado == EstadoCajero.disponible)
            {
                AtenderCliente();
            }
        }

        public void AtenderCliente()
        {
            // Si la cola esta vacia y el estado del cajero es diferente a disponible
            // if(colaAtencion.EstaVacia() || estado == EstadoCajero.disponible)
            if(estado == EstadoCajero.disponible && !colaAtencion.EstaVacia()) {
                // El cajero ahora esta atendiendo a un cliente
                estado = EstadoCajero.atendiendo;
                clienteActual = colaAtencion.ClienteInc();

                // Se genera un nuevo tiempo de atención
                tiempoAtencion = GenerarSemilla();
                tiempoTranscurrido = 0;

                // Mostrar tiempo inicial
                lblTiempoAtencion.Text = $"Tiempo restante: {tiempoAtencion / 1000}s";

                // Iniciar el timer con intervalo de 1 segundo
                relojAtencion.Start();

                // Cambiar colores a naranja cuando está atendiendo
                lblNombreCajero.BackColor = Color.Orange;
                lblTiempoAtencion.BackColor = Color.Orange;
            }
        }

        private int GenerarSemilla()
        {
            if (numAleatorio == null)
                throw new ArgumentNullException(nameof(numAleatorio), "El generador de números aleatorios no ha sido inicializado.");

            // Tiempo aleatorio para demostración 10s-50s (10000 a 50000 ms)
            return numAleatorio.Next(10000, 50000);
        }

        private void FinalizarCliente(object sender,  EventArgs e)
        {
            if (clienteActual == null)
            {
                return;
            }

            // Verificar si se alcanzó el tiempo de atención
            if (tiempoTranscurrido >= tiempoAtencion)
            {
                // Detener el timer
                relojAtencion.Stop();

                // El cliente es atendido y este sale de la cola de atención
                clienteActual = colaAtencion.RemoverCli();
                colaAtencion.AnotarClientesEn(lstVistaCola);

                // Mover cliente a la lista de atendidos
                lstColaSalida.Items.Add(clienteActual.NombreCompleto());

                // El cajero ahora se encuentra disponible para atender
                lblNombreCajero.BackColor = Color.Green;
                lblTiempoAtencion.BackColor = Color.Green;
                estado = EstadoCajero.disponible;
                lblTiempoAtencion.Text = "Esperando cliente...";
                clienteActual = null;
                tiempoTranscurrido = 0;

                // Si la cola no esta vacia y hay más por atender
                if (!colaAtencion.EstaVacia())
                {
                    AtenderCliente();
                }
            }
        }

        // Métodos auxiliares

        /*
         * Método adicional para mostrar el tiempo de atención restante para cada cliente,
         * este método se encarga de actualizar el contador de manera visual para saber cuánto
         * tiempo falta para que el próximo cliente sea atendido
         */
        private void ActualizarTiempo(object sender, EventArgs e)
        {
            // Verificar que SÍ se está atendiendo a un cliente
            if (estado == EstadoCajero.atendiendo && clienteActual != null)
            {
                tiempoTranscurrido += 1000; // Incrementar el contador de tiempo transcurrido en 1s para coincidir con el Interval del timer
                int segundosRestantes = (tiempoAtencion - tiempoTranscurrido) / 1000; // Calcular segundos restantes dividiendo entre 1000 para convertir de milisegundos a segundos

                // Solo actualizar el texto si quedan segundos positivos
                if (segundosRestantes >= 0)
                {
                    lblTiempoAtencion.Text = $"Tiempo restante: {segundosRestantes}s";
                }
            }
            else // Si no, indicar que se está esperando a atender un cliente
            {
                lblTiempoAtencion.Text = "Esperando cliente...";
            }
        }

        /*
         * Método auxiliar para conocer el total de clientes en la cola
         */
        public int contarClientesColaAtencion()
        {
            return colaAtencion.TotalClientes();
        }

        /*
         * Método auxiliar para concatenar el nombre y apellido de los clientes
         */
        public string NombreCompleto()
        {
            return $"{this.nom} {this.apell}";
        }

    }
}
