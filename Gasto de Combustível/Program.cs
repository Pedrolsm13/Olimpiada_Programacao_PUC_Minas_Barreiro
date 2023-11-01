using System; 

class Program {

    public static void Main(string[] args) { 
        double horas = 0, velocidade = 0;
        horas = double.Parse(Console.ReadLine());
        velocidade = double.Parse(Console.ReadLine());
        double resp = (horas * velocidade)/12;
        Console.WriteLine($"{resp:F3}");
    }
}