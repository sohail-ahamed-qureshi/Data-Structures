using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructures
{
    /// <summary>
    /// Orderedlist problem statment.
    /// </summary>
    class OrderedList
    {
        /// <summary>
        /// performs - reads the file and stores all numbers in an array in ascending order
        /// search for particular number if found remove the number from list, if not add to appropriate position in list.
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
            Console.WriteLine("Elements present in file in sorted manner: ");
            linkedlist = SortList(linkedlist);
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
                LinkedListNode<int> temp = linkedlist.First;
                if (linkedlist.Count == 0)
                {
                    linkedlist.AddFirst(search);
                }
                while (temp != null)
                {
                    if (temp.Value >= search)
                    {
                        linkedlist.AddFirst(search);
                        break;
                    }
                    if (search >= linkedlist.Last.Value)
                    {
                        linkedlist.AddLast(search);
                        break;
                    }
                    if (temp.Value <= search && temp.Next.Value >= search)
                    {
                        linkedlist.AddAfter(temp, search);
                        break;
                    }
                    temp = temp.Next;
                }
                Console.WriteLine($"{search} not found. Added in the list.");
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
        /// <summary>
        /// performs traditional sorting
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public LinkedList<int> SortList(LinkedList<int> linkedList)
        {
            LinkedListNode<int> node = linkedList.First;
            LinkedListNode<int> firstval;
            int val;
            while (node != null)
            {
                firstval = node.Next;
                while (firstval != null)
                {
                    if (node.Value > firstval.Value)
                    {
                        val = firstval.Value;
                        firstval.Value = node.Value;
                        node.Value = val;
                    }
                    firstval = firstval.Next;
                }
                node = node.Next;
            }
            return linkedList;
        }
    }
}
