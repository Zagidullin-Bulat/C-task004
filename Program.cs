// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int Max = num1;

if (num1 < num2){Max = num2;
}

if (Max < num3){Max = num3;
}

else
{
    Console.WriteLine ("Ошибка, были схожи числа");
}

Console.WriteLine ("Максимальное число:");
Console.WriteLine (Max);