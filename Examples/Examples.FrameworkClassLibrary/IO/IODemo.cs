using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FrameworkClassLibrary.IO
{
    public class IODemo
    {
        private const string path = @"c:\Codes OutPut";
        private const string file = path + @"\test.txt";
        public static void Demo()
        {
            #region Directory/File vs DirectoryInfo/FileInfo
            // Summary:Directory
            //     Exposes static methods for creating, moving, and enumerating through directories
            //     and subdirectories. This class cannot be inherited.
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                var a = Directory.GetDirectories(path);
            }

            // Summary: File
            //     Provides static methods for the creation, copying, deletion, moving, and opening
            //     of a single file, and aids in the creation of System.IO.FileStream objects.
            if (!File.Exists(file))
            {
                File.Create(file);
            }

            // Summary: DirectoryInfo
            //     Exposes instance methods for creating, moving, and enumerating through directories and subdirectories.
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            // Summary:
            //     Provides properties and instance methods for the creation, copying, deletion,
            //     moving, and opening of files, and aids in the creation of System.IO.FileStream
            //     objects. This class cannot be inherited.
            FileInfo[] files = dirInfo.GetFiles();
            foreach (var item in files)
            {
                Console.WriteLine("{0}-{1}-{2}", item.Name, item.Length, item.CreationTime);
            }
            #endregion

            #region Write File
            using (StreamWriter w = new StreamWriter(file))
            {
                w.WriteLine("Hello, world");
                w.WriteLine("Hello, IO");
                w.Flush();
                w.Close();
            }
            #endregion
            #region Read File (using StreamReader/BinaryReader)
            using (StreamReader r = new StreamReader(file))
            {
                string input = string.Empty;
                while ((input = r.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                r.Close();
            }

            var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(stream);

            for (int i = 0; i < 12; i++)
            {
                Console.Write(reader.ReadChar());
            }
            reader.Close();
            stream.Close();

            #endregion
        }
    }
}
