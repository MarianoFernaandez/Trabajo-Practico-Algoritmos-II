using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1.Models
{
    public class Bloque
    {
        // Atributos
        public int largo;
        public int ancho;
        public int alto;

        // Constructor
        public Bloque(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }

        public int obtenerLargo()
        {
            return largo;
        }

        public int obtenerAncho()
        {
            return ancho;
        }

        public int obtenerAlto()
        {
            return alto;
        }

        public int obtenerVolumen()
        {
            return largo * ancho * alto;
        }

        public int obtenerAreaSuperficie()
        {
            return 2 * (largo * ancho + largo * alto + ancho * alto);
        }
    }
}
