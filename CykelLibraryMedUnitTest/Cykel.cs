using System;

namespace CykelLibraryMedUnitTest
{
    public class Cykel
    {
        private string _farve;
        private int _pris;
        private int _gear;

        public int Id { get; set; }

        public string Farve
        {
            get => _farve;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 1) throw new ArgumentException();
                _farve = value;
            }
        }

        public int Pris
        {
            get => _pris;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _pris = value;
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (3 <= value && value <= 32) _gear = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return Id + " " + Farve + " " + Pris + " " + Gear;
        }
    }
}
