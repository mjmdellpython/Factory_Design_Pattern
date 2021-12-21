using System;
using factoryDesignPattern.Factory;
using factoryDesignPattern.Interfaces;

namespace factoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory design pattern ...");
            //FactoryClass f = new FactoryClass();
            //f.checkDepartment(2);
            //f.checkDepartment(1);

            /*FactoryOrder Fo = new FactoryOrder();

            Fo.maleOreder(1);*/

            IFactoryResturent Ifct = new FactoryOrder();
            IResturant Irs = Ifct.maleOreder(1);
            

            
            
            

        }
    }
}
