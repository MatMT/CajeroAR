using System;

namespace CajeroAR
{
    public class ColaCliente
    {
        private Cliente clienteInic = null;
        private Cliente clienteFin = null;
        private int totalClientes = 0;

        public ColaCliente()
        {
        }

        public Cliente ClienteInc()
        {
            if(!EstaVacia())
            {
                return clienteInic;
            }

            return null;
        }

        public int TotalClientes()
        {
            return this.totalClientes;
        }

        public void AgregarCli(Cliente nodo)
        {
            if (EstaVacia())
                clienteInic = clienteFin = nodo;
            else
            {
                clienteFin.clienteSig = nodo;
                clienteFin = nodo;
            }

            totalClientes++;
        }

        public Cliente RemoverCli()
        {
            Cliente clienteAux = null; // Cliente a remover
            if (!EstaVacia())
            {
                clienteAux = clienteInic;
                clienteInic = clienteInic.clienteSig;
                clienteAux.clienteSig = null; // Desvincular nodo 
                totalClientes--;

                // Si la cola queda vacía
                if (clienteInic == null) clienteFin = clienteInic;
            }
            return clienteAux;
        }

        public void AnotarClientes(ListBox VistaClientes)
        {
            // Limpiar la lista para volver a imprimir
            VistaClientes.Items.Clear();

            if(EstaVacia())
            {
                VistaClientes.Items.Add("SIN CLIENTES");
                return;
            }

            Cliente clienteAux = clienteInic;
            while(clienteAux != null )
            {
                VistaClientes.Items.Add(clienteAux.NombreCompleto());
                clienteAux = clienteAux.clienteSig;
            }
        }

        public bool EstaVacia()
        {
            // Retorna true si se cumple la condición
            return clienteInic == null; 
        }
    }

}