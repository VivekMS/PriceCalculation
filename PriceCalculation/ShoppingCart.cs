using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculation
{
   public  class ShoppingCart
    {
        private List<GroceryItem> orders;

        public List<GroceryItem> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public double Calculate(double price=0)
        {
            //double price = 0;
            

            if (this.Orders != null)
            {

                foreach (GroceryItem order in this.Orders)
                {


                    price += order.Calculate();

                    
                }
                

            }

            
            return price;

        }
    }
}
