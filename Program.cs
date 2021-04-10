using System;
using System.Threading;

namespace Tic_Tac_Toe
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      GameLogic game = new GameLogic();
      string[] board = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
      bool running = true;
      while (running)
      {
        Console.WriteLine(@"
  _______ _        _______           _______         
 |__   __(_)      |__   __|         |__   __|        
    | |   _  ___     | | __ _  ___     | | ___   ___ 
    | |  | |/ __|    | |/ _` |/ __|    | |/ _ \ / _ \
    | |  | | (__     | | (_| | (__     | | (_) |  __/
    |_|  |_|\___|    |_|\__,_|\___|    |_|\___/ \___|
            ");
        Console.WriteLine("press any key to start or esc to quit");
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
          running = false;
        }
        Console.Clear();
        Console.WriteLine("select the number that corresponds with the tile you want to select");
        Console.WriteLine(game.info);
        Thread.Sleep(1000);
      }
    }
  }
}
