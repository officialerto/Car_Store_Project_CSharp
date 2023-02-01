using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class_Library
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal CheckOut()
        {
            //Initialize the Total Cost
            decimal totalCost = 0;
            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }

            ShoppingList.Clear();
            return totalCost;

        }

    }
}
