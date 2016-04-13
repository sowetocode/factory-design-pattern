using System;


namespace FactoryPattern
{
    public class Health : CheckBook
    {
        public Health()
        {
            _Amount = 5000;//Could be any logic to calculate health amount
            Console.WriteLine("Your Health Expense: {0}", _Amount);
        }
    }
}
