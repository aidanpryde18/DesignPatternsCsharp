using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public abstract class Deal
    {
        public string Meal { get; set; }
        public string Entree { get; set; }
        public string Meat { get; set; }
        public string Bread { get; set; }
        public bool Cheese { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        public virtual string GetDrink()
        {
            Console.Write("What would you like to drink?:\n");
            var drink = Console.ReadLine();

            if (drink != null)
                return drink.ToLower().Trim();

            Console.Write("Please enter a valid drink?:\n");
            return GetDrink();
        }

        public virtual string GetSide()
        {
            Console.Write("What side would you like?:\n");
            var side = Console.ReadLine();

            if (side != null)
                return side.ToLower().Trim();

            Console.Write("Please enter a valid side?:\n");
            return GetSide();
        }



        public abstract Deal GetOrder();
        public abstract void PrintOrder(Deal meal);
        protected abstract Deal GetMealDeal();
        public abstract string GetEntree();

    }
}
