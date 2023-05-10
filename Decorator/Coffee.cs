using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Coffee : Drink
    {
        private string _name;
        private double _cost;
        public Coffee()
        {
            _name = "Coffee";
            _cost = 30;
        }
        public override double GetCost()
        {
            return _cost;
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
