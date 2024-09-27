using System;
using MathLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для работы с матрицами 4x4.\n Чтобы узнать подробнее о командах - напишите --help");

            while (true)
            {
                Console.Write("Введите команду: ");
                string operation = Console.ReadLine().Trim().ToLower();

                if (operation == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                if (operation == "--help")
                {
                    Console.WriteLine("Доступные команды: add (сложение), subtract (вычитание), multiply (умножение), exit (выход).");
                    continue;
                }

                if (operation != "add" && operation != "subtract" && operation != "multiply" && "--help" != operation)
                {
                    Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                    continue;
                }

                Console.WriteLine("Введите первую матрицу (4 строки по 4 числа, разделённых пробелами):");
                int[,] matrix1 = ReadMatrixFromConsole();

                Console.WriteLine("Введите вторую матрицу (4 строки по 4 числа, разделённых пробелами):");
                int[,] matrix2 = ReadMatrixFromConsole();

                int[,] resultMatrix = null;

                switch (operation)
                {
                    case "add":
                        resultMatrix = MatrixOperations.AddMatrices(matrix1, matrix2);
                        break;
                    case "subtract":
                        resultMatrix = MatrixOperations.SubtractMatrices(matrix1, matrix2);
                        break;
                    case "multiply":
                        resultMatrix = MatrixOperations.MultiplyMatrices(matrix1, matrix2);
                        break;
                }

                Console.WriteLine("Результат:");
                PrintMatrix(resultMatrix);
            }
        }

        static int[,] ReadMatrixFromConsole()
        {
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.Write($"Строка {i + 1}: ");
                    string input = Console.ReadLine();
                    string[] numbers = input.Split(' ');

                    if (numbers.Length != 4)
                    {
                        Console.WriteLine("Ошибка: необходимо ввести ровно 4 числа. Попробуйте снова.");
                        continue;
                    }

                    bool isValid = true;
                    for (int j = 0; j < 4; j++)
                    {
                        if (int.TryParse(numbers[j], out int number))
                        {
                            matrix[i, j] = number;
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка: '{numbers[j]}' не является числом. Попробуйте снова.");
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        break;
                    }
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
