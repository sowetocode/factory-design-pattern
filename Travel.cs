using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Travel : CheckBook
    {

        public Travel()
        {
            _Amount = 10000;//Could be any logic to calculate travel amount
            Console.WriteLine("Your Travel Expense: {0}", _Amount);
        }

    }
}
