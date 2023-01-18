using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {

            Remolque remolque = new Remolque(2.30, 2.60, 4.90);

            Camion camion = new Camion("Mercedes Benz", 2, true, true)
            {
                Remolque = remolque
            };

            MessageBox.Show("•Marca: " + camion.Marca + "\n•Cantidad de puertas: " + camion.CantidadPuertas.ToString() + "\n•¿Tiene claxon?: " + camion.Claxon.ToString() + "\n•¿Transporta carga al extranjero?: " + camion.TransportaAlExterior.ToString());

        }

        private void btnQuitarRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque(2.30, 2.60, 4.90);

            Camion camion = new Camion("Mercedes Benz", 2, true, true)
            {
                Remolque = remolque
            };

            MessageBox.Show(camion.QuitarRemolque(camion.Remolque));
        }

        private void btnCrearRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque(2.30, 2.60, 4.90);

            MessageBox.Show("Ancho: " + remolque.Ancho.ToString() + " mts." + "\nAlto: " + remolque.Alto.ToString() + " mts." + "\nLargo: " + remolque.Largo.ToString() + " mts.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoElectrico autoElectrico = new AutoElectrico("Chevrolet", 5, "Familiar", "Importado");

            MessageBox.Show("Marca: " + autoElectrico.Marca + "\nCantidad de puertas: " + autoElectrico.CantidadPuertas.ToString() + "\nTipo de auto: " + autoElectrico.Tipo + "\nOrígen: " + autoElectrico.Origen);
        }
    }
}
