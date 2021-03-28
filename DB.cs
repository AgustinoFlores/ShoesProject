using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DB
    {
        private static Boolean cartHasItems = false;

        public static Boolean cartItems()
        {
            return cartHasItems;
        }
    }
}
