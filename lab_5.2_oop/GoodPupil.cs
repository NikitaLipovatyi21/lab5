using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5._2_oop
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study not excellent but I have good enough marks");
        }
        public override void Read()
        {
            Console.WriteLine("I read 200 words in a minute");
        }
        public override void Write()
        {
            Console.WriteLine("Sometimes I can make a couple of mistakes while writing");
        }
        public override void Relax()
        {
            Console.WriteLine("I suposse it's okay to relax for a while");
        }
    }
}
