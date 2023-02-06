switch (i)
{
    case 1:
    {
        // Напишите программу, которая сгенерирует случайное число в интервале [10, 99], выведет наибольшую цифру из данного числа
        Random random = new Random();
        int min = 10;
        int max = 99;
        int number = random.Next(min, max + 1);
        int a = number % 10;
        int b = number / 10;
        if (a > b) Console.WriteLine($"В числе {number} наибольшей цифрой является {a}");
        else Console.WriteLine($"В числе {number} наибольшей цифрой является {b}");
        break;
    }
    case 2:
    {
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        Random random = new Random();
        int min = 100;
        int max = 999;
        int number = random.Next(min, max + 1);
        int a = number % 10;
        int b = number / 10;
        if (a > b) Console.WriteLine($"В числе {number} наибольшей цифрой является {a}");
        else Console.WriteLine($"В числе {number} наибольшей цифрой является {b}");
        break;
    }


    default:
}
