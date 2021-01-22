using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculation
{
    public class Grocery : GroceryItem
    {
        private int quantity = 0;
        private double discount = 0; // We can use this to set the discount percentage

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public override double Calculate()
        {
            double calculatedPrice = this.Price * this.Quantity;


            //if (calculatedPrice >= 2)
            //{
            //    calculatedPrice += calculatedPrice * (discount / 100);
            //}
            if (calculatedPrice >= 4.6 && this.Name== "Milk") // buy 3 milk and get one free
            {
                calculatedPrice -= (Price);
            }
            //if(calculatedPrice >=3.2 && this.Name == "Butter")
            //{
             

            //}



            return calculatedPrice;
        }
    }
}
