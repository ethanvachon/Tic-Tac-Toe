using System;

namespace Tic_Tac_Toe
{
  public class GameLogic
  {
    public string info = @"
         1 | 2 | 3
        ---|---|---
         4 | 5 | 6
        ---|---|---
         7 | 8 | 9
    ";
    public string drawBoard(string[] arr)
    {
      return $@"
       {arr[0]} | {arr[1]} | {arr[2]}
      ---|---|---
       {arr[3]} | {arr[4]} | {arr[5]}
      ---|---|---
       {arr[6]} | {arr[7]} | {arr[8]}
      ";
    }

    public string addO(string[] arr, int index)
    {
      arr[index] = "O";
      return drawBoard(arr);
    }

    public string addX(string[] arr, int index)
    {
      arr[index] = "X";
      return drawBoard(arr);
    }

    internal void OTurn(string[] arr)
    {
      Console.Clear();
      Console.WriteLine(drawBoard(arr));
      Console.WriteLine("player 1 turn");
      ConsoleKeyInfo key = Console.ReadKey();
      if (key.Key == ConsoleKey.D1)
      {
        addO(arr, 0);
      }
      else if (key.Key == ConsoleKey.D2)
      {
        addO(arr, 1);
      }
      else if (key.Key == ConsoleKey.D3)
      {
        addO(arr, 2);
      }
      else if (key.Key == ConsoleKey.D4)
      {
        addO(arr, 3);
      }
      else if (key.Key == ConsoleKey.D5)
      {
        addO(arr, 4);
      }
      else if (key.Key == ConsoleKey.D6)
      {
        addO(arr, 5);
      }
      else if (key.Key == ConsoleKey.D7)
      {
        addO(arr, 6);
      }
      else if (key.Key == ConsoleKey.D8)
      {
        addO(arr, 7);
      }
      else if (key.Key == ConsoleKey.D9)
      {
        addO(arr, 8);
      }
    }

    internal void XTurn(string[] arr)
    {
      Console.Clear();
      Console.WriteLine(drawBoard(arr));
      Console.WriteLine("player 2 turn");
      ConsoleKeyInfo key = Console.ReadKey();
      if (key.Key == ConsoleKey.D1)
      {
        addX(arr, 0);
      }
      else if (key.Key == ConsoleKey.D2)
      {
        addX(arr, 1);
      }
      else if (key.Key == ConsoleKey.D3)
      {
        addX(arr, 2);
      }
      else if (key.Key == ConsoleKey.D4)
      {
        addX(arr, 3);
      }
      else if (key.Key == ConsoleKey.D5)
      {
        addX(arr, 4);
      }
      else if (key.Key == ConsoleKey.D6)
      {
        addX(arr, 5);
      }
      else if (key.Key == ConsoleKey.D7)
      {
        addX(arr, 6);
      }
      else if (key.Key == ConsoleKey.D8)
      {
        addX(arr, 7);
      }
      else if (key.Key == ConsoleKey.D9)
      {
        addX(arr, 8);
      }
    }

    internal string WinCheck(string[] board)
    {
      // 012, 345, 678
      // 136, 147, 258
      // 048, 246
      if (board[0] == "O" && board[1] == "O" && board[2] == "O")
      {
        return "O";
      }
      return "N";
    }
  }
}