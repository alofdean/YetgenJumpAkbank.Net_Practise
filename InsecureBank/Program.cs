using System;
using System.Collections.Generic;
using System.Reflection;

namespace Lecture_1.Part_1.InsecureBank;
class Program
{
    static List<string> accountOwners = new List<string>();
    static List<double> accountBalances = new List<double>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the Insecure Bank!");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            bool choice_control = int.TryParse(Console.ReadLine(), out choice);
            if (choice_control)
            {
                if (0 < choice && choice < 6)
                {
                    choice = choice;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1-5!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }



            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the Insecure Bank!");
                    return;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        var count = ownerName.Count(char.IsLetter);

        if (count > 0)
        {
            if (!char.IsLetter(ownerName[0]))
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (accountOwners.IndexOf(ownerName) != -1)
                {
                    Console.WriteLine("This user already created!");
                }
                else
                {
                    accountOwners.Add(ownerName);
                    accountBalances.Add(0.0);
                    Console.WriteLine("Account created successfully!");
                }
            }

        }
        else
        {
            Console.WriteLine("Please enter a name!");
        }

    }

    static void DepositMoney()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        int index;
        double amount;
        var count = ownerName.Count(char.IsLetter);

        if (count > 0)
        {
            if (!char.IsLetter(ownerName[0]))
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (accountOwners.IndexOf(ownerName) == -1)
                {
                    Console.Write("User can not found!");
                }
                else
                {
                    index = accountOwners.IndexOf(ownerName);
                    Console.Write("Enter the amount to deposit: ");

                    if (double.TryParse(Console.ReadLine(), out amount))
                    {
                        if (0 < amount)
                        {
                            accountBalances[index] += amount;
                            Console.WriteLine($"Deposited ${amount}. New balance: ${accountBalances[index]}");
                        }
                        else
                        {
                            Console.WriteLine("Please deposit money more than 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                }


            }
        }
        else
        {
            Console.WriteLine("Please enter a name!");
        }
    }

    static void WithdrawMoney()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        var count = ownerName.Count(char.IsLetter);

        if (count > 0)
        {
            if (!char.IsLetter(ownerName[0]))
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (accountOwners.IndexOf(ownerName) == -1)
                {
                    Console.Write("User can not found!");
                }
                else
                {
                    int index = accountOwners.IndexOf(ownerName);

                    Console.Write("Enter the amount to withdraw: ");


                    int amount;
                    bool choice_control = int.TryParse(Console.ReadLine(), out amount);
                    if (choice_control)
                    {
                        if (amount > 0)
                        {
                            if (accountBalances[index] >= amount)
                            {
                                accountBalances[index] -= amount;
                                Console.WriteLine($"Withdrawn ${amount}. New balance: ${accountBalances[index]}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Amount can not be negative!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number.");
                    }

                }

            }
        }
        else
        {
            Console.WriteLine("Please enter a name!");
        }

        
     
    }

    static void CheckBalance()
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        var count = ownerName.Count(char.IsLetter);

        if (count > 0)
        {
            if (!char.IsLetter(ownerName[0]))
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (accountOwners.IndexOf(ownerName) == -1)
                {
                    Console.Write("User can not found!");
                }
                else
                {
                    int index = accountOwners.IndexOf(ownerName);

                    Console.WriteLine($"Your balance is ${accountBalances[index]}");
                }

            }
        }

        else
        {
            Console.WriteLine("Please enter a name!");
        }
    }
        
}
