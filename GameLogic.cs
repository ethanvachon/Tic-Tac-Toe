namespace Tic_Tac_Toe
{
  public class GameLogic
  {
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
  }
}