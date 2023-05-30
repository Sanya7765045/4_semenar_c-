// Очистка консоли перед выполнением программы
Console.Clear();

// Функция Exponentiation принимает два целочисленных аргумента и возвращает результат возведения первого аргумента в степень второго аргумента
double Exponentiation(int baseNumber, int exponent)
{
    int result = 1;
    for ( int i = 0; i < exponent; i++ )
    {
        // Умножаем текущее значение result на baseNumber и присваиваем результат переменной result
        result = result * baseNumber;
    }
    return result;
}

// Запрашиваем у пользователя ввод целочисленного числа A
Console.Write("Введите число A: ");

// Считываем введенную строку с консоли и преобразуем ее в число типа int, затем присваиваем полученное значение переменной A
int A = int.Parse(Console.ReadLine());

// Запрашиваем у пользователя ввод целочисленного числа B
Console.Write("Введите число B: ");

int B = int.Parse(Console.ReadLine());
// Считываем введенную строку с консоли и преобразуем ее в число типа int, затем присваиваем полученное значение переменнойB = int.Parse(Console.ReadLine());

// Выводим в консоль результат возведения числа A в степень B, используя функцию Exponentiation
Console.Write(Exponentiation(A,B));