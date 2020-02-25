using System;
using System.Collections.Generic;

public class Program
{
  
  public static void Main()
  {
    Console.WriteLine("Please, provide the string");
    string input = Console.ReadLine();
    char[] word = input.ToCharArray();
    int number = word.Length;
    char[] reverseWord = new char[number];
    
    int index = 0;
    for (int j=(word.Length-1); j>=0; j--)
    {
      reverseWord[j] = word[index];
      index++;
    }
    
    int status = 0;
    for (int i=0; i<word.Length; i++){
      if (word[i] == reverseWord[i])
      {
        status++;
      }
    }  
    if (status == word.Length)
    {
      Console.WriteLine("This is a palindrome");
    }
    else
    {
      Console.WriteLine("This is not a palindrome");
    }
    
  }
}