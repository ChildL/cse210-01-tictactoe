using System;
using System.Collections.Generic;
namespace cse210_01_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>squares = new List<string>();
 
            squares.Add("1");
            squares.Add("2");
            squares.Add("3");
            squares.Add("4");
            squares.Add("5");
            squares.Add("6");
            squares.Add("7");
            squares.Add("8");
            squares.Add("9");
            // while statement to run game until a win or tie
            bool win = false;
            while (win != true)
            // Calling Board Game Player1
            {
                PrintGame(squares);

                Console.Write("Player 1 choose a square(1-9): ");
                string Player1 = Console.ReadLine();
           
                int Index = int.Parse(Player1);
                squares[Index- 1] = "X";
                PrintGame(squares);
                // check for win
                win = CheckForWin(squares);
                
                if (win != false)
                {
                    break;
                }
        
            //  Input Player2 Calling Board Game after Player2 plays

                Console.Write("Player 2 choose a square(1-9): ");
                string Player2 = Console.ReadLine();
            
                int Index2 = int.Parse(Player2);
                squares[Index2 - 1] = "O";
                PrintGame(squares);
                // check for win
                win = CheckForWin(squares);

                if (win != false)
                {
                    break;
                }
            }
        }
        
        static void PrintGame(List<string> squares)

        
        {
            Console.WriteLine();
            Console.WriteLine($"  {squares[0]}  | {squares[1]} |  {squares[2]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[3]}  | {squares[4]} |  {squares[5]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[6]}  | {squares[7]} |  {squares[8]}   ");
            Console.WriteLine();
        
        }
        
        static bool CheckForWin(List<string> squares)
        {
            if ((squares[0]== "X" && squares[1]== "X" && squares [2] == "X")||
                (squares[3]== "X" && squares[4]== "X" && squares [5] == "X")||
                (squares[6]== "X" && squares[7]== "X" && squares [8] == "X")||
                (squares[0]== "X" && squares[3]== "X" && squares [6] == "X")||
                (squares[1]== "X" && squares[4]== "X" && squares [7] == "X")||
                (squares[2]== "X" && squares[5]== "X" && squares [8] == "X")||
                (squares[0]== "X" && squares[4]== "X" && squares [8] == "X")||
                (squares[2]== "X" && squares[4]== "X" && squares [6] == "X"))

            {
                
                Console.WriteLine("Player 1 wins.");
                return true;
            } 
            else if ((squares[0]== "O" && squares[1]== "O" && squares [2] == "O")||
                (squares[3]== "O" && squares[4]== "O" && squares [5] == "O")||
                (squares[6]== "O" && squares[7]== "O" && squares [8] == "O")||
                (squares[0]== "O" && squares[3]== "O" && squares [6] == "O")||
                (squares[1]== "O" && squares[4]== "O" && squares [7] == "O")||
                (squares[2]== "O" && squares[5]== "O" && squares [8] == "O")||
                (squares[0]== "O" && squares[4]== "O" && squares [8] == "O")||
                (squares[2]== "O" && squares[4]== "O" && squares [6] == "O"))

            {
                Console.WriteLine("Player 2 wins.");
                return true;
            }    
            else
                
            {
            
                return false;
            }
        }       
        
    }
}   
