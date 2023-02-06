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
        int.TryParse(Console.ReadLine(), out int num);
        if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Число {num} кратно и 7 и 23");           
        else Console.WriteLine("Не кратно, попробуйте снова");
        break;
    }
    case 5:
    {
        //16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
        Console.WriteLine("Введите первое число  ");
        int.TryParse(Console.ReadLine (), out int a);
        Console.WriteLine("Введите второе число  ");
        int.TryParse(Console.ReadLine (), out int b);
        if (a == Math.Pow(b, 2))
        {
            Console.WriteLine($"Число {a} является квадратом числа {b}");
            if (b == Math.Pow(a, 2))
            {
                Console.WriteLine($"Число {b} является квадратом числа {a}");
            }
        }    
        else
        {
            if (b == Math.Pow(a, 2))
            {
                Console.WriteLine($"Число {b} является квадратом числа {a}");
            }
            else
            {
                Console.WriteLine($"Числа {b} и {a} не являетюся квадратом друг друга");
            }
            
        }
        break;
    }
    case 6:
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
    case 7:
    {
        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        string[] days = new String[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
        Console.WriteLine("Введите номер дня недели ");
        int day = int.Parse(Console.ReadLine());
        if ((day == 6) || (day == 7))
        {
            Console.Write(days[day - 1]);
            Console.Write(" является выходным днем");
        }
        else
        {
            Console.Write(days[day - 1]);
            Console.Write(" не является выходным днем");
        }
        break;
    }

}
