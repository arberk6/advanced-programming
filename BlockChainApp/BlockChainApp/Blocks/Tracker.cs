using System;
using System.IO;

namespace BlockChainApp.Blocks
{
    public class Tracker
    {
        public static void Main()
        {
            string path = @"C:\Users\arkad\Desktop\block";

            try
            {

                //to be continued
                //changed files tracker
                var fi = new DirectoryInfo(path);

                while (true)
                {
                    fi.Refresh();
                    DateTime dt = fi.LastAccessTime; 
                    DateTime f1 = fi.LastWriteTime;
                    Console.WriteLine("test");
                    Console.Write(true);
                }
                //

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
