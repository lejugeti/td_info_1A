using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Vehicule
    {
        int _nbRoues;
        int _nbPlaces;
        int _kilometrage;

        public int NbRoues
        {
            get { return _nbRoues; }
            set { if (value > 0) _nbRoues = value; }
        }

        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { if (value > 0) _nbPlaces = value; }
        }

        public int Kilometrage
        {
            get { return _kilometrage; }
            set { if (value > 0) _kilometrage = value; }
        }

        //Constructeur
        public Vehicule(int roues, int places, int kilometrage)
        {
            NbRoues = roues;
            NbPlaces = places;
            Kilometrage = kilometrage;
        }

        //Méthodes
        public void toString()
        {
            Console.WriteLine($"nb roues = {NbRoues}");
            Console.WriteLine($"nb places = {NbPlaces}");
            Console.WriteLine($"Kilométrage = {Kilometrage}");
            Console.WriteLine($"");
        }
    }

    class Voiture : Vehicule
    {
        int _poids;
        string _couleur;
        int _puissance;

        //Constructeur
        public 
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
