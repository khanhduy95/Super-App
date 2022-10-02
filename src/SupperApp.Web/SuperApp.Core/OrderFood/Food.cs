namespace SuperApp.Core.OrderFood
{
    public class Food : BaseEntiy
    {
        public string Name { get; set; }
        public  FoodType FoodType { get; set; }

        public string Description { get; set; }
    }
}
