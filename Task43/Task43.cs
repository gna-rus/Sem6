/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
// y1 = 
Console.Clear();

int b1 = InputNum("b1"); // вводим коэфициенты
int k1 = InputNum("k1");
int b2 = InputNum("b2");
int k2 = InputNum("k2");
double CrossOY= FindCrossOY(b1, k1, b2, k2); // определяем точку пересечения по ОУ
double CrossOX = FindCrossOX(b1, k1, b2, k2, CrossOY); // определяем точку пересечения по ОХ
PrintAnswer(b1, k1, b2, k2, CrossOX, CrossOY); // выводим на экран ответ

int InputNum(string str1)
{
    while (true)
    {
        Console.WriteLine($"Введите число {str1}");
        bool flag = int.TryParse(Console.ReadLine(), out int num); //ввод значения с клавиатуры и проверка на int
        if (flag == true) return num;
        else Console.WriteLine("Ошибка ввода");
    }
}

double FindCrossOY(int b1, int k1, int b2, int k2) // поиск точки пересечения по ОУ (почему-то не получается в return записать сразу деление - выдает некорректные зныения)
{
    double znam = (b2*k1) - (b1*k2);
    double chisl = k1-k2; 
    double rez = znam / chisl;      
    return rez;
}

double FindCrossOX(int b1, int k1, int b2, int k2, double CrossOY) //поиск пересечения по ОХ
{
    return (CrossOY - b1)/(k1);
}

void PrintAnswer(int b1, int k1, int b2, int k2, double CrossOX, double CrossOY) // выведение ответа
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({CrossOX}; {CrossOY})");
}

