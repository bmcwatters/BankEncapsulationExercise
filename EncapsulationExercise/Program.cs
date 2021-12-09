using System;

namespace EncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(0);

            Console.WriteLine("How much money would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");



            Console.ReadLine();
        }
    }
}
