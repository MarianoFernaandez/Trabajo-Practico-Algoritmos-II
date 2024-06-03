using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1.Models
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string genero;

        public Persona(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public void hablar()
        {
            Console.WriteLine("Me llamo " + nombre + ", me considero " + genero + " y tengo " + edad + " años.");
        }
    }
}
