Console.Clear();



Ex41();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

void Ex41()
{
    int sizeM = 5;
    int[] numbers = new int[sizeM];

    FillArray(numbers);

    void FillArray(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1}-е число:");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    int GetQuantityPositiveNum(int[] num)
    {
        int quantity = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0)
            {
                quantity++;
            }
        }
        return quantity;
    }

    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Количество чисел больше 0: " + GetQuantityPositiveNum(numbers) + "\n");
}



Ex43();
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Ex43()
{
    Console.WriteLine("Введите k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1*x + b1;

    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y1})");
}
