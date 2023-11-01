using System; 

class Program {

    public static void Main(string[] args) { 
        string linha0 = " ";
        do{
            linha0 = Console.ReadLine();
            if(linha0 == "0 0 0 0"){
                break;
            }
            string [] linha = linha0.Split(' ');
            int h1 = int.Parse(linha[0]);
            int m1 = int.Parse(linha[1]);
            int h2 = int.Parse(linha[2]);
            int m2 = int.Parse(linha[3]);
            if (h1 > h2 || (h1 >= h2 && m1 >= m2))
                h1 = h1 - 24;

            int resp = (h2*60+m2)-(h1*60+m1);
            /*int hora0 = (h1*60+m1);
            int hora1 = (h2*60+m2);
            if (hora0 > hora1)
                hora1 += 1440;

            int resp = hora1-hora0;*/

            Console.WriteLine(resp);
        }while(linha0 != "0 0 0 0");
    }
}