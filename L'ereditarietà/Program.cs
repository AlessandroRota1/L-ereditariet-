using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L_ereditarietà
{
    class quadrato
    {
        protected double _lato;
        public quadrato(double lato)
        { 
            this._lato = lato; 
        }
        public void perimetro()
        {
            Console.WriteLine("Il perimetro è " + _lato * 4);
        }
        public void area()
        {
            Console.WriteLine("L'area è " + _lato * _lato);
        }
    }

    class cubo:quadrato
    {
        public cubo(double lato) : base(lato) 
        {
            _lato = lato;
        }
        public void superificie() 
        { 
            Console.WriteLine("La superificie è " + _lato * _lato * 6);
        }
        public void volume()
        {
            Console.WriteLine("IL volume è " + _lato * _lato * _lato);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il lato");
            double latoo= double.Parse(Console.ReadLine());
            quadrato Quadrato = new quadrato(latoo);
            cubo Cubo = new cubo(latoo);
            Quadrato.perimetro();
            Quadrato.area();
            Cubo.superificie();
            Cubo.volume();
        }
    }
}
