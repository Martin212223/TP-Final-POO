using LibTransportes.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Vehiculo
    {

        public Camion() { }

        public Camion(string marca, int cantidadPuertas, bool claxon, bool transportaAlExterior):base(marca, cantidadPuertas) 
        {
            Claxon = claxon;

            TransportaAlExterior = transportaAlExterior;
        }

        public bool Claxon { get; set; }

        public bool TransportaAlExterior { get; set; }

        public Remolque Remolque { get; set; }

        public override string Acelerar()
        {
            return "Acelera con mucho ruido y lentamente.";
        }

        public override string Frenar()
        {
            return "Frena con mucha distancia al ser más pesado.";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + "\n•Marca: " + Marca + "\n•Cantidad de puertas: " + CantidadPuertas.ToString() + "\n•¿Tiene claxon?: " + Claxon.ToString() + "\n•¿Transporta carga al extranjero?: " + TransportaAlExterior.ToString();
        }

        public string QuitarRemolque(Remolque remolque)
        {
            remolque = null;

            if (remolque == null)
            {
                return "El remolque ha sido quitado.";
            }
            return "No se ha quitado el remolque.";
        }
    }
}
