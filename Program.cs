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
          break;
        }
        Console.Clear();
        Console.WriteLine("select the number that corresponds with the tile you want to select");
        Console.WriteLine(game.info);
        Thread.Sleep(5000);

        while (running)
        {
          game.OTurn(board);
          if (game.WinCheck(board) == "O")
          {
            Console.Clear();
            Console.WriteLine(game.drawBoard(board));
            Console.WriteLine("Player 1 wins");
            running = false;
            break;
          }
          if (game.WinCheck(board) == "X")
          {
            Console.Clear();
            Console.WriteLine(game.drawBoard(board));
            Console.WriteLine("Player 2 wins");
            running = false;
            break;
          }
          game.XTurn(board);
          if (game.WinCheck(board) == "O")
          {
            Console.Clear();
            Console.WriteLine(game.drawBoard(board));
            Console.WriteLine("Player 1 wins");
            running = false;
            break;
          }
          if (game.WinCheck(board) == "X")
          {
            Console.Clear();
            Console.WriteLine(game.drawBoard(board));
            Console.WriteLine("Player 2 wins");
            running = false;
            break;
          }
        }
      }
    }
  }
}
