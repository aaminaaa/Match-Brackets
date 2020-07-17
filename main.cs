using System;
using System.Collections.Generic;

class main {
  public static void Main (string[] args) {
 Console.WriteLine("Enter bracket combination:");

// Create a string variable and get user input from the keyboard and store it in the variable
string bracket = Console.ReadLine();
IsValid(bracket);
  }

  public static void IsValid(string s) {

        if(s.Length == 0)
            Console.WriteLine("Matched.");
        Stack<char> stacky =
            new Stack<char>();
        Dictionary<char, char> dict =
            new Dictionary<char,char>();
        string parens = "(){}[]";
        for (int i = 0; i < parens.Length - 1; i+=2)
            dict.Add(parens[i+1],parens[i]);

        foreach (char c in s){

            if (dict.ContainsKey(c)){
                // print($"at {c}, expecting {dict[c]}\n");
                if (stacky.Count == 0)
                    Console.WriteLine("Not Matched.");
                char top = stacky.Pop();
                if (top != dict[c])
                    Console.WriteLine("Not Matched.");
            }
            else{
                stacky.Push(c);
                Console.WriteLine("Matched.");
            }

        }



    }
}