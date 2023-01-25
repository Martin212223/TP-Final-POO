using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades.Base
{
    public abstract class Vehiculo
    {

        public Vehiculo() { }

        public Vehiculo(string marca, int cantidadPuertas) 
        {
            Marca = marca;

            CantidadPuertas = cantidadPuertas;
        }

        public string Marca { get; set; }

        public int CantidadPuertas { get; set; }

        public abstract string Acelerar();

        public abstract string Frenar();

        public virtual string Imprimir()
        {
            return "El vehículo se utiliza para transporte.";
        }
    }
}
