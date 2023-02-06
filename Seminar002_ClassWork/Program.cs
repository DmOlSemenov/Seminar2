Console.WriteLine("Введите номер задачи  ");
int i = int.Parse(Console.ReadLine ());
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
        // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
        Random random = new Random();
        int min = 100;
        int max = 999;
        int number = random.Next(min, max + 1);
        int a = number / 100 * 10;
        int b = number % 10;
        int c = a + b;
        Console.WriteLine($"Убрав из числа {number} вторую цифру получим {c}");
        break;

    }
    case 3:
    {
        // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
        Console.WriteLine("Введите первое число  ");
        int number1 = int.Parse(Console.ReadLine ());
        Console.WriteLine("Введите второе число  ");
        int number2 = int.Parse(Console.ReadLine ());
        double a = number1 / number2;
        if (a / 1 == 0)
        {
            Console.WriteLine($"Кратно, результат {a}");
        }
        else
        {
            double b = (number1 - number2 * a);
            Console.WriteLine($"Не кратно, остаток {b}");
        }        
        break;
    }
    case 4:
    {
        // 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
        Console.WriteLine("Введите число  ");
        int number1 = int.Parse(Console.ReadLine ());
        int number2 = 7;
        int number3 = 23;
        int a = number1 % number2;
        int b = number1 % number3;
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Кратно");
            }
            else
            {
                Console.WriteLine("Не кратно");
            }
        }
        else
        {
            Console.WriteLine("Не кратно, попробуйте снова");
        }

        break;
    }
    case 5:
    {
        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        Random random = new Random();
        int min = 100;
        int max = 999;
        int number = random.Next(min, max + 1);
        int a = number % 100 / 10;
        Console.WriteLine($"В числе {number} второй цифрой является {a}");
        break;
        
    } 

}
