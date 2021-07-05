using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

    double[] celsius = new double[7];
    double[] farenheit = new double[7]; 

    for(int pos=0; pos < celsius.Length; pos++)
    {
        Console.WriteLine("Enter temperature in celsius");
        celsius[pos]=Convert.ToDouble(Console.ReadLine());
        farenheit[pos] = (celsius[pos] * 9/5) + 32;
    }
    Console.WriteLine("temperature in farenheit");
    Array.Reverse(farenheit);
    for(int pos=0; pos < celsius.Length; pos++)
    {
        Console.WriteLine(farenheit[pos]);
    }
    double sum = farenheit.Sum();
    double average = sum/7;
    Console.WriteLine("Average weekly temperature is " + (average) + " degree farenheit" );
  

  
  }
}
