using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramaAsignadoEnClasePractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Turismo turismo = new Turismo();

            turismo.setMatricula("ELSAVADOR-1001");
            turismo.setMarca("Toyota Hilux");
            turismo.setModelo("RV FULL EXTRAS 2021");
            turismo.setColor("Blanco Perla");
            turismo.setTarifa(35.50);
            turismo.setDisponible(true);
            //
            turismo.setPuertas(4);
            turismo.setMarchaAutomatica(true);


            MessageBox.Show(turismo.getAtributos());





            Deportivo deportivo = new Deportivo();

            deportivo.setMatricula("USA-1005");
            deportivo.setMarca("Nissa");
            deportivo.setModelo("GTR-35 Nismo");
            deportivo.setColor("Negro con perlas doradas");
            deportivo.setTarifa(89.99);
            deportivo.setDisponible(true);
            //
            deportivo.setCilindrada(7);

            MessageBox.Show(deportivo.getAtributos());




            Furgoneta furgoneta = new Furgoneta();

            furgoneta.setMatricula("NICARAGUA-1003");
            furgoneta.setMarca("FORD");
            furgoneta.setModelo("Transit");
            furgoneta.setColor("Blanco");
            furgoneta.setTarifa(59.85);
            furgoneta.setDisponible(false);
            //
            furgoneta.setCarga(16);
            furgoneta.setVolumen(8);

            MessageBox.Show(furgoneta.getAtributos());

        }
    }
}
