 using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

var input = 0;
var balance = 0;
void WelcomeMessage()
{
    Console.WriteLine("------Welcome to Fatimah Bank ------\nTo register customer press 1\nTo create account press 2\nTo view account d press 3\nTo deposit press 4\nTo withdraw press 5\nTo c\nTo exit press 4");
    var isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum == false || num < 1 || num > 7)
    {
        input = Num(1);
    int RegisterCustormer = 0;
        Console.WriteLine("invalid input number()");

        {
            Console.WriteLine("------Welcome to Fatimah Bank ------\nTo register customer press 1\nTo create account press 2\nTo view account d press 3\nTo deposit press 4\nTo withdraw press 5\nTo c\nTo exit press 4");
            var isnum = int.TryParse(Console.ReadLine(), out);
            if (isNum == false || num < 1 || num > 7)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                WelcomeMessage();
            }
            input = num;
        int = RegisterCustormer;
            Console.WriteLine("register custormer");
        }
        WelcomeMessage();

        if (input == 1)
        {
            Deposit();
        }
        else if (input == 1) ;

        Console.WriteLine("------Welcome to Fatimah Bank ------\nTo register customer press 1\nTo create account press 2\nTo view account d press 3\nTo deposit press 4\nTo withdraw press 5\nTo c\nTo exit press 4");
        var isnum = int.TryParse(Console.ReadLine(), out);
                WelcomeMessage();
        int CreateAccount;
        {
            Console.WriteLine("  please enter the correct customerName, customerPin, customerBalance, customerPin,customer");
            var isNum = int.TryParse(Console.ReadLine(), out int reatAccount);
            if (isNum == true);
            {
                
            }

        }
        void Deposit()
        {
            Console.WriteLine("Enter amount to deposit:");
            var isNum = int.TryParse(Console.ReadLine(), out int depositAmount);
            if (isNum == false)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                WelcomeMessage();
            }

            if (depositAmount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                WelcomeMessage();
            }

            balance += depositAmount;

            Console.WriteLine($"Your deposit was successful and your new balance is {balance}");
        }

        WelcomeMessage();

        if (input == 3)
        {
            Deposit();
        }
        else if (input == 4) ;
}
 void viewAccount()
            {
              Console.WriteLine("Enter amount to view account:");
               var isNum = int.TryParse(Console.ReadLine(), out int viewaccount);
        if (isNum == false);
        {
            Console.WriteLine("valid input Account details");
            WelcomeMessage();
            Console.WriteLine($"Your ViewAccount was successful and your new balance is {balance}");
        }
