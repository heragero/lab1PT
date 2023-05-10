using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Сream : Decorator
    {
        public Сream(Drink drink) : base(drink)
        {
        }
        public override string GetName()
        {
            return $"{base.GetName()}, cream";
        }
        public override double GetCost()
        {
            return base.GetCost() + 5;
        }
    }
}
