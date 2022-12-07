using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_5._3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker document = new DocumentWorker();
            ProDocumentWorker pro = new ProDocumentWorker();
            ExpertDocumentWorker expert = new ExpertDocumentWorker();
            FileStream file = new FileStream("C:\\KNUTE2\\OOP\\lab_5_oop.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
            Console.WriteLine("Введiть ключ щоб змiнити файл");
            pro.pro_key = Console.ReadLine();
            pro.CheckPro();
            Console.WriteLine("Введiть ключ щоб зберегти файл в iншому форматi ");
            expert.expert_key = Console.ReadLine();
            expert.CheckExpert();
            Console.ReadKey();
            
        }
    }
}
