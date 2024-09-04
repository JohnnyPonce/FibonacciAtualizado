using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um n�mero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool pertence = PertenceASequenciaFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O n�mero {numero} pertence � sequ�ncia de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O n�mero {numero} n�o pertence � sequ�ncia de Fibonacci.");
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

