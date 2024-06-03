using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1.Models
{
    public class Tanque
    {
        public string nombre;
        public string pais;
        public int año;
        public int peso;
        public List<string> aliados;

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.año = año;
            this.peso = peso;
            this.aliados = aliados;
        }

        public void batalla(Tanque otroTanque)
        {
            Console.WriteLine("Información del Tanque 1:");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("País: " + this.pais);
            Console.WriteLine("Año de fabricación: " + this.año);
            Console.WriteLine("Peso: " + this.peso);

            Console.WriteLine("\nInformación del Tanque 2:");
            Console.WriteLine("Nombre: " + otroTanque.nombre);
            Console.WriteLine("País: " + otroTanque.pais);
            Console.WriteLine("Año de fabricación: " + otroTanque.año);
            Console.WriteLine("Peso: " + otroTanque.peso);

            if (this.año > otroTanque.año && this.peso > otroTanque.peso)
            {
                Console.WriteLine("\n¡El Tanque 1 gana la batalla!");
            }
            else if (this.año < otroTanque.año && this.peso < otroTanque.peso)
            {
                Console.WriteLine("\n¡El Tanque 2 gana la batalla!");
            }
            else
            {
                Console.WriteLine("\n¡La batalla termina en empate!");
            }
        }
    }
}
