using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1.Models
{
    public class Barco
    {
        public int cargamento;
        public int tripulacion;

        public Barco(int cargamento, int tripulacion)
        {
            this.cargamento = cargamento;
            this.tripulacion = tripulacion;
        }

        public bool valeLaPenaSaquear()
        {
            return (cargamento - tripulacion) > 20;
        }
    }
}
