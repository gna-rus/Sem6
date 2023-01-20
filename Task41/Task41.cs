/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int M = InputNum(); // задаем размер массива
int[] ArraySizeM = new int[M];
ArraySizeM = FillArray(ArraySizeM); // заполняем массив

int PlusNum = SearchPlusNum(ArraySizeM); // определяем количество чисел больше 0
int NegativNum = SearchNegativNum(ArraySizeM); // определяем количество чисел меньше 0

int[] ArrayPlusNum = new int[PlusNum]; // создем и заполняем новый массив состоящий только из положительных чисел
ArrayPlusNum = FillPlusNumArray(PlusNum, ArraySizeM);

int[] ArrayNegNum = new int[NegativNum]; // создем и заполняем новый массив состоящий только из отрицательных чисел
ArrayNegNum = FillPlusNegArray(NegativNum, ArraySizeM);

PrintPlusNumber(ArrayPlusNum); // вывод на экран положительных чисел и их количества
PrintPlusNumber(ArrayNegNum); // вывод на экран отрицательных чисел и их количества

int InputNum()
{
    while (true)
    {
        Console.WriteLine($"Введите число ");
        bool flag = int.TryParse(Console.ReadLine(), out int num); //ввод значения с клавиатуры и проверка на int
        if (flag == true)
        {
            return num;
        }
        else Console.WriteLine("Ошибка ввода");
    }
}

int[] FillArray(int[] array) // заполнение массива отрицательными и положительными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        while (true)
        {
            Console.WriteLine($"Введите {i} элемент массива: ");
            bool flag = int.TryParse(Console.ReadLine(), out array[i]); //ввод значения с клавиатуры и проверка на int
            if (flag == true) break;
            else Console.WriteLine("Ошибка ввода. Введите целое число!");
        }
    }
    return array;
}

int SearchPlusNum(int[] array) // //подсчет чисель больше нуля в изначальном массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int SearchNegativNum(int[] array) //подсчет чисель меньше нуля в изначальном массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count++;
    }
    return count;
}
 
int[] FillPlusNumArray(int Num, int[] array) // заполняем массив числами больше нуля
{
    int[] arr = new int[Num];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return arr;
}

int[] FillPlusNegArray(int Num, int[] array) // заполняем массив числами меньше нуля
{
    int[] arr = new int[Num];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return arr;
}

void PrintPlusNumber(int[] array) // метод вывода на консоль информации
{
    Console.Write($"{String.Join(", ", array)} -> {array.Length}");
    Console.WriteLine();
}
