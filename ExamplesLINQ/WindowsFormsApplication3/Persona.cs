using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class Persona
    {
        public string Nombre { get; set; }
        public Int16 Edad { get; set; }

        public Persona(string nombr, Int16 edad)
        {
            Nombre = nombr;
            Edad = edad;
        }
    }
    
}
