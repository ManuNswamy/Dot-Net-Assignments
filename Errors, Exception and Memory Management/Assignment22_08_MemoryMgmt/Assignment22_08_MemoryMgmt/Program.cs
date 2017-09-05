using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment22_08_MemoryMgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIOUsing fileIO_object = new FileIOUsing();
            fileIO_object.CreateFile();
            fileIO_object.WriteFile();
            fileIO_object.ReadFile();

            FileIO fileIO_object1 = new FileIO();
            fileIO_object1.CreateFile();
            fileIO_object1.WriteFile();
            fileIO_object1.ReadFile();
            fileIO_object1.Dispose();
            Console.Read();
        }
    }

    public class FileIO:IDisposable
    {
        string textpath = @"D:\test.txt";
        private StreamWriter writer;
        private StreamReader reader;

        public void CreateFile()
        {
            try
            {
                FileStream fs = File.Create(textpath);                
                Byte[] info = new UTF8Encoding(true).GetBytes("File is Created");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }
        }
        public void WriteFile()
        {
            try
            {
                var writer = new StreamWriter(new FileStream(textpath, FileMode.Open));                
                writer.WriteLine("HELLO");
                writer.WriteLine("WORLD");
                writer.Close();             
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }
        }
        public void ReadFile()
        {
            try
            {
                StreamReader reader = File.OpenText(textpath);
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
                GC.SuppressFinalize(this);
            if (writer != null)
                writer.Dispose();
            if (reader != null)
                reader.Dispose();

        }


    }


    public class FileIOUsing
    {
        string textpath = @"D:\test.txt";

        public void CreateFile()
        {
            try
            {
                using (FileStream fs = File.Create(textpath))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("File is Created");
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }
        }
        public void WriteFile()
        {
            try
            {
                using (var writer = new StreamWriter(new FileStream(textpath, FileMode.Open)))
                {
                    writer.WriteLine("HELLO");
                    writer.WriteLine("WORLD");
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }
        }
        public void ReadFile()
        {
            try
            {
                using (StreamReader sr = File.OpenText(textpath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Handler: {ex}");
            }

        }
       
    }
}
