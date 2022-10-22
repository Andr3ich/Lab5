using System;


namespace Lab5_3
{
    class Program
    {
        static void Main()
        {
            DokumentWorker worker = new DokumentWorker();
            Console.WriteLine("Активацiя базового функцiоналу програми.");
            Console.WriteLine("\n");
            Console.WriteLine("Для доступу до версiй про або експерт - необхiднi ключi доступу:");
            Console.WriteLine("введiть ключ доступу для версії про або експерт. \nКод має включати чотири цифри вiд 0 до 9. \n");
            string product_key = Console.ReadLine();
            int key = Convert.ToInt32(product_key);

            switch(key)
            {
                case 1234:
                    DokumentWorker pro = new ProDocumentWorker();
                    Console.WriteLine("Вiтаємо з успiшним придбанням про версiї");
                    break;
                case 4321:
                    ProDocumentWorker expert = new ExpertDocumentWorker();
                    Console.WriteLine("Вiтаємо з успiшним придбанням експерт версiї");
                    break;
            }
            Console.ReadKey();
        }
    }
}