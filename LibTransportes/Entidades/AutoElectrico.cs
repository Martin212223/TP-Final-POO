using LibTransportes.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Vehiculo
    {

        public AutoElectrico() { }

        public AutoElectrico(string marca, int cantidadPuertas, string tipo, string origen):base(marca, cantidadPuertas)
        {
            Tipo = tipo;

            Origen = origen;
        }

        public string Tipo { get; set; }

        public string Origen { get; set; }

        public override string Acelerar()
        {
            return "Acelera en silencio al no tener motor de combustión interna.";
        }

        public override string Frenar()
        {
            return "Frena con mayor estabilidad y control al tener un mecanismo distinto por ser eléctrico.";
        }
    }
}
