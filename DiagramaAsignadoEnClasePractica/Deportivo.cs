using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaAsignadoEnClasePractica
{
    class Deportivo : Vehiculo
    {
        private int cilindrada;


        public void setCilindrada(int Cilindrada)
        {
            cilindrada = Cilindrada;
        }

        public int getCilindrada()
        {
            return cilindrada;
        }

        public override string getAtributos()
        {
            return "Vehiculo Deportivo " + base.getAtributos() + " , " + " Cilindrada: " + cilindrada;
        }
    }

}
