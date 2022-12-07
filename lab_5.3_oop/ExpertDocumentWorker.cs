using System;
using System.IO;

namespace lab_5._3_oop
{
    class ExpertDocumentWorker:ProDocumentWorker
    {

        public string expert_key;
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в новому форматi");
        }
        public void CheckExpert()
        {
            if (expert_key is "qwerty")
            {
                ExpertDocumentWorker expert = new ExpertDocumentWorker();
                File.Move("C:\\KNUTE2\\OOP\\lab_5_oop.txt", Path.ChangeExtension("C:\\KNUTE2\\OOP\\lab_5_oop.txt", ".doc"));
                expert.SaveDocument();
            }
            else
            {
                Console.WriteLine("Ключ введено помилково.");
                Console.WriteLine("Файл збережено у старому форматi");
            }
        }

    }
}
