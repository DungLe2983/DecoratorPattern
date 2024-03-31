using DecoratorDesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class BlackSugar : MilkTeaDecorator
    {
        // Constructor nhận vào Parameter là IMilkTea sau đó nó chạy base inner là chạy constructor của thèn cha nó
        public BlackSugar(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5000 + base.Cost();
        }
    }
}
