using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());


        bool eFibo = verificarFibonacci(numero);

        if (eFibo)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }
 
    static bool verificarFibonacci(int num)
    { 
        int a = 0, b = 1;

      
        if (num == a || num == b)
        {
            return true;
        }

        int proximo = a + b;
        while (proximo <= num)
        {
            if (proximo == num)
            {
                return true; 
            }

         
            a = b;
            b = proximo;
            proximo = a + b;
        }

        return false; 
    }
}
