using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2POO
{
    public class Puerta
    {
        public string Color { get; private set; }

        public Puerta()
        {
            Color = "Café";
        }

        public void SetColor(string nuevoColor)
        {
            Color = nuevoColor;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Yo soy una Puerta, mi color es {Color}.");
        }
    }
}
