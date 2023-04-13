using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine (InverterString("Marcelo"));
    }
    public static string InverterString (string s) {
      string r = string.Empty;
        for(int i= s.Length -1; i >= 0; i--) {
          r += s[i];
        }
        return r;
    }
}