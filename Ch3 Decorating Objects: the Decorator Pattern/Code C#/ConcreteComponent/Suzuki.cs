using DesignPatterns.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConcreteComponent
{
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 1000000;
        }
    }
}
