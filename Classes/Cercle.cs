using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT2_POO.Classes
{
    internal class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        public double CalculerAire()
        {
            double resultAire = Math.PI * Math.Sqrt(_rayon);
            return resultAire;
        }

        public double CalculerPerimetre()
        {
            double resultPerimetre = Math.PI * _rayon * 2;
            return resultPerimetre;
        }

        public string infosCercle()
        {
            return "Le cercle de rayon " + _rayon + " a un périmètre de " + CalculerPerimetre() + " et une aire de " + CalculerAire();
        }

    }
}
