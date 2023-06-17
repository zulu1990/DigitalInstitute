using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Cartrige : IComparable<Cartrige>
    {
        public string Name { get; set; }
        public double Caliber { get; set; }

        public Cartrige(string name, double caliber)
        {
            Name = name;
            Caliber = caliber;
        }

        public int CompareTo(Cartrige other)
        {
            return Caliber.CompareTo(other.Caliber);
        }

        public override string ToString()
        {
            return $"(Name: {Name}, Caliber:{Caliber})";
        }
    }
}
