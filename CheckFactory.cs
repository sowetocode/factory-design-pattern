using System;


namespace FactoryPattern
{
    class CheckFactory
    {
        public CheckFactory()
        {

        }

        public CheckBook chooseExpense(int expense)
        {
            switch (expense)
            { 
                case 1:
                    return new Personal();
                case 2:
                    return new Travel();
                default:
                    return new Health();

            }

        }

    }
}
