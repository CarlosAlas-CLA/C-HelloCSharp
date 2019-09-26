using System;
using System.IO;

namespace ReadTextFile_WriteToTextFile



{
    class Program
    {
        static void Main(string[] args)
        {
             string filePath = @"C:\Desktop\New Text Document (2).txt";//Text file path 
            //Variables
            string userInput = " ";
            string exit = "exit";
            //Read all text 
            string fileOutput = File.ReadAllText(filePath);
            Console.WriteLine(fileOutput);
            //User input
            Console.WriteLine("Enter text to write to text file");

            //Read all text until user enters exit.
            while (userInput != exit)
                {
                userInput= Console.ReadLine();
                File.AppendAllText(filePath,userInput+"\n");
                }
        }
    }
}
