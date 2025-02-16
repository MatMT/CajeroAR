/*
 * DESARROLLO DE HABILIDADES - GUÍA 4 PED104G08L
 * 
 * Oscar Mateo Elías López      - EL232710
 * Javier Enrique Mejía Flores  - MF232724
 * 
 */

using System;

namespace CajeroAR
{
    public class ColaCliente
    {
        // declaración de atributos para la clase ColaCliente
        private Cliente clienteInic = null; // determina el primer cliente en la cola
        private Cliente clienteFin = null; // determina el último cliente en la cola
        private int totalClientes = 0; // controla el número de clientes en la cola

        // Constructor para la clase (sin parámetros para inicializar la cola)
        public ColaCliente() { }

        // Método para obtener al primer cliente en cola
        public Cliente ClienteInc()
        {
            if(!EstaVacia()) // comprobamos que la cola no esté vacía
            {
                return clienteInic; // retornamos al primer cliente
            }

            return null; // si la cola está vacía, devolvemos null
        }

        // Método para obtener el número de clientes en la cola
        public int TotalClientes()
        {
            return this.totalClientes;
        }

        // Método para agregar cliente
        public void AgregarCli(Cliente nodo) // recibimos el parámetro del cliente que se desea agregar
        {
            if (EstaVacia()) // si la cola está vacía
                clienteInic = clienteFin = nodo; // el cliente a agregar será tanto el primero como el último en la cola
            else // en cambio, si la lista no está vacía, agregamos el cliente al final
            {
                clienteFin.clienteSig = nodo; // nuestro ultimo cliente actual estará apuntando al nuevo cliente
                clienteFin = nodo; // con eso, ahora nuestro último cliente será el que deseamos agregar
            }

            totalClientes++; // incrementamos el total de clientes en cola
        }

        // Método para remover un cliente de la cola
        public Cliente RemoverCli()
        {
            Cliente clienteAux = null; // Cliente a remover (auxiliar)

            if (!EstaVacia()) // validamos que la lista no esté vacía
            {
                clienteAux = clienteInic; // capturamos al cliente en la primera posición en nuestro auxiliar
                clienteInic = clienteInic.clienteSig; // 
                totalClientes--;

                // Si la cola queda vacía
                if (clienteInic == null) clienteFin = clienteInic;
            }

            // si se desea procesar el objeto eliminando, lo devolvemos
            return clienteAux; // si la cola está vacía, retorna null
        }

        // Método para 
        public void AnotarClientesEn(ListBox VistaClientes)
        {
            // Limpiar la lista para volver a imprimir
            VistaClientes.Items.Clear();

            if (EstaVacia()) // Si la cola está vacía
            {
                VistaClientes.Items.Add("SIN CLIENTES");
                return;
            }

            // Asignamos un auxiliar con el valor del primer cliente
            Cliente clienteAux = clienteInic;

            // En un ciclo repetitivo, anotamos los clientes
            while(clienteAux != null )
            {
                VistaClientes.Items.Add(clienteAux.NombreCompleto()); // agregamos un ítem con el nombre completo del cliente
                clienteAux = clienteAux.clienteSig; // apuntamos al siguiente cliente
            }
        }

        // Método para determinar si la lista está vacía
        public bool EstaVacia()
        {
            // Retorna true si se cumple la condición
            return clienteInic == null; 
        }
    }

}