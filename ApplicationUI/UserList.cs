//using UserApplication;
using System.IO;
using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ApplicationUI
{
    public class UserList
    {
         public static void RemoveLines(int Line, string Path)
         {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(@"c:UsersFile.txt"))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(@"c:UsersFile.txt"))
            {
                sw.Write(sb.ToString());
            }

        }
    }
}