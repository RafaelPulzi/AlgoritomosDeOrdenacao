using System;
using System.Collections.Generic;

class BubbleSortInteractive
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Clear(); // Limpa o terminal

            Console.WriteLine("Digite os números que deseja adicionar. Para finalizar, digite 'encerrar'.\n");

            Console.Write("\nArray atual: ");
            PrintArray(numbers.ToArray());


            Console.Write("\nAdicione mais um número: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "encerrar") // Linha para encerrar o programa 
                break;

            if (int.TryParse(input, out int number)) // vai colocando os números digitados dentro do array
            {
                numbers.Add(number);
                int[] arr = numbers.ToArray();
                
            }
            else //Qualquer coisa que não for uma das especificações acima será identificado como um erro na digitação 
            {
                Console.WriteLine("Entrada inválida. Digite um número válido ou 'encerrar' para finalizar.");
            }

        }

        int[] sortedArray = numbers.ToArray();
        BubbleSortAlgorithm(sortedArray);

        Console.Write("\nArray final ordenado: "); //Aqui já finalizando o programa ele dá print nos resultados que foram formulados pelo "BubbleSortAlgorithm()"
        PrintArray(sortedArray);
    }

    static void BubbleSortAlgorithm(int[] arr) 
    {
        int n = arr.Length; //Ordenação dos dados escritos, algoritmo usado: Booble sort
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

    static void PrintArray(int[] arr) // imprimi os elementos desse array na mesma linha
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
