﻿// Очистка консоли перед выполнением программы
Console.Clear();

// Функция sum принимает один целочисленный аргумент и возвращает сумму цифр этого числа
int sum ( int num )
{
    int result = 0;
    while ( num > 0 )
    {
        result += num % 10; // Добавляем к результату последнюю цифру числа
        num = num / 10; // Удаляем последнюю цифру числа из num
    }
    return result;
}

// Запрашиваем у пользователя ввод положительного целочисленного числа
Console.Write("Введите положительное целочисленное число: ");

// Считываем введенную строку с консоли и преобразуем ее в число типа int, затем присваиваем полученное значение переменной N
int N = int.Parse(Console.ReadLine());

// Выводим в консоль сумму цифр введенного пользователем числа, используя функцию sum
Console.Write(sum(N));