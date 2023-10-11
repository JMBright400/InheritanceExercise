using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool LaysEggs { get; set; }
        public bool HasLegs {  get; set; }
        public string ScaleColor { get; set; }
        public int TailLength { get; set; }

    }
}
