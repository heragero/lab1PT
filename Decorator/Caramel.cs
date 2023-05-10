using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Caramel : Decorator
    {
        public Caramel(Drink drink) : base(drink)
        {
        }
        public override string GetName()
        {
            return $"{base.GetName()}, caramel";
        }
        public override double GetCost()
        {
            return base.GetCost() + 7.50;
        }
    }
}
