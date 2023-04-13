using System;

public class HelloWorld {
  public static void Main(string[] args) {
    Console.WriteLine(testarFibonacci(9));
  }
  public static bool testarFibonacci(int n) {
    if (n <= 1) return true;
    if (n < 0) return false;
    int a = 1,
    b = 1;
    int c = 0;
    for (int i = 0;; i++) {
      c = a + b;
      if (n == c) return true;
      if (c > n) return false;
      a = b;
      b = c;
    }
    return false;

  }

}