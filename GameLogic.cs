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
      while (true)
      {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.D1 && arr[0] != "X" && arr[0] != "O")
        {
          addO(arr, 0);
          break;
        }
        else if (key.Key == ConsoleKey.D2 && arr[1] != "X" && arr[1] != "O")
        {
          addO(arr, 1);
          break;
        }
        else if (key.Key == ConsoleKey.D3 && arr[2] != "X" && arr[2] != "O")
        {
          addO(arr, 2);
          break;
        }
        else if (key.Key == ConsoleKey.D4 && arr[3] != "X" && arr[0] != "3")
        {
          addO(arr, 3);
          break;
        }
        else if (key.Key == ConsoleKey.D5 && arr[4] != "X" && arr[0] != "4")
        {
          addO(arr, 4);
          break;
        }
        else if (key.Key == ConsoleKey.D6 && arr[5] != "X" && arr[5] != "O")
        {
          addO(arr, 5);
          break;
        }
        else if (key.Key == ConsoleKey.D7 && arr[6] != "X" && arr[6] != "O")
        {
          addO(arr, 6);
          break;
        }
        else if (key.Key == ConsoleKey.D8 && arr[7] != "X" && arr[7] != "O")
        {
          addO(arr, 7);
          break;
        }
        else if (key.Key == ConsoleKey.D9 && arr[8] != "X" && arr[8] != "O")
        {
          addO(arr, 8);
          break;
        }
      }
    }

    internal void XTurn(string[] arr)
    {
      Console.Clear();
      Console.WriteLine(drawBoard(arr));
      Console.WriteLine("player 2 turn");
      while (true)
      {

        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.D1 && arr[0] != "O" && arr[0] != "X")
        {
          addX(arr, 0);
          break;
        }
        else if (key.Key == ConsoleKey.D2 && arr[1] != "O" && arr[1] != "X")
        {
          addX(arr, 1);
          break;
        }
        else if (key.Key == ConsoleKey.D3 && arr[2] != "O" && arr[2] != "X")
        {
          addX(arr, 2);
          break;
        }
        else if (key.Key == ConsoleKey.D4 && arr[3] != "O" && arr[3] != "X")
        {
          addX(arr, 3);
          break;
        }
        else if (key.Key == ConsoleKey.D5 && arr[4] != "O" && arr[4] != "X")
        {
          addX(arr, 4);
          break;
        }
        else if (key.Key == ConsoleKey.D6 && arr[5] != "O" && arr[5] != "X")
        {
          addX(arr, 5);
          break;
        }
        else if (key.Key == ConsoleKey.D7 && arr[6] != "O" && arr[6] != "X")
        {
          addX(arr, 6);
          break;
        }
        else if (key.Key == ConsoleKey.D8 && arr[7] != "O" && arr[7] != "X")
        {
          addX(arr, 7);
          break;
        }
        else if (key.Key == ConsoleKey.D9 && arr[8] != "O" && arr[8] != "X")
        {
          addX(arr, 8);
          break;
        }
      }
    }

    internal string WinCheck(string[] board)
    {

      // 012, 345, 678

      if (board[0] == "O" && board[1] == "O" && board[2] == "O")
      {
        return "O";
      }
      if (board[0] == "X" && board[1] == "X" && board[2] == "X")
      {
        return "X";
      }

      if (board[3] == "O" && board[4] == "O" && board[5] == "O")
      {
        return "O";
      }
      if (board[3] == "X" && board[4] == "X" && board[5] == "X")
      {
        return "X";
      }

      if (board[6] == "O" && board[7] == "O" && board[8] == "O")
      {
        return "O";
      }

      if (board[6] == "X" && board[7] == "X" && board[8] == "X")
      {
        return "X";
      }

      // 136, 147, 258

      if (board[1] == "O" && board[3] == "O" && board[6] == "O")
      {
        return "O";
      }
      if (board[1] == "X" && board[3] == "X" && board[6] == "X")
      {
        return "X";
      }

      if (board[1] == "O" && board[4] == "O" && board[7] == "O")
      {
        return "O";
      }
      if (board[1] == "X" && board[4] == "X" && board[7] == "X")
      {
        return "X";
      }

      if (board[2] == "O" && board[5] == "O" && board[8] == "O")
      {
        return "O";
      }

      if (board[2] == "X" && board[5] == "X" && board[8] == "X")
      {
        return "X";
      }

      // 048, 246

      if (board[0] == "O" && board[4] == "O" && board[8] == "O")
      {
        return "O";
      }
      if (board[0] == "X" && board[4] == "X" && board[8] == "X")
      {
        return "X";
      }

      if (board[2] == "O" && board[4] == "O" && board[6] == "O")
      {
        return "O";
      }

      if (board[2] == "X" && board[4] == "X" && board[6] == "X")
      {
        return "X";
      }

      return "N";
    }
  }
}