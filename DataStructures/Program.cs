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
            Console.WriteLine("Press 1 to perform operation on Unorderedlist");
            Console.WriteLine("Press 2 to perform operation on Orderedlist");
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
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            
        }
    }
}
