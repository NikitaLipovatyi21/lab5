using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5_oop
{
    class Red:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);

        }
    }
}
