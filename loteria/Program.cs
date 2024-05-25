    using System;
    using System.Collections.Generic;

    Random random = new Random();
    List<int> numerosSorteados = new List<int>();

    // Entrada dos números escolhidos pelo usuário
    Console.WriteLine("Digite 6 números de 1 a 60:");
    List<int> numerosEscolhidos = new List<int>();
    for (int i = 0; i < 6; i++)
    {
        Console.Write($"Digite o {i + 1}º número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        numerosEscolhidos.Add(numero);
    }

    int tentativas = 0;

    // Sorteio até que os números escolhidos pelo usuário sejam sorteados
    while (!NumerosIguais(numerosSorteados, numerosEscolhidos))
    {
        numerosSorteados.Clear(); // Limpa a lista de números sorteados

        // Sorteia 6 números aleatórios
        for (int i = 0; i < 6; i++)
        {
            int numeroSorteado;
            do
            {
                numeroSorteado = random.Next(1, 60);
            } while (numerosSorteados.Contains(numeroSorteado)); // Garante que o número sorteado não foi sorteado anteriormente

            numerosSorteados.Add(numeroSorteado);
        }

        tentativas++;

        Console.WriteLine($"Número de tentativas: {tentativas}");
    }

    // Exibindo os números sorteados e o número de tentativas
    Console.WriteLine("\nNúmeros sorteados:");
    foreach (int num in numerosSorteados)
    {
        Console.WriteLine(num);
    }


    // Função para verificar se duas listas de números são iguais
    static bool NumerosIguais(List<int> lista1, List<int> lista2)
    {
        if (lista1.Count != lista2.Count)
            return false;

        for (int i = 0; i < lista1.Count; i++)
        {
            if (lista1[i] != lista2[i])
                return false;
        }

        return true;
    }
