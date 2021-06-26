using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace DataStructures
{
    class UnorderedList
    {
        /// <summary>
        /// Read file >> arrange in Linkedlist >> search a word >> if found, remove >> else, add string to list.
        /// </summary>
        public void Operation()
        {
            string filepath = @"C:\Users\Admin\Desktop\BridgeLabs Assignments\Data-Structures\DataStructures\DataFile.txt";
            string data = File.ReadAllText(filepath);
            Console.WriteLine("Data from the file..");
            Console.WriteLine();
            //original data
            Console.WriteLine(data);
            //revoming special characters from the string
            data = Regex.Replace(data, @"[^a-zA-Z0-9 ]+", "");
            Console.WriteLine();
            //data without special characters
            Console.WriteLine(data);
            //adding data to array excluding spaces.
            string[] words = data.Split(' ');
            Console.WriteLine();
            LinkedList<string> linkedlist = new LinkedList<string>();
            //adding data to linked list
            foreach (string item in words)
            {
                linkedlist.AddLast(item);
            }
            Console.WriteLine("data into array...");
            //displaying data in linkedlist
            Display(linkedlist);
            Console.WriteLine("Enter the string you want to search");
            string input = Console.ReadLine();
            if (linkedlist.Contains(input))
            {
                linkedlist.Remove(input);
                Console.WriteLine($"{input} removed from the list");
            }
            else
            {
                linkedlist.AddLast(input);
                Console.WriteLine($"{input} added to the list");
            }
            Display(linkedlist);
        }

        private void Display(LinkedList<string> linkedlist)
        {
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
