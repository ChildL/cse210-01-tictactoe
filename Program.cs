// Tic Tac Toe game
// Lisa Child, CSE 210, 17 Jan 2022

using System;
using System.Collections.Generic;
namespace cse210_01_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> squares = AddNumbers();

            // while statement to run game until a win or tie
            
            bool win = false;
            bool tie = false;
            while (win != true)
            // Calling Board Game Player1
            {
                PrintGame(squares);

                Console.Write("Player 1 choose a square(1-9): ");
                string Player1 = Console.ReadLine();
           
                int Index = int.Parse(Player1);
                squares[Index- 1] = "X";
                PrintGame(squares);
                // check for win or tie
                win = CheckForWin(squares);
                tie = Tie(squares);

                if (win != false || tie != false)
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
        //Add 1-9 to squares
        static List<string> AddNumbers()
        {
            List<string> squares = new List<string>();
            for (int i =1; i<=9; i++)
            {
                squares.Add(i.ToString());
            }
            return squares;
        }
    
        static void PrintGame(List<string> squares)
        // Print Game Board function
        
        {
            Console.WriteLine();
            Console.WriteLine($"  {squares[0]}  | {squares[1]} |  {squares[2]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[3]}  | {squares[4]} |  {squares[5]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[6]}  | {squares[7]} |  {squares[8]}   ");
            Console.WriteLine();
        
        }
        // Check for Win
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
        // bool for a Tie, this code was not mine      
        static bool Tie(List<string> squares)
        {
            bool foundDigit = false;
            
            foreach (string value in squares)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }
            if (foundDigit == false) 
            {
            Console.WriteLine ("Tie, Thanks for playing");
            }
            return !foundDigit;     
        }
    }
}   

