using System;

namespace Lab5_3
{
    class ProDocumentWorker : DokumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї Експерт");
        }
    }
}