using factoryDesignPattern.FoodMale;
using factoryDesignPattern.Interfaces;

namespace factoryDesignPattern.Factory
{
    public class FactoryOrder : IFactoryResturent
    {
        public IResturant maleOreder(int ID)
        {
            switch(ID)
            {
                case 1:
                return new BurgerMale();

                case 2:
                return new PzzaMale();

                default:
                return null;
            }
        }
    }
}