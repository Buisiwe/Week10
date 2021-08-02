using System;
using System.IO;
using ApplicationUI;
using UserApplication;
using System.Collections.Generic;

namespace UserApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of Queue and add items by calling Enqueue method
            //Queue names = new Queue();

            //Method Enqueue adds the following users to the queue
            //names.enqueue("Sarah" + "Marshall" + "Sarah@user.com" + "Mohodu");
            //names.enqueue("Anna" + "Skhu" + "Anna@user.com" + "Skopo");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("---------------------------------------------------------------------");

            //Call Display method to show options menu to choose from
            UserInterface.Display();
            System.Console.WriteLine("---------------------------------------------------------------------");
            FileManagement.UserFile("");
           
           
        }
    }
}
