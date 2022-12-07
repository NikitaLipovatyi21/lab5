using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_oop
{
    class Green:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }
}
