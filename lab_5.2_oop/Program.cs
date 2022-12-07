using System;

namespace lab_5._2_oop
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassRoom classroom = new ClassRoom();
            classroom.Pupil2(new ExcelentPupil(),new ExcelentPupil(),new ExcelentPupil());
            Console.ReadKey();
        }
    }
}
