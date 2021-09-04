using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Component
{
    public interface ICar
    {
        string Make { get; }
        double GetPrice();
    }
}
