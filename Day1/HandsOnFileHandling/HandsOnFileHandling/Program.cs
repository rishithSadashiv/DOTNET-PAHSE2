using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Program
    {
        public static void Read(string path)
        {
            using(StreamReader sr=new StreamReader(path))
            {
                string content = sr.ReadToEnd();//reads all lines of text in the file 
                Console.WriteLine(content);
            }
        }
        public static void Write(string path,string content)
        {
            using(StreamWriter sw=new StreamWriter(path,true))
            {
                sw.WriteLine(content);
            }
        }
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Enter Path");
                string path = Console.ReadLine();
                Console.WriteLine("Enter Content");
                string content = Console.ReadLine();
                Write(path, content);
              //  Read(path);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
