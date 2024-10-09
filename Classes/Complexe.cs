using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT2_POO.Classes
{
    internal class Complexe
    {
        //c1.Ajoute(c2);
        private double _reel; // attributs
        private double _imaginaire;

        public Complexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }



        public double CalculModule()
        {
            double resultModule = Math.Sqrt(Math.Pow(_reel, 2) + Math.Pow(_imaginaire, 2));
            return resultModule;
        }

        public string AfficheComplexe()
        {
            string afficherComplexe = "(" + _reel + ", " + _imaginaire + ")";
            return afficherComplexe;
        }

        public void Ajoute (Complexe complexe)
        {
            _reel += complexe.Reel;
            _imaginaire += complexe.Imaginaire;
        }
    }
}


