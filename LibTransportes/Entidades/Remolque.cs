using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {

        public Remolque(double ancho, double alto, double largo) 
        {
            Ancho = ancho;
            Alto = alto;
            Largo = largo;  
        }

        public double Ancho { get; set; }

        public double Alto { get; set; }

        public double Largo { get; set; }

        public Camion Camion { get; set; }
    }
}
