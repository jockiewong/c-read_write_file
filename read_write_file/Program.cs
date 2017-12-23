using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace read_write_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"D:\install.ini");
            File.WriteAllText(@"d:\1.txt", str);           
        }
    }
}
