using DecoratorDesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5000 + base.Cost();
        }
    }
}
