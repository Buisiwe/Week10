using System;
using System.Collections.Generic;
using ApplicationUI;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace UserApplication
{
    public class UserInterface
    {
        

        public static void Display()
        {
           
            bool userContinue = true;
            while (userContinue) 
            {
                System.Console.WriteLine("---------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Welcome to Buisiwe's Queue App.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to Add User to the Queue");
                Console.WriteLine("2 to Remove User from the Queue");
                Console.WriteLine("3 to See All Users in Queue");
                Console.WriteLine("0 to exit");
                Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                try {
                    UserInfo.GetInputUser();
                        }
                        catch (ArithmeticException ex) //Catches all errors relating to arithmetic operations
                        {

                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)  //Catches all unforseen errors
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.WriteLine("Information of a user added successfully!");
                        break;
                case "2":
                    try{
                            UserInfo.RemoveUser();
                       }
                    catch (ArithmeticException ex) //Catches all errors relating to arithmetic operations
                        {
                            Console.WriteLine(ex.Message);
                        }
                    catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                case "3":
                    try {
                            UserInfo.DisplayUsers();
                        }
                    catch (ArithmeticException ex) //Catches all errors relating to arithmetic operations
                        {

                            Console.WriteLine(ex.Message);
                        }
                    catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                case "0":
                    try {
                            userContinue = false;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Thank you for using Buisiwe's Queue App!");
                    }
                    catch (ArithmeticException ex) //Catches all errors relating to arithmetic operations
                        {

                            Console.WriteLine(ex.Message);
                        }
                    catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    
                    break;
                default:
                    Console.Clear();
                    break;
                
            }
         }
       }
    }
}
