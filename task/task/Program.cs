using System;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFile<int> print = new PrintFile<int>();
            Excel ex = new Excel("isci adlari", 30, 100);
            ex.Print();
            print.Print();
            Console.WriteLine("-------------------");
            Word wo = new Word("test.txt",100);
            wo.Print();
            print.Print();
            Console.WriteLine("-----------------------");
            Pdf pd = new Pdf("imtahan suallari.pdf",95);
            pd.Print();
            print.Print();
        }
    }
}
