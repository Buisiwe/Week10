using System.IO;
using System;
using System.Text;
namespace ApplicationUI
{
    public static class FileManagement
    {
        public static void UserFile(string key)
        {
            //Writing elements to the Users text file
            try
            {
                   
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\buisi\\OneDrive\\Documents\\Week10Task\\Users.txt");
                //Write a line of text
                sw.WriteLine(key);
                //sw.Flush();
                //Write a second line of text
                //sw.WriteLine("From the StreamWriter class");
                //Close the file
                //sw.Close();
                sw.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Information successfully written on the file.");
            }


           
        }
        
        public static void ReaderFileUser()
        {
            //Reading elements from the Users text file
            
            try
            {
                using var fs = new FileStream("C:\\Users\\buisi\\OneDrive\\Documents\\Week10Task\\Users.txt", FileMode.Open, FileAccess.Read);
                using var sr = new StreamReader(fs, Encoding.UTF8);
                String line = String.Empty;
                //string content = await sr.ReadToEndAsync();
                //Console.WriteLine(content);
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader("C:\\Users\\buisi\\OneDrive\\Documents\\Week10Task\\Users.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {

                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    Console.WriteLine("This is the information from a text file.");

                }

                //close the file
                sr.Close();
                Console.ReadLine();
                UserInfo.SaveUser(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            } 
        }

       // private async void SetUser()
        //{
            //var dp = await f
        //}
    }
}