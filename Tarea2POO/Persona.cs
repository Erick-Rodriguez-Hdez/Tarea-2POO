using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2POO
{
    public class Persona
    {
        public string Nombre { get; private set; }
        public Casa Casa { get; private set; }

       
        public Persona()
        {
            Nombre = "Juan";
            Casa = new Casa(150);
        }

        public Persona(string nombre, Casa casa)
        {
            Nombre = nombre;
            Casa = casa;
        }

        public void SetNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre;
        }

        public void SetCasa(Casa nuevaCasa)
        {
            Casa = nuevaCasa;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Mi nombre es {Nombre}.");
            Casa.MostrarDatos();
        }
    }

}
