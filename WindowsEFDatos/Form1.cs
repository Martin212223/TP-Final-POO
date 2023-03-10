using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void MostrarAvionesGrid()
        {
            gridAviones.DataSource = AbmAvion.Listar();
        }

        private int obtenerIdLinea()
        {
            string[] lineaTxtComboBox = new string[3];

            lineaTxtComboBox = comboLineaAerea.Text.Split(' ');

            int idLinea = Convert.ToInt32(lineaTxtComboBox[2]);

            return idLinea;
        }

        private void LimpiarTextBox()
        {
            txtCapAvion.Text= string.Empty;
            txtDenAvion.Text= string.Empty;
            //comboLineaAerea.SelectedIndex = 0;
            txtIdAvion.Text= string.Empty;
            txtNameLineaAerea.Text= string.Empty;
            dateLineaAerea.Text = string.Empty;
        }

        private void RellenarComboLinea()
        {
            DBLineaAereaContext context = new DBLineaAereaContext();

            comboLineaAerea.Items.Clear();

            foreach (LineaAerea lineaAerea in context.LineasAereas)
            {
                comboLineaAerea.Items.Add(lineaAerea.Nombre + " Id: " + lineaAerea.IdLinea);
            }
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            RellenarComboLinea();

            MostrarAvionesGrid();
        }

        private void btnInsertarAvion_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() 
            {
                Capacidad = Convert.ToInt32(txtCapAvion.Text),
                Denominacion = txtDenAvion.Text,
                IdLinea = obtenerIdLinea()
            };

            int filasAfectadas = AbmAvion.Insertar(avion);

            if (filasAfectadas > 0 )
            {
                MostrarAvionesGrid();

                LimpiarTextBox();
            }
        }

        private void btnInsertarLinea_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea()
            {

                Nombre = txtNameLineaAerea.Text,
                FechaInicioActividades = Convert.ToDateTime(dateLineaAerea.Value.ToString("d"))
                
            };

            int filasAfectadas = AbmLineaAerea.InsertarLinea(lineaAerea);

            if (filasAfectadas > 0)
            {
                RellenarComboLinea();

                MessageBox.Show("Línea aérea guardada con éxito.");
            }
        }

        private void btnEditarAvion_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(txtIdAvion.Text),
                Capacidad = Convert.ToInt32(txtCapAvion.Text),
                Denominacion = txtDenAvion.Text,
                IdLinea = obtenerIdLinea()
            };

            AbmAvion.Editar(avion);

            MostrarAvionesGrid();

            LimpiarTextBox();
        }

        private void btnBuscarIdAvion_Click(object sender, EventArgs e)
        {
            List<Avion> aviones = new List<Avion>();

            aviones.Add(AbmAvion.TraerUno(Convert.ToInt32(txtIdAvion.Text)));

            gridAviones.DataSource = aviones;

            LimpiarTextBox();
        }

        private void btnEliminarAvion_Click(object sender, EventArgs e)
        {
            

            AbmAvion.Eliminar(Convert.ToInt32(txtIdAvion.Text));

            MostrarAvionesGrid();

            LimpiarTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarAvionesGrid();
        }
    }
}
