using System;

namespace lab_5_oop
{
    class Program
    {
        static void Main(string[] args)
        {
          //Printer printer = new Printer();
            Printer red = new Red();
            Printer blue = new Blue();
            Printer green = new Green();
            red.Print("you see red text");
            blue.Print("now it blue");
            green.Print("and now it became green");
            Console.ReadKey();
        }
    }
}
