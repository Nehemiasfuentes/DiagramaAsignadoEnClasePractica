using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaAsignadoEnClasePractica
{
    class Vehiculo
    {
        //
        private string matricula;

        private string marca;

        private string modelo;

        private string color;
        //

        private double tarifa;//

        private bool disponible;//

        //Metodos SetData
        public void setTarifa(double Tarifa)
        {
            tarifa = Tarifa;
        }

        public void setDisponible(bool Disponible)
        {
            disponible = Disponible;
        }

        public void setMatricula(string Matricula)
        {
            matricula = Matricula;
        }

        public void setMarca(string Marca)
        {
            marca = Marca;
        }

        public void setModelo(string Modelo)
        {
            modelo = Modelo;
        }
        public void setColor(string Color)
        {
            color = Color;
        }

        //Metodos GetData

        public string getMatricula()
        {
            return matricula;
        }

        public string getMarca()
        {
            return marca;
        }

        public string getModelo()
        {
            return modelo;
        }
        public string getColor()
        {
            return color;
        }
        public double getTarifa()
        {
            return tarifa;
        }
        public bool getDisponible()
        {
            return disponible;
        }

        public virtual string getAtributos()
        {
            return "Disponibilidad: " + disponible + " , " + " Marca: " + marca + " , " + " Modelo: " + modelo + " , " + " Color: " + color + " , " + " Matricula: " + matricula + " , " + " Tarifa: $" + tarifa + " , ";
        }

    }

}
