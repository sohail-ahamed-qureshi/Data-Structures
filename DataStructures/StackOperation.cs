using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StackOperation
    {
        /// <summary>
        /// Performs balanced parantheses operation that after the string if the 
        /// stack contains any of single parantheses then returns false, else true.
        /// </summary>
        /// <returns></returns>
        public bool BalancedParantheses()
        {
            string expr = "{(5+6)*(7+8)}/{(4+3)(5+6)}*{(7+8)/(4+3)}]";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < expr.Length; i++)
            {
                //if we encounter opening brackets then simply push to stack
                if (expr[i] == '(' || expr[i] == '{' || expr[i] == '[')
                {
                    stack.Push(expr[i]);
                }
                //if we encounter closing brackets then we pop top element of stack
                if (expr[i] == ')' || expr[i] == '}' || expr[i] == ']')
                {
                    //if closing bracket is last char and stack is empty means
                    //closing bracket is single in this case we return false.
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Expression is not balanced");
                        return false;
                    }
                    //if the closing bracket is not pairing with top char then pop it
                    //as it is single
                    if (!expr[i].Equals(stack.Peek()))
                    {
                        stack.Pop();
                    }
                }
            }
            //if stack is empty means every bracket has its matching pair else
            // stack is not balanced.
            if (stack.Count == 0)
            {
                Console.WriteLine("Expression is balanced");
                return true;
            }
            else
            {
                Console.WriteLine("Expression is not balanced");
                return false;
            }
        }
    }
}
