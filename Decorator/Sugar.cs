using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sugar : Decorator
    {
        public Sugar(Drink drink) : base(drink)
        {
        }
        public override string GetName()
        {
            return $"{base.GetName()}, sugar";
        }
        public override double GetCost()
        {
            return base.GetCost();
        }
    }
}
