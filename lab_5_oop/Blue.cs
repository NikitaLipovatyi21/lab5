using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_oop
{
    class Blue:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
}
