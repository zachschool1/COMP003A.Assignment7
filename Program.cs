namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //daily expense tracker

            bool running = true;
            List<double> expenses = new List<double>();

            double currentExpense;

            do
            {
                Console.WriteLine("1) Add New Expense.");
                Console.WriteLine("2) Show all expenses.");
                Console.WriteLine("3) Delete all expenses.");
                Console.WriteLine("4) Exit the program.");

                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        //add new expense
                        //
                        Console.WriteLine("How much did did you spend on food today?");
                        string res = Console.ReadLine();
                        try
                        {
                            if (res != null)
                            {
                                double responseDouble = double.Parse(res);
                                expenses.Add(responseDouble);
                                Console.WriteLine("Added Expense.");
                            } 
                            
                        } catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }

                        
                        
                        
                        break;
                    case "2":
                        Console.WriteLine("All Expenses: ");
                        foreach(double expense in expenses)
                        {
                            Console.WriteLine(expense);
                        }
                        //show all expenses
                        break;
                    case "3":
                        Console.WriteLine("Deleting Expenses.");
                        expenses.Clear();
                        //Delete an expense
                        break;
                    case "4":
                        Console.WriteLine("Quitting Program");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please choose between option 1-4.");
                        break;
                }

            } while (running);


            


        }
/*
        static double getExpense(string expense)
        {
            Console.WriteLine("How much did you spend on food today?");
        }*/
    }
}
