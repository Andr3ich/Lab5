using System;


namespace Lab5_3
{
    class DokumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна у версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версiї Про");
        }
    }
}