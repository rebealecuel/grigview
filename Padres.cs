using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grigview
{
    internal class Padres : Hijos
    {
        public Padres() { }

        public Padres(string nombre, int edad,string gradoEstudio, string cabello, string ojos)
            :base(gradoEstudio,cabello,ojos)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        
    }
}
