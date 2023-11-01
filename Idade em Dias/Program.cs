using System; 

class Program {

    public static void Main(string[] args) { 
        int tempo = int.Parse(Console.ReadLine());
        int resp1 = tempo/365;
        int resp2 = (tempo-(resp1*365))/30;
        int resp3 = tempo-(resp1*365)-(resp2*30);
        Console.WriteLine($"{resp1} ano(s)");
        Console.WriteLine($"{resp2} mes(es)");
        Console.WriteLine($"{resp3} dia(s)");
    }
}