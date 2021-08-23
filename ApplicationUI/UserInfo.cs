using System;
using System.Collections.Generic;
using ApplicationUI;
using System.Net.Mail;
using System.Globalization;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
namespace ApplicationUI
{
    public class UserInfo
    {
        private static string name;
        private static string surname;
        private static string email;
        private static string food;
        public static void GetInputUser()
        {
            Queue names = new Queue();
            List<string> userdetail = new List<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name:  ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your surname:   ");
            surname = Console.ReadLine();
            Console.WriteLine("Please enter your email address:   ");
            email = Console.ReadLine();
            IsValidEmail(email);
            Console.WriteLine("Please enter your favourite dish:   ");
            food = Console.ReadLine();
            userdetail.Add(name);
            userdetail.Add(surname);
            userdetail.Add(email);
            userdetail.Add(food);
            Console.ReadKey();
            string Something = string.Join("       |      ", userdetail);
            names.Enqueue(Something);
            FileManagement.UserFile(Something);
            Console.Clear();
            System.Console.WriteLine(name + "  " + surname + "  " + "is added on the queue");
        }
        public static bool IsValidEmail(string newEmail)
        {
            try {
                if (!Regex.IsMatch(email, @"^[^@\s\.]+@[^@\s]+\.[^@\s]+$"))
                {
                    Console.WriteLine("invalid email format. Enter something like: name@domain.com");
                    Console.Clear();
                    Console.WriteLine("Please re-enter valid email: ");
                    newEmail = Console.ReadLine();
                    email = newEmail;
                    return false;
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
            }
        
            return true;
        }


        public static void RemoveUser()
        {
            Queue names = new Queue();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("---------------------------------------------------------------------");
            UserList.RemoveLines(1, @"c:UsersFile.txt");
            names.Dequeue();//Method dequeue remove the first element in a queue
            Console.WriteLine("You have removed first user from the queue");
        }
        public static void DisplayUsers()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("The elements in the queue are: ");
            FileManagement.ReaderFileUser();//calling ReaderFileUser method from FileManagement class to display users from the text file
        }
        

        public static string SaveUser(string key)
        {
            //Instance of Queue and add items by calling Enqueue method
             Queue names = new Queue();
            names.Enqueue(key);
            return key;
        }

    }
}