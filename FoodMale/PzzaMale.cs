using factoryDesignPattern.Interfaces;

namespace factoryDesignPattern.FoodMale
{
    public class PzzaMale : IResturant
    {
        public int id {  get{ return 2;} set{} }
        public string male {  get{ return "Pzza";} set{} }

        public void result()
        {
            System.Console.WriteLine( "the male is : {0}", male);
        }
    }
}