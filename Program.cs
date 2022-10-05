Console.Clear();


// Ex41();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

    Console.WriteLine("Количество чисел больше 0: " + GetQuantityPositiveNum(numbers));
}





