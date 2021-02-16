using System;

public class ReverseString
{ 
  public static void Main()
  {
    string[] s = "to the moon and back".Split(' ');
    string temp = "";
    for (int i = s.Length - 1; i >= 0; i--) 
        temp += s[i] + " ";

    Console.Write("Reversed String: ");
    Console.Write(temp.Substring(0, temp.Length - 1));
  }
}