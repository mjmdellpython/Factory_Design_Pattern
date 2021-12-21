using factoryDesignPattern.Interfaces;

namespace Employee.Department_1
{
    public class Department_1 : IDepartment
    {

        public int id { get; set; }
        public string positionName { get{return "Fianancial";} set{} }
        public void ResultPrint()
        {
           System.Console.WriteLine( "the position available is : " + positionName);;
        }
    }
}