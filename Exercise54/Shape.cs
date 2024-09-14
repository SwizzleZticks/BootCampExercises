using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise54
{
    public abstract class Shape //cannot be instantiated, the derived classes handle instantiation
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area(); 
        public abstract double Perimeter();

    }
}
