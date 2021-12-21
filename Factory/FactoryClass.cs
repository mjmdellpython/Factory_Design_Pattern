using System;
using Employee.Department_1;
using Employee.Department_2;
using factoryDesignPattern.Interfaces;

namespace factoryDesignPattern.Factory
{
    public class FactoryClass
    {
        
        public int check_1 = 1;
        private int check_2 = 2;

        public string checkDepartment(int checkId)
        {

            switch(checkId)
            {
                case 1:
                  var d1 = new Department_1();
                  d1.ResultPrint();
                  return "done!";
                case 2:
                  var d2 = new Department_2();
                  d2.ResultPrint();
                  return "done!";
                default:
                  return null;
            }
        }
        
    }
}