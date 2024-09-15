using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55
{
    public class Bird : Animal
    {
        public bool HasFeathers { get; set; }
        public double WingSpan { get; set; }

        public Bird(bool hasFeathers, double wingSpan, string name, double weight, int age) : base(name, weight, age)
        {
            HasFeathers = hasFeathers;
            WingSpan = wingSpan;
        }

        public void LayEggs()
        {

        }
    }
}
