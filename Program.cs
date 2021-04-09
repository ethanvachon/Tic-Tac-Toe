using System;

namespace Tic_Tac_Toe
{
  class Program
  {
    static void Main(string[] args)
    {
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
        Console.WriteLine();
      }
    }
  }
}
