// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int result = Factorial(n);
        Console.WriteLine("Произведение чисел от 1 до N: " + result);
    }

    static int Factorial(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
