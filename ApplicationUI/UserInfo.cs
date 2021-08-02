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
           // isEmailValid();
            //Console.ReadLine();
            Console.WriteLine("Please enter your favourite dish:   ");
            food = Console.ReadLine();
            userdetail.Add(name);
            userdetail.Add(surname);
            userdetail.Add(email);
            userdetail.Add(food);
            Console.ReadKey();
            string Something = string.Join("       |      ", userdetail);
            names.enqueue(Something);
            FileManagement.UserFile(Something);
            Console.Clear();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                System.Console.WriteLine("Password invalid");
                return true;
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("Password invalid");
                return true;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                System.Console.WriteLine("Password invalid");
                return false;
            }
        }


        public static void RemoveUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("The elements in the queue are:" + names.Count());
            //names.dequeue();//Method dequeue remove the first element in a queue
            //showing the elements in a queue after removing one element from the queue
            //looping in list of names in a Queue 
            //foreach (string name in Queue. names)
            // {
                   // Console.WriteLine(names);
            // }
            Console.WriteLine("After removal the elements in the queue are:");
        }
        public static void DisplayUsers()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("The elements in the queue are:" + names.Count());
            //showing the elements in a queue
            Console.WriteLine("The elements in the queue are: ");
        }


        public static string SaveUser(string key)
        {
            //Instance of Queue and add items by calling Enqueue method
             Queue names = new Queue();

            //Method Enqueue adds the following users to the queue
            names.enqueue("Sarah" + "Marshall" + "Sarah@user.com" + "Mohodu");
            names.enqueue("Anna" + "Skhu" + "Anna@user.com" + "Skopo");
            
            
            names.enqueue(key);
            return key;
        }

    }
}