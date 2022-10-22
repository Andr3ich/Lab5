using System;

namespace Lab5_3
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в новому форматi");
        }
    }
}