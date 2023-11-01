using System; 

class Program {

    public static void Main(string[] args) { 
        int tempo = int.Parse(Console.ReadLine());
        int resp1 = tempo/3600;
        int resp2 = (tempo-(resp1*3600))/60;
        int resp3 = tempo-(resp1*3600)-(resp2*60);
        Console.WriteLine($"{resp1}:{resp2}:{resp3}");
    }
}