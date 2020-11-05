
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            LegCount = 2;
            Age = 6;
            Color = "White";
            HasTail = true;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }
    }
}
