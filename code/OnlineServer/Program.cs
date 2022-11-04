using Proline.ServerAccess.IO.Actions;
using System;

namespace OnlineEngine
{
    public class Program
    {
        private static ConsoleWriteAction _x;
        private static ReadFileAction _y;
        private static WriteFileAction _g;
        private static ConsoleWriteLineAction _a;

        public static void Main(string[] args)
        { 
            try
            {
                _x = new ConsoleWriteAction();
                _x.SubscribeEvent();
                _a = new ConsoleWriteLineAction();
                _a.SubscribeEvent();
                _y = new ReadFileAction();
                _y.SubscribeEvent();
                _g = new WriteFileAction();
                _g.SubscribeEvent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
