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

    internal void OTurn()
    {
      throw new NotImplementedException();
    }

    internal void XTurn()
    {
      throw new NotImplementedException();
    }

    internal void WinCheck()
    {
      throw new NotImplementedException();
    }
  }
}