using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Banking simulation Problem statment to perfrom Transactions for people in Queue.
    /// </summary>
    class BankingSimulation
    {
        /// <summary>
        /// Perform Deposit or Withdrawl function when people present in Queue.
        /// </summary>
        public void CashCounter()
        {
            //initial cash with the bank
            double bankCash = 1000.25;
            //Queue of people
            Queue<People> line = new Queue<People>();

            People person = new People
            {
                deposit = 1000,
            };
            People person1 = new People
            {
                withdrawl = 500,
            };
            line.Enqueue(person);//deposit person
            line.Enqueue(person1);//withdrawl person
            //while there are people in line on cash counter
            while (line.Count != 0)
            {
                //check if first person in line is here for deposit or withdrawl
                if (ToDeposit(line.Peek()))
                {
                    //make transaction
                    bankCash += line.Peek().deposit;
                    Console.WriteLine("Deposit successfull");
                    //leave the line after transaction
                    line.Dequeue();
                    Console.WriteLine("Cash in bank after deposit: " + bankCash);
                }
                //person is here for wothdrawl
                if (!ToDeposit(line.Peek()))
                {
                    //check whether bank has sufficient money....
                    if (bankCash <= 0 || bankCash < line.Peek().withdrawl)
                    {
                        //person will wait until bank has sufficient cash
                        Console.WriteLine("Sorry!! Out of Cash..");
                    }
                    //once bank has more cash do transaction
                    if (bankCash >= line.Peek().withdrawl)
                    {
                        //withdrawl from bank
                        bankCash -= line.Peek().withdrawl;
                        Console.WriteLine("Cash in bank after withdrawl: " + bankCash);
                        //after transaction leave the line
                        line.Dequeue();
                    }
                }
            }
            //cash available at the end of transactions
            Console.WriteLine($"Total cash available at Bank : {bankCash}");
        }
        /// <summary>
        /// checks whether the person has come for Deposit
        /// returns true or false.
        /// </summary>
        /// <param name="person"> person object from People class</param>
        /// <returns></returns>
        private bool ToDeposit(People person)
        {
            if (person.deposit != 0)
                return true;
            else
                return false;
        }
    }
    /// <summary>
    /// People class with deposit and withdrawl property
    /// </summary>
    class People
    {
        public double deposit { get; set; }
        public double withdrawl { get; set; }
    }
}
