using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ItemFactory : IGetItem
    {
        public Item GetPurchaseItem(int input)
        {
            switch (input)
            {
                case 1:
                    return new Lemon();
                case 2:
                    return new Sugar();
                case 3:
                    return new Ice();
                case 4:
                    return new Cup();
                default:
                    throw new ApplicationException(string.Format("Not a valid item to purchase"));
            }
        }
    }
}
