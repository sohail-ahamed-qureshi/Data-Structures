using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace DataStructures
{
    /// <summary>
    /// Orderedlist problem statment.
    /// </summary>
    class OrderedList
    {
        /// <summary>
        /// performs - reads the file and stores all numbers in an array
        /// search for particular number if found remove the number if not add to it.
        /// </summary>
        public void Operation()
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            using (Stream stream = File.Open(@"C:\Users\Admin\Desktop\BridgeLabs Assignments\Data-Structures\DataStructures\DataOrderedList.txt", FileMode.Open))
            using (TextReader sr = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Trim().Split(',');
                    foreach (var item in arr)
                    {
                        linkedlist.AddLast(Convert.ToInt32(item));
                    }
                }
            }
            Console.WriteLine("Elements present in file: ");
            Display(linkedlist);
            Console.WriteLine("Enter the number : ");
            int search = Convert.ToInt32(Console.ReadLine());
            if (linkedlist.Contains(search))
            {
                linkedlist.Remove(search);
                Console.WriteLine($"{search} removed from the list.");
            }
            else
            {
                Console.WriteLine($"{search} not found. Added in the list.");
                linkedlist.AddLast(search);
            }
            Console.WriteLine();
            Display(linkedlist);

        }
        /// <summary>
        /// display function for linkedlist
        /// </summary>
        /// <param name="linkedList"></param>
        public void Display(LinkedList<int> linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
