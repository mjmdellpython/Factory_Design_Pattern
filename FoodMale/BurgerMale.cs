using factoryDesignPattern.Interfaces;

namespace factoryDesignPattern.FoodMale
{
    public class BurgerMale : IResturant
    {
        public int id { get{ return 1;} set{} }
        public string male { get{ return "Burger";} set{} }

        public void result()
        {
            System.Console.WriteLine( "the male is : {0}", male);
        }
    }
}