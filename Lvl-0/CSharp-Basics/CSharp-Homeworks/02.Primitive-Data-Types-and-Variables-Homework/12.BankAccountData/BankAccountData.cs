using System;
/* A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 
 * Declare the variables needed to keep the information for a single bank account using the appropriate
 * data types and descriptive names. */

    class BankAccountData
    {
        static void Main()
        {
            string holderFirstName = "Ivan";
            string holderMiddleName = "Ivanov";
            string holderLastName = "Ivanov";
            string fullName = holderFirstName + " " + holderMiddleName + " " + holderLastName;
            decimal balance = 5354.54M;
            string iban = "BGA2 4331 220A C321 4343 01";
            ulong creditCard1 = 3221325643653456;
            ulong creditCard2 = 3232554400984532;
            ulong creditCard3 = 1098123455437395;
            Console.WriteLine("Holder's name: {0}", fullName);
            Console.WriteLine("Balance of the account: {0}", balance);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Numbers of credit cards are:");
            Console.WriteLine(creditCard1);
            Console.WriteLine(creditCard2);
            Console.WriteLine(creditCard3);
        }
    }

