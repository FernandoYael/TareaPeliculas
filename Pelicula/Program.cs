using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        private short año{ get; set; }
        private string? país{ get; set; }
        private string? director{ get; set; }
        private string? titulo{ get; set; }

        //Constructores
        public Pelicula()
        {
        }
        public Pelicula(string titulo, short año)
            : this()
        {
            this.titulo = titulo;
            this.año = año;
        }

     
        //Métodos
     
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
            }
        public void SetAño(short año)
        {
            this.año = año;
        }
        public string? GetTitulo()
        {
            return this.titulo;
        }
        public short GetAño()
        {
            return this.año;
        }
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }
        public void ImprimeActores()
        {
            foreach (Actor actor in actores)
            {
                actor.Imprime();
            }
        }
    }

    public class Actor
    {
        //Propiedades
        private string? nombre{ get; set; }
        private short año{ get; set; }
        public Actor(string nombre, short año)
        {
            this.nombre = nombre;
            this.año = año;
        }
        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{nombre} ({año})");
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
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("El Viaje de Chihiro");
            p2.SetAño(2001);
            p1.Imprime();
            p2.Imprime();
        }
    }
}
