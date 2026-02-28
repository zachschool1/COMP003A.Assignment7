namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //daily expense tracker
            List<double> expenses = new List<double>();

            double currentExpense;

            do
            {
                Console.WriteLine("1) Add New Expense.");
                Console.WriteLine("2) Show all expenses.");
                Console.WriteLine("3) Delete an expense.");
                Console.WriteLine("4) Exit the program.");

                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        //add new expense
                        //expenses.Add(currentExpense);
                        break;
                    case "2":
                        //show all expenses
                        break;
                    case "3":
                        //show all expenses
                        break;
                    case "4":
                        break;
                    default:
                        Console.Write("Please choose between option 1-4.");
                        break;
                }

            } while (true);


            


        }
/*
        static double getExpense(string expense)
        {
            Console.WriteLine("How much did you spend on food today?");
        }*/
    }
}
