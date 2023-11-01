using System; 

class Program {

    public static void Main(string[] args) { 
        string [] linha = Console.ReadLine().Split(" ");
        
        int h1 = int.Parse(linha[0]);
        int m1 = int.Parse(linha[1]);
        int h2 = int.Parse(linha[2]);
        int m2 = int.Parse(linha[3]);
        if (h1 > h2 || (h1 == h2 && m1 > m2))
            h1 = h1 - 24;

        int resp = (h2*60+m2)-(h1*60+m1);

        Console.WriteLine(resp);
    }
}