using System;
using System.IO;
using MathLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для работы с матрицами 4x4. \nЧтобы узнать подробнее о командах - напишите --help\n");
            while (true)
            {
                Console.WriteLine("Выберите способ работы: \n");
                Console.WriteLine("1 - Работа через консоль");
                Console.WriteLine("2 - Работа с файлами (входной и выходной)\n");

                string mode = Console.ReadLine();

                if (mode == "1")
                {
                    Console.WriteLine("Режим работы через консоль.");
                    RunConsoleMode();
                }
                else if (mode == "2")
                {
                    Console.WriteLine("Режим работы с файлами.");
                    RunFileMode();
                }
                else if (mode == "--help")
                {
                    Console.WriteLine("Доступные команды: add (сложение), subtract (вычитание), multiply (умножение), exit (выход).\n");
                    continue;
                }
                else if (mode == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: неверный режим.\n");
                }
            }
        }

        static void RunConsoleMode()
        {
            Console.WriteLine(" Чтобы узнать подробнее о командах - напишите --help");

            while (true)
            {
                Console.Write("Введите команду: ");
                string operation = Console.ReadLine().Trim().ToLower();

                if (operation == "exit")
                {
                    break;
                }

                if (operation == "--help")
                {
                    Console.WriteLine("Доступные команды: add (сложение), subtract (вычитание), multiply (умножение), exit (выход к выбору режима).");
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

                PerformOperation(operation, matrix1, matrix2);

            }
        }

        static void RunFileMode()
        {
            // Получаем путь до текущей папки
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Введите путь к входному файлу (он должен находиться в папке с программой {currentDirectory}):");
            string inputFile = Console.ReadLine();
            string inputFilePath = Path.Combine(currentDirectory, inputFile);
            Console.WriteLine(inputFilePath);

            Console.WriteLine("Введите путь к выходному файлу (он будет создан в папке с программой):");
            string outputFile = Console.ReadLine();

            Console.WriteLine("Введите операцию (add, subtract, multiply):");
            string operation = Console.ReadLine().Trim().ToLower();
            
            string outputFilePath = Path.Combine(currentDirectory, outputFile);

            try
            {
                int[,] matrix1, matrix2;
                ReadMatricesFromFile(inputFilePath, out matrix1, out matrix2);

                int[,] resultMatrix = PerformOperation(operation, matrix1, matrix2);

                WriteMatrixToFile(resultMatrix, outputFilePath);
                Console.WriteLine($"Результаты операции записаны в файл {outputFilePath}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка во время работы с файлами: {ex.Message}\n");
            }
        }



        static int[,] PerformOperation(string operation, int[,] matrix1, int[,] matrix2)
        {
            int[,] resultMatrix = null;

            try
            {
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
                    default:
                        Console.WriteLine("Неправильная операция.\n");
                        break;
                }

                if (resultMatrix == null)
                {
                    Console.WriteLine("Ошибка: результат операции равен null.\n");
                }
                else
                {
                    Console.WriteLine("Результат:");
                    PrintMatrix(resultMatrix);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка во время выполнения операции '{operation}': {ex.Message}\n");
            }

            return resultMatrix;
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

        static void ReadMatricesFromFile(string path, out int[,] matrix1, out int[,] matrix2)
        {
            string[] lines = File.ReadAllLines(path);
            if (lines.Length < 8)
            {
                Console.WriteLine("Файл должен содержать по крайней мере 8 строк (по 4 строки на каждую матрицу).");
            }

            matrix1 = new int[4, 4];
            matrix2 = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                string[] numbers = lines[i].Split(' ');
                for (int j = 0; j < 4; j++)
                {
                    matrix1[i, j] = int.Parse(numbers[j]);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string[] numbers = lines[i + 4].Split(' ');
                for (int j = 0; j < 4; j++)
                {
                    matrix2[i, j] = int.Parse(numbers[j]);
                }
            }
        }

        static void WriteMatrixToFile(int[,] matrix, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        writer.Write(matrix[i, j] + " ");
                    }
                    writer.WriteLine();
                }
            }
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
