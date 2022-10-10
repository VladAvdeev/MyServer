using System;
using System.Threading.Tasks;

namespace MineServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Parallel.For(0, 100, x =>
                {
                    if (x % 2 == 0)
                        MyServer.AddToCount(2);
                    else
                        Console.WriteLine(MyServer.GetCount());
                });
            Console.WriteLine(MyServer.GetCount());
            Console.ReadLine();
        }
    }
}
