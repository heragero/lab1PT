using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator 
{
    public abstract class Decorator : Drink
    {
        private Drink _drink;

        public Decorator(Drink drink)
        {
            _drink = drink;
        }

        public override double GetCost()
        {
            if (this._drink != null)
            {
                return _drink.GetCost();
            }
            else
            {
                return 0; 
            }
        }

        public override string GetName()
        {
            if (this._drink != null)
            {
                return _drink.GetName();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
