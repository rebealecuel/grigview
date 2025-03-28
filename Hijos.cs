using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grigview
{
    internal class Hijos 
    {
        public Hijos() { }

        public Hijos(string gradoEstudio, string cabello, string ojos)
            
        {
            GradoEstudio = gradoEstudio;
            Cabello = cabello;
            Ojos = ojos;
        }

        public string GradoEstudio { get; set; }
        public string Cabello { get; set; }
        public string Ojos { get; set; }
    }
}
