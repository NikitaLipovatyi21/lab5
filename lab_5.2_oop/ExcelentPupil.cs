using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5._2_oop
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I am very hard-working and do my best on every lesson at school");
        }
        public override void Read()
        {
            Console.WriteLine("I read 300 words in a minute");
        }
        public override void Write()
        {
            Console.WriteLine("I write with no any mistakes");
        }
        public override void Relax()
        {
            Console.WriteLine("I don't what the word 'relax' means");
        }
    }
}
