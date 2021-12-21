using factoryDesignPattern.Interfaces;

namespace Employee.Department_2
{
    public class Department_2
    {
       public int id { get; set; }
        public string positionName { 
            get{ return "accounting";} 
            set{}
            }
        
        public void ResultPrint()
        {
           System.Console.WriteLine( "the position available is : " + positionName);;
        }
    }
}