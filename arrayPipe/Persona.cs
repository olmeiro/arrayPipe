using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPipe
{
    class Persona
    {
        public string nombre;
        public int edad;

        public Persona()
        {

        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
