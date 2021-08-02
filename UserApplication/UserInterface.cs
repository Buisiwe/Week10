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
            //Queue<string> names = new Queue<string>();
            bool userContinue = true;
            while (userContinue) 
            {
                System.Console.WriteLine("---------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Welcome to queue app.");
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
                        break;
                case "2":
                    UserInfo.DisplayUsers();
                        break;
                case "3":
                    FileManagement.ReaderFileUser();
                        break;
                case "0":
                    userContinue = false;
                    break;
                default:
                    Console.Clear();
                    break;
                
            }
        }
            //Queue<string> names = new Queue<string>();


    //string user;
    
     
   // userdetail= user.
//names.Enqueue(userdetail);


//Queue<int> myQueue = new Queue<int>();

 //foreach (string value in userdetail)
       // {
                    //names.(value);
                    //Console.WriteLine(names);
                    // return value;
                    //Console.WriteLine(value);
                    
       // }
   // Console.WriteLine("The elements in the queue are:" + names.Count());
    //Console.WriteLine("The element Busi is contain in the queue:" + names.Contains("Busi"));
    



   

            
            //Contain method checks if user exist in a queue it will return true or false
           // Console.WriteLine("The element Ngozo is contain in the queue:" + names.Contains("Ngozo@user.com"));
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("The element Peter is contain in the queue:" + names.Contains("Peter@user.com"));

            //Clear method clears elements in the queue
           // names.Clear();
            ////looping in list of names in a Queue after clearing the elements in the queue
            //foreach (string name in names)
            //{
                //Console.WriteLine(name);
            //}
           // Console.WriteLine("The elements in the queue are been cleared");
            //Console.WriteLine("The elements in the queue is now:" + names.Count);
        
       }
    }
}
