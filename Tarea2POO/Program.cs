using Tarea2POO;

class Program
    {
    static void Main(string[] args)
        {
        Persona juan = new Persona();
        juan.MostrarDatos();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.SetColor("Verde");
        Casa nuevaCasa = new Casa(200);
        nuevaCasa.SetPuerta(nuevaPuerta);
        Persona Carlos = new Persona("Carlos", nuevaCasa);
        Carlos.SetNombre("Carlos");
        Carlos.MostrarDatos();
        }

    }


