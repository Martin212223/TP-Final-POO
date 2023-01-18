using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmLineaAerea
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static int InsertarLinea(LineaAerea lineaAerea)
        {
            context.LineasAereas.Add(lineaAerea);

            return context.SaveChanges();
        }
    }
}
