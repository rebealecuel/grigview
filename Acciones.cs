using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grigview
{
    internal class Acciones
    {
        private const bool V = true;
        List<Padres> ListaFamilia = new List<Padres>
        {
            new Padres("Gary",48,"Universitario","Rubio","Azul"),
            new Padres("Alva",48,"Universitario","Azul","Morado"),
            new Padres("Hanna",6,"Primaria","Rubio","Azul"),
            new Padres("John",6,"Primaria","Azul","Morado"),
            new Padres("Miles",18,"Universitario","Cafe","Azul")
        };

        Padres a = new Padres();
        public List<Padres> MostrarFamilia()
        { 
            return ListaFamilia; 
        }

        public bool EliminarFamilia(string nombre)
        {
            try
            {
                var objecteliminar = ListaFamilia.Find(x =>x.Nombre == nombre);
                if (objecteliminar != null)
                {
                    ListaFamilia.Remove(objecteliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertarFamilia(string nombre, int edad, string gradoEstudio, string cabello, string ojos)
        {
            try
            {
                ListaFamilia.Add(new Padres(a.Nombre = nombre, a.Edad = edad, a.GradoEstudio = gradoEstudio, a.Cabello = cabello, a.Ojos = ojos));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
