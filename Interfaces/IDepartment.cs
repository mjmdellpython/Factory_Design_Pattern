namespace factoryDesignPattern.Interfaces
{
    public interface IDepartment
    {
        public int id { get; set; }
        public string positionName { get; set; }
        public void ResultPrint();
    }
}