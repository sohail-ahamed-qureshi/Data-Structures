using System;

namespace DataStructures
{
    class Program
    {
        /// <summary>
        /// Unordered list - read the file and store the text in linkedlist and search for word
        /// if word is found remove from linkedlist, if not found add the word and show output.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to perform operation on Unorderedlist.");
            Console.WriteLine("Press 2 to perform operation on Orderedlist.");
            Console.WriteLine("Press 3 to perform  Stack operation on simple balanced Parantheses.");
            Console.WriteLine("Press 4 to perform  Simulate Banking Cash counter Operation.");
            int inn =Convert.ToInt32( Console.ReadLine());
            switch (inn)
            {
                case 1:
                    //UnorderedList
                    UnorderedList unorderedList = new UnorderedList();
                    unorderedList.Operation();
                    break;
                case 2:
                    //OrderedList
                    OrderedList orderedList = new OrderedList();
                    orderedList.Operation();
                    break;
                case 3:
                    //Simple Balanced Parantheses Expr - (5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3) using stack
                    StackOperation stackOperation = new StackOperation();
                    stackOperation.BalancedParantheses();
                    break;
                case 4:
                    //Simulate banking cash counter
                    BankingSimulation banking = new BankingSimulation();
                    banking.CashCounter();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            } 
        }
    }
}
