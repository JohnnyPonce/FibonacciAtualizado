using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool pertence = PertenceASequenciaFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceASequenciaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        if (numero == a || numero == b)
        {
            return true;
        }

        while (true)
        {
            int proximo = a + b;

            if (proximo == numero)
            {
                return true;
            }
            else if (proximo > numero)
            {
                return false;
            }

            a = b;
            b = proximo;
        }
    }
}

