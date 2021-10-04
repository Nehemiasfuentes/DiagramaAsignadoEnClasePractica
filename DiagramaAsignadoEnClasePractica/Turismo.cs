using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaAsignadoEnClasePractica
{
    class Turismo : Vehiculo
    {

        private int puertas;

        private bool marchaAutomatica;


        public void setPuertas(int Puertas)
        {
            puertas = Puertas;

        }

        public int getPuertas()
        {
            return puertas;
        }

        public void setMarchaAutomatica(bool MarchaAutomatica)
        {
            marchaAutomatica = MarchaAutomatica;

        }

        public bool getMarchaAutomatica()
        {
            return marchaAutomatica;
        }

        public override string getAtributos()
        {
            return "Vehiculo Turismo: " + base.getAtributos() + " , " + " Puertas: " + puertas + " , " + " Marcha Automatica: " + marchaAutomatica;
        }
    }

}
