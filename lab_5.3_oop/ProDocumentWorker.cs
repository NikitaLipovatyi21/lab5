using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_5._3_oop
{
    class ProDocumentWorker: DocumentWorker
    {
        public string pro_key;
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдредаговано");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї Експерт");
        }

        public void CheckPro()
        {
            if (pro_key is "asdfg")
            {
                ProDocumentWorker pro = new ProDocumentWorker();
                string writeText;
                Console.WriteLine("Введiть текст, який ви хочете додати до файлу");
                writeText = Console.ReadLine();
                string appendText = writeText + Environment.NewLine;
                File.AppendAllText(@"C:\\KNUTE2\\OOP\\lab_5_oop.txt", appendText);
                string readText = File.ReadAllText(@"C:\\KNUTE2\\OOP\\lab_5_oop.txt");
                Console.WriteLine('\n' + readText );
                pro.EditDocument();
                pro.SaveDocument();

            }
            else
            {
                Console.WriteLine("Ключ введено помилково.");
                DocumentWorker worker = new DocumentWorker();
                worker.EditDocument();
                worker.SaveDocument();
            }
        }

    }
}
