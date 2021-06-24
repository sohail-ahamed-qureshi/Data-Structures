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
            UnorderedList unorderedList = new UnorderedList();
            unorderedList.Operation();
        }
    }
}
