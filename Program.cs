/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 > num2){
    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
}
else if(num1 < num2){
    Console.WriteLine($"Второе число {num2} больше первого числа {num1}");
}
else{
    Console.WriteLine($"Числа равны!");
}

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третьe число");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(b > max){
    max = b;
}
if(c > max){
    max = c;
}
Console.WriteLine($"Максимальное число {max}");

