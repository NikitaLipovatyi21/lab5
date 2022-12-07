using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5._3_oop
{
   public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версiї Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереженняя документа доступне у версiї Pro");
        }
    }
}
