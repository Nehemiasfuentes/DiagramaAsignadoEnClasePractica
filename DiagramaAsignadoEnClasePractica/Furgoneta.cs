using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaAsignadoEnClasePractica
{
    class Furgoneta : Vehiculo
    {
        private int carga;

        private int volumen;

        public void setCarga(int Carga)
        {
            carga = Carga;

        }

        public int getCarga()
        {
            return carga;
        }

        public void setVolumen(int Volumen)
        {
            volumen = Volumen;
        }

        public int getVolumen()
        {
            return carga;

        }

        public override string getAtributos()
        {
            return base.getAtributos() + " , " + " Carga: " + carga + " , " + " Volumen: " + volumen;
        }
    }

}
