// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел, заданных с клавиатуры: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < number; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0 ) count += 1; 
}

Console.WriteLine($"Введено чисел больше 0: {count}");