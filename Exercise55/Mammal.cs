using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55
{
    public class Mammal : Animal
    {
        public bool HasFur { get; set; }
        public Mammal(bool hasFur, string name, double weight, int age) : base(name, weight, age)
        {
            HasFur = hasFur;
        }
    }
}
