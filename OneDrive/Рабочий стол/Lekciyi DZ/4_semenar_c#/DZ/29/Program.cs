// Эта функция генерирует массив из 8 случайных чисел в диапазоне от 0 до 100 включительно
int[] ArrayRand(){
    int[] digit = new int[8];
    for (int i = 0; i < 8; i++)
    {
        digit[i] = new Random().Next(0, 101);
        //Console.Write($"{coins[i]} ");    
    }
    return digit;
}

// Эта функция выводит на консоль элементы массива
void printArr(int []arr){
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]} ");    
    }
}

// Очистка консоли перед выполнением программы
Console.Clear();

// Генерация и вывод массива на консоль
int[] arrNum = ArrayRand();
Console.WriteLine();
printArr(arrNum);
Console.WriteLine();