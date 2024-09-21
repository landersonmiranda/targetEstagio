using System;

class Program
{
    static void Main()
    {
        string input = "Java é legal, mas C# é também. A escolha é sua";
       
        int quantidade = ContarLetrasA(input);

        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {quantidade} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }

    static int ContarLetrasA(string str)
    {
        int contagem = 0;

        foreach (char letra in str)
        {
            if (letra == 'a' || letra == 'A')
            {
                contagem++;
            }
        }

        return contagem;
    }
}
