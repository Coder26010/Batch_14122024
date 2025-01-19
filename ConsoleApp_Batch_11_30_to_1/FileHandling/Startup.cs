using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_Batch_11_30_to_1.FileHandling
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            string projectFolderPath = @"C:\Users\lenovo\source\repos\Batch_14122024\ConsoleApp_Batch_11_30_to_1";
            string NewFolder = DateTime.Now.ToString("ddMMyyyy");

            string folderpath = Path.Combine(projectFolderPath, NewFolder);

            if (!Directory.Exists(folderpath))
            {
                DirectoryInfo infro =  Directory.CreateDirectory(folderpath);
            }

            if (Directory.Exists(folderpath))
            {
                //Directory.Delete(folderpath, true);
            }

            string fileName = $"Log_{DateTime.Now.ToString("ddMMyyyy")}.txt";
            string filePath = Path.Combine(folderpath, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            //StreamWriter sw = new StreamWriter(filePath,true);

            //sw.WriteLine("Date & time : " + DateTime.Now.ToString());
            //sw.WriteLine("Error Message : " + "This is another error  message");
            //sw.WriteLine("---------------------------------------------------");

            //sw.Close();

            Console.ReadKey();
        }
    }
}
