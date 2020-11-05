using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            LegCount = 4;
            Age = 2;
            Color = "Green";
            HasTail = true;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
