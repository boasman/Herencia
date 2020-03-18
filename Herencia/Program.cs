using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo Blanco = new Caballo("Blanco");

            Humano Elvis = new Humano("Michael");
            Gorilla Copito = new Gorilla("Copito");

            Blanco.Galopar();

            Elvis.Pensar();

            Copito.trepar();

        }
    }

    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre; 
        }


        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCria()
        {
            Console.WriteLine("Soy capaz de cuidar a mis crias");
        }

        private string nombreSerVivo;
    }
    

    class Caballo : Mamiferos        
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
            
        }
    }

   class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar ");
        }
    }


    class Gorilla : Mamiferos
    {

        public Gorilla(string nombreGorilla) : base(nombreGorilla)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
