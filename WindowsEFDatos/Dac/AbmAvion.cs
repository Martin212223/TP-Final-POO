using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }

        public static int Insertar(Avion avion)
        {
            context.Aviones.Add(avion);

            return context.SaveChanges();
        }

        public static Avion TraerUno(int id)
        {
            return context.Aviones.Find(id);
        }

        public static int Editar(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);

            if (avionOrigen != null)
            {
                avionOrigen.Capacidad = avion.Capacidad;
                avionOrigen.Denominacion = avion.Denominacion;
                avionOrigen.IdLinea = avion.IdLinea;

                return context.SaveChanges();
            }

            MessageBox.Show("No se encontró el avión a modificar.");

            return 0;
        }

        public static int Eliminar(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.IdAvion);

            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);

                return context.SaveChanges();
            }

            return 0;
        }
    }
}
