using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace CSharpConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorWrite(ConsoleColor.Cyan, "Scribe v1.0");
            ColorWrite(ConsoleColor.DarkCyan, "Zach Buchanan\tRoger Cooper\tDan Hebenthal\nDonny Jones\tJoshua Moore");
            Console.Write("\nEnter Working Directory > ");
            string path = Console.ReadLine();

            ColorWrite(ConsoleColor.Red, "Could not open " + path);


            using (FileStream fs = File.OpenRead(path))
            {
                XElement xl = XElement.Load(fs);
            }

        }

        static void ColorWrite(ConsoleColor c_, string s_)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = c_;
            Console.WriteLine(s_);
            Console.ForegroundColor = temp;
        }
    }
}