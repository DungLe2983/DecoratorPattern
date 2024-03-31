using System;
using DecoratorDesignPattern.Base;
using DecoratorDesignPattern.Decorators;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var firstMilkTea = new EggPudding(
                                new FruitPudding(
                                    new BlackSugar(
                                        new Bubble(
                                            new MilkTea()))));
            Console.WriteLine("EggPuddingAndFruitPuddingBlackSugarBubbleMilkTea có giá là:\t"
                                + firstMilkTea.Cost());

           

            var secondMilkTea = new EggPudding(
                                    new BlackSugar(
                                        new WhiteBubble(
                                            new MilkTea())));
            Console.WriteLine("EggPuddingBlackSugarWhiteBubbleMilkTea có giá là:\t"
                                + secondMilkTea.Cost());
        }
    }
}