using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5._2_oop
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I visit my school from time to time and for me it's already success");
        }
        public override void Read()
        {
            Console.WriteLine("I read 100 words in a minute");
        }
        public override void Write()
        {
            Console.WriteLine("we learn from our mistakes so while writing I make a lot of the ones");
        }
        public override void Relax()
        {
            Console.WriteLine("I admire relaxing!");
        }
    }
}
