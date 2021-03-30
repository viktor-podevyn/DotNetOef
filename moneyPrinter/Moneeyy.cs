using System;


namespace moneyPrinter
{
    
    class Moneeyy
    {
        static void Loop(BankAccount bankAccount, Client currentUser)
        {
            Console.WriteLine("What would you like to do today? (Withdraw, Deposit, Check, Quit)");
            var reply = Console.ReadLine(); 
            
            switch (reply)
            {
                case "Withdraw":
                {
                    Console.WriteLine("What amount do you want to withdraw?");
                    var amount = Double.Parse(Console.ReadLine());
                    bankAccount.MakeWithdrawal(amount);
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "Deposit":
                {
                    Console.WriteLine("What amount do you want to deposit?");
                    var amount = Double.Parse(Console.ReadLine());
                    bankAccount.MakeDeposit(amount);
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "Check":
                {
                    Console.WriteLine("You currently have "+bankAccount.CheckBalance()+ " in your bank account");
                    Console.WriteLine(" And you joined us on " + currentUser.JoinDate+".");
                    Loop(bankAccount,currentUser);
                    break;
                }
                case "Quit":
                {
                    Console.WriteLine("See you soon!!");
                    break;
                }
                default:
                {
                    Console.WriteLine("The order name is case sensitive!");
                    Loop(bankAccount, currentUser);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BNP Viktwaar! What is your name?");
            var name = Console.ReadLine();
            
            
            Console.WriteLine(" How much money do you have right now!");
            var initialBalance = Double.Parse(Console.ReadLine());

            
            var currentUser = new Client(1, name);
            var bankAccount = new BankAccount(currentUser, initialBalance);
            
            Loop(bankAccount,currentUser);
        }
    }
}