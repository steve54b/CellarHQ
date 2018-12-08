using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Transaction
    {
        public int WineID { get; set;}
        public DateTime Timestamp { get; set; }
        public string AddOrRemove { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

        public Transaction() { }

        public void CreateTransaction(int wineID, string addOrRemove, int quantity,
            string comment)
        {
            Transaction thisTransaction = new Transaction();

            WineID = wineID;
            Timestamp = DateTime.Now;
            AddOrRemove = addOrRemove;
            Quantity = quantity;

            DisplayTransactions(thisTransaction);
        }

        public static void AddTransactionToList(List<Transaction> transactionsList,
            Transaction thisTransaction)
        {
            transactionsList.Add(thisTransaction);
        }

        public void DisplayTransactions(Transaction thisTransaction)
        {
            // USE LINQ to create a list of transactions for the given wine, then display
            //   in foreach loop.

            UserInterface.DisplayMessage("You just added the following transaction to the " +
                $"cellarTransactions list:\n{thisTransaction.ToString()}");
        }

        public override string ToString()
        {
            string toString = $"Wine: {WineID}; Time Stamp: {Timestamp}; " +
            $"Add/Remove: {AddOrRemove}; Number of bottles: {Quantity}";

            return toString;

        }

    }
}
