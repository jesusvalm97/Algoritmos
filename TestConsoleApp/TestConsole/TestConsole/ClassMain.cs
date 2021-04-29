using System;
using System.IO;

namespace TestConsole
{
    public class ClassMain
    {
        public bool CreateDirectory()
        {
            // Specify the directory you want to manipulate.
            string path = @"c:\MyDir";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return false;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                var dinfo = new DirectoryInfo(path);

                return true;

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                return false;
            }
        }
    }
}
