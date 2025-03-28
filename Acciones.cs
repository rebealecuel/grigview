using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grigview
{
    internal class Acciones
    {
        List<Padres> ListaFamilia = new List<Padres>
        {
            new Padres("Gary",48,"Universitario","Rubio","Azul"),
            new Padres("Alva",48,"Universitario","Azul","Morado"),
            new Padres("Hanna",6,"Primaria","Rubio","Azul"),
            new Padres("John",6,"Primaria","Azul","Morado"),
            new Padres("Miles",18,"Universitario","Cafe","Azul")
        };

        public List<Padres> MostrarFamilia()
        { 
            return ListaFamilia; 
        }
    }
}
