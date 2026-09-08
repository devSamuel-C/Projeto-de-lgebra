using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a ordem da matriz (n para uma matriz n x n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] matriz = new double[n, n];

        Console.WriteLine("Digite os valores da matriz, linha por linha (separados por espaço):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Linha {i + 1}: ");
            string[] valores = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = double.Parse(valores[j]);
            }
        }

        double determinante = CalcularDeterminante(matriz, n);

        Console.WriteLine($"\nDeterminante = {determinante}");
    }

    // Calcula o determinante usando eliminação gaussiana (transforma em matriz triangular)
    static double CalcularDeterminante(double[,] matrizOriginal, int n)
    {
        double[,] m = (double[,])matrizOriginal.Clone();
        double determinante = 1;

        for (int i = 0; i < n; i++)
        {
            // Se o pivô for zero, tenta trocar com uma linha abaixo
            if (m[i, i] == 0)
            {
                int linhaTroca = -1;
                for (int k = i + 1; k < n; k++)
                {
                    if (m[k, i] != 0) { linhaTroca = k; break; }
                }

                if (linhaTroca == -1)
                    return 0; // matriz singular, determinante é zero

                for (int col = 0; col < n; col++)
                {
                    (m[i, col], m[linhaTroca, col]) = (m[linhaTroca, col], m[i, col]);
                }
                determinante *= -1; // cada troca de linha inverte o sinal
            }

            // Zera os elementos abaixo do pivô
            for (int k = i + 1; k < n; k++)
            {
                double fator = m[k, i] / m[i, i];
                for (int col = i; col < n; col++)
                {
                    m[k, col] -= fator * m[i, col];
                }
            }

            determinante *= m[i, i];
        }

        return determinante;
    }
}
