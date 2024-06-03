using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1.Models;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            string nombrePersona = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona:");
            int edadPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el género de la persona:");
            string generoPersona = Console.ReadLine();

            Persona persona1 = new Persona(nombrePersona, edadPersona, generoPersona);

            persona1.hablar();

            Console.WriteLine("\nIngrese el peso del cargamento del barco:");
            int pesoCargamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de tripulantes a bordo:");
            int numeroTripulantes = int.Parse(Console.ReadLine());

            Barco barco1 = new Barco(pesoCargamento, numeroTripulantes);

            if (barco1.valeLaPenaSaquear())
            {
                Console.WriteLine("¡Vale la pena saquear este barco!");
            }
            else
            {
                Console.WriteLine("No vale la pena saquear este barco.");
            }

            Console.WriteLine("\nIngrese los datos del primer tanque:");

            Console.Write("Nombre del tanque: ");
            string nombreTanque1 = Console.ReadLine();

            Console.Write("País de origen del tanque: ");
            string paisTanque1 = Console.ReadLine();

            Console.Write("Año de fabricación del tanque: ");
            int añoFabricacionTanque1 = int.Parse(Console.ReadLine());

            Console.Write("Peso del tanque en toneladas: ");
            int pesoTanque1 = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de países aliados del tanque: ");
            int cantidadAliadosTanque1 = int.Parse(Console.ReadLine());

            var aliadosTanque1 = new List<string>();
            for (int i = 0; i < cantidadAliadosTanque1; i++)
            {
                Console.Write($"Nombre del país aliado {i + 1}: ");
                string paisAliado = Console.ReadLine();
                aliadosTanque1.Add(paisAliado);
            }

            Console.WriteLine("\nIngrese los datos del segundo tanque:");

            Console.Write("Nombre del tanque: ");
            string nombreTanque2 = Console.ReadLine();

            Console.Write("País de origen del tanque: ");
            string paisTanque2 = Console.ReadLine();

            Console.Write("Año de fabricación del tanque: ");
            int añoFabricacionTanque2 = int.Parse(Console.ReadLine());

            Console.Write("Peso del tanque en toneladas: ");
            int pesoTanque2 = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de países aliados del tanque: ");
            int cantidadAliadosTanque2 = int.Parse(Console.ReadLine());

            var aliadosTanque2 = new List<string>();
            for (int i = 0; i < cantidadAliadosTanque2; i++)
            {
                Console.Write($"Nombre del país aliado {i + 1}: ");
                string paisAliado = Console.ReadLine();
                aliadosTanque2.Add(paisAliado);
            }

            string ganador = CompararTanques(nombreTanque1, paisTanque1, añoFabricacionTanque1, pesoTanque1, aliadosTanque1,
                                              nombreTanque2, paisTanque2, añoFabricacionTanque2, pesoTanque2, aliadosTanque2);

            Console.WriteLine(ganador);

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }

        static string CompararTanques(string nombreTanque1, string paisTanque1, int añoFabricacionTanque1, int pesoTanque1, List<string> aliadosTanque1,
                                       string nombreTanque2, string paisTanque2, int añoFabricacionTanque2, int pesoTanque2, List<string> aliadosTanque2)
        {
            // Comparar las características de los tanques y determinar el ganador
            if (añoFabricacionTanque1 > añoFabricacionTanque2)
            {
                return $"{nombreTanque1} gana la batalla y se lleva el botín!";
            }
            else if (añoFabricacionTanque1 < añoFabricacionTanque2)
            {
                return $"{nombreTanque2} gana la batalla y se lleva el botín!";
            }
            else
            {
                return "¡Es un empate!";
            }
        }
    }
}

        



