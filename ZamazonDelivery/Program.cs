using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lecture_1.Part_1.InsecureBank;
class Program
{
    static List<string> customers = new List<string>();
    static List<string> orders = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Zamazon Customer and Order Management System");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. View Orders");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            bool choice_control = int.TryParse(Console.ReadLine(), out choice);
            if (choice_control)
            {
                if (0 < choice && choice < 5)
                {
                    choice = choice;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1-4!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        PlaceOrder();
                        break;
                    case 3:
                        ViewOrders();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            var count = customerName.Count(char.IsLetter);
        if (count > 0)
        {
            if (!char.IsLetter(customerName[0]) && count > 0)
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (customers.IndexOf(customerName) != -1)
                {
                    Console.WriteLine("This user already created!");
                }
                else
                {
                    customers.Add(customerName);
                    Console.WriteLine($"Customer '{customerName}' added successfully!");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a name!");
        }
        

        }

    static void PlaceOrder()
    {
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        var count = customerName.Count(char.IsLetter);
        if (count > 0)
        {
            if (!char.IsLetter(customerName[0]))
            {
                Console.WriteLine("Please enter your name correct!");
            }
            else
            {
                if (customers.IndexOf(customerName) == -1)
                {
                    Console.Write("User can not found!");
                }
                else
                {
                    Console.Write("Enter order details: ");
                    string orderDetails = Console.ReadLine();

                    orders.Add($"{customerName}: {orderDetails}");
                    Console.WriteLine("Order placed successfully!");

                }

            }
        }
        else
        {
            Console.WriteLine("Please enter a name!");
        }

    }
        
            static void ViewOrders()
            {
                Console.WriteLine("Orders:");
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }
        
    }
