using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string titulo;
        public Int16 año
        //Constructores
        public Pelicula()
        {

        }
        public Pelicula(string titulo, Int16 año)
        {
            
        }
     
        //Métodos
     
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("El Gato con Botas 2");
            p1.SetAño(2022);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
