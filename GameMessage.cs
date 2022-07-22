using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingSystem
{
    internal class GameMessage
    {
        public string PairStrategy { get; set; }

        public GameMessage()
        {

        }

        public bool SetReverse()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("the pair strategy need to reverse? Y/N");
            while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N)
            {
                Console.WriteLine("must be Y or N");
                keyInfo = Console.ReadKey();
                Console.WriteLine();
            }

            return keyInfo.Key.ToString() == "Y" ? true : false;
        }

        public void SetPairStrategy() 
        {
            Console.WriteLine("choose your pair strategy: H=habit D=distance.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (keyInfo.Key != ConsoleKey.H && keyInfo.Key != ConsoleKey.D)
            {
                Console.WriteLine("number must be H or D");
                keyInfo = Console.ReadKey();
            }

            PairStrategy = keyInfo.Key.ToString();
        }
    }
}
