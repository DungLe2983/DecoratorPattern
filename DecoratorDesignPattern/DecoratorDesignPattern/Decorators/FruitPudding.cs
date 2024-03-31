using DecoratorDesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 10000 + base.Cost();
        }
    }
}
