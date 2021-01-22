namespace PriceCalculation
{
   public abstract class GroceryItem
    {
        private string name;
        private double price = 0;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public abstract double Calculate();
    }
}