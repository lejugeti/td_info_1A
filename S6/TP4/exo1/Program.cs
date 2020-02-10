using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Insecte
    {
        private string _typeInsecte;
        private int _tempsDernierRepas = 0;
        private int _toursAvantFaim;
        protected int _abscisse;
        protected int _ordonnee;

        public string TypeInsecte
        {
            get { return _typeInsecte; }
            set
            {
                if(value == "fourmi" || value == "cigale")
                {
                    _typeInsecte = value;
                }
            }
        }

        public int TempsDernierRepas
        {
            get { return _tempsDernierRepas; }
            set
            {
                if(value > 0) _tempsDernierRepas = value;
            }
        }

        public int TourAvantFaim
        {
            get { return _toursAvantFaim; }
            set { if (value > 0) _toursAvantFaim = value; }
        }

        public int Abs
        {
            get { return _abscisse; }
            set { _abscisse = value; }
        }

        public int Ord
        {
            get { return _ordonnee; }
            set { _ordonnee = value; }
        }

        

        //Méthodes
        public void Mange()
        {
            if (_tempsDernierRepas == _toursAvantFaim)
            {
                _tempsDernierRepas = 0;
            }

            else _tempsDernierRepas++;
            

        }

        public void Infos()
        {
            Console.WriteLine($"type = {_typeInsecte}");
            Console.WriteLine($"temps dernier repas = {_tempsDernierRepas}");
            Console.WriteLine($"tours avant faim = {_toursAvantFaim}");
            Console.WriteLine($"abscisse = {_abscisse}");
            Console.WriteLine($"ordonnée = {_ordonnee}");
            Console.WriteLine("");
        }

    }

    class Fourmi : Insecte
    {
        public Fourmi(int x, int y) : base()
        {
            this.TypeInsecte = "fourmi";
            this.TourAvantFaim = 5;
            this.Abs = x;
            this.Ord = y;

        }

        //Méthodes
        public void toString()
        {
            Console.WriteLine("Je suis une Fourmi");
            Infos();
        }
    }

    class Cigale : Insecte
    {
        public Cigale(int x, int y) : base()
        {
            this.TypeInsecte = "cigale";
            this.TourAvantFaim = 7;
            this.Abs = x;
            this.Ord = y;

        }

        //Méthodes
        public void toString()
        {
            Console.WriteLine("Je suis une Cigale");
            Infos();
        }
    }

    class Simulation
    {
        int _nbInsectes;
        int _nbTours;
        int _xMax;
        int _yMax;

        public int NbInsectes
        {
            get { return _nbInsectes; }
            set { if(value > 0)_nbInsectes = value; }
        }

        public int NbTours
        {
            get { return _nbTours; }
            set { if (value > 0) _nbTours = value; }
        }

        public int XMax
        {
            get { return _xMax; }
            set { _xMax = value; }
        }

        public int YMax
        {
            get { return _yMax; }
            set { _yMax = value; }
        }


        //Constructeur
        public Simulation(int nbInsectes, int nbTours, int xMax, int yMax)
        {
            NbInsectes = nbInsectes;
            NbTours = nbTours;
            XMax = xMax;
            YMax = yMax;
        }

        //Méthodes
        public void Simule()
        {
            Fourmi f = new Fourmi(10, 5);
            Random rng = new Random();
            int tmpX;
            int tmpY;

            for(int i = 0; i < NbTours; i++)
            {
                tmpX = rng.Next(-1, 2);
                tmpY = rng.Next(-1, 2);
                f.Abs += (f.Abs + tmpX < XMax)? tmpX : 0;
                f.Ord += (f.Ord + tmpY < YMax) ? tmpY : 0;
                f.Mange();

                f.toString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Simulation s = new Simulation(1, 10, 10, 6);
            s.Simule();
            Console.ReadKey();
        }
    }
}
