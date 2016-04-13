using System;


namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type 1 for Personal expense:");
            Console.WriteLine("Type 2 for Travel expense:");
            Console.WriteLine("Type any number for Health expense:");
            string input = Console.ReadLine();

            CheckFactory objCheckFactory = new CheckFactory();
            CheckBook currentExpense = objCheckFactory.chooseExpense(int.Parse(input));
            Console.WriteLine("From main class " + currentExpense.getExpense());
            Console.Read();
        }
    }
}
