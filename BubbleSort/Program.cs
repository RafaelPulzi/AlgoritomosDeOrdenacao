using System;
using System.Collections.Generic;

class BubbleSortInteractive
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int contador = 0;

        while (true)
        {
            Console.Clear(); // Limpa o terminal

            Console.WriteLine("Digite os números que deseja adicionar. Para finalizar, digite 'encerrar'.\n");

            if (contador >= 1) {
                Console.Write("\nArray atual: ");
                PrintArray(numbers.ToArray());
            }

            Console.Write("\nAdicione mais um número: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "encerrar")
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
                int[] arr = numbers.ToArray();

                if (contador == 0) {
                Console.Write("\nArray atual: \n");
                PrintArray(arr);
            }
                
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número válido ou 'encerrar' para finalizar.");
            }

            contador++;
        }

        int[] sortedArray = numbers.ToArray();
        BubbleSortAlgorithm(sortedArray);

        Console.Write("\nArray final ordenado: \n");
        PrintArray(sortedArray);
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Trocar os elementos
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
