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

            // foreach (string square in squares)
            // {
            //     Console.WriteLine(square);
            // }

          
            Console.WriteLine($"  {squares[1]}  | {squares[2]} |  {squares[3]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[4]}  | {squares[5]} |  {squares[6]}   ");
            Console.WriteLine($"_____|___|____");
            Console.WriteLine($"  {squares[7]}  | {squares[8]} |  {squares[9]}   ");
            Console.WriteLine($"_____|___|____");
        

            PrintGame(squares);
        
        }
 
        static void PrintGame(List<string> squares)
        
        {
            // code to change 0 to x or o
            Console.WriteLine(squares[0]);        
            Console.WriteLine (" Hello ");
        }
    }
}   

/* 

Console.Write("Player 1 choose a square: ");
string Player1 = Readline():

Console.Write("Player 2 choose a square: ");
string Player2 = ReadLine():

bool win
if (Player1 = 

/*
