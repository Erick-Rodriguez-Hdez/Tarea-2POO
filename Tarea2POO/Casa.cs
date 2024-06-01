using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2POO
{
    public class Casa
    {
        public int Area { get; private set; }
        public Puerta Puerta { get; private set; }

        public Casa(int area)
        {
            Area = area;
            Puerta = new Puerta();
        }

        public void SetArea(int nuevaArea)
        {
            Area = nuevaArea;
        }

        public void SetPuerta(Puerta nuevaPuerta)
        {
            Puerta = nuevaPuerta;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Yo soy un apartamento, mi área es {Area} m2.");
            Puerta.MostrarDatos();
        }
    }

}
