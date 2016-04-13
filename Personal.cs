using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Personal : CheckBook
    {
        public Personal()
        {
            _Amount = 15000;
            Console.WriteLine("Your Personal Expense: {0}", _Amount);
        }
    }
}
