using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAR
{
    public class Cliente
    {
        public string nom;
        public string apell;
        public Cliente clienteSig = null;

        public Cliente(string nom, string apell)
        {
            this.nom = nom;
            this.apell = apell;
        }

        public string NombreCompleto()
        {
            return $"{this.nom} {this.apell}";
        }
    }
}
