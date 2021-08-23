using System.IO;
using System;
using System.Text;
using System.Text.RegularExpressions;
//using Windows.Storage.Streams;

namespace ApplicationUI
{
    public static class FileManagement
    {
        public static void UserFile(string key)
        {
           
            //Writing elements to the Users text file
            try
            {
                
                using(StreamWriter writer = new StreamWriter(@"c:UsersFile.txt", true))
                {
                    
                    writer.WriteLine(key);
                    string text = File.ReadAllText(@"c:UsersFile.txt");
                    string result = Regex.Replace(text, @"(^\p{Zs}*\r\n){2,}", "\r\n", RegexOptions.Multiline);
                    File.WriteAllText(@"c:UsersFile.txt", result);
                    writer.Close();
                    writer.Dispose();
                }
                
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
                using var fs = new FileStream(@"c:UsersFile.txt", FileMode.Open, FileAccess.Read);
                using var sr = new StreamReader(fs, Encoding.UTF8);
                String line = String.Empty;
                //string content = await sr.ReadToEndAsync();
                //Console.WriteLine(content);
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(@"c:UsersFile.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {

                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    

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