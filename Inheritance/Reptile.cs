using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            AnimalName = "Lizard";
            LegCount = 4;
            Age = 2;
            Color = "Green";
            HasTail = true;
        }

        public string ReptileName { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
