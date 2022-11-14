//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Решение:
/*Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine($"Максимальное число {num1}");
}
else {Console.WriteLine($"Максимальное число {num2}");
};
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Решение:
/*Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2){
    max = num2;
};
if (max < num3){
    max = num3;
};
Console.WriteLine($"Максимальное число {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Решение:
/*Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int result = num%2;
if (result == 0){
   Console.WriteLine("Число является четным."); 
}
else{
    Console.WriteLine("Число является нечетным.");
};
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Решение:
Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
int currant = 2;
if(num < 0){
    Console.WriteLine($"Нет четных чисел в диапазоне от 1 до {num}");
}
else while (currant <= num){
   Console.WriteLine(currant + " "); 
   currant = currant + 2;
};