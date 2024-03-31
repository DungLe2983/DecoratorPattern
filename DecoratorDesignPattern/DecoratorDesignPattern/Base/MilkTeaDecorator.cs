using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;

        protected MilkTeaDecorator(IMilkTea inner)
        {
            _milkTea = inner;
        }

        //virtual để các class con có thể Override lại hàm Cost
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
