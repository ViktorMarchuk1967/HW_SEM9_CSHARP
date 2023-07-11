/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int start, int end) //1,5
{
    if (start > end) return;

    if (start == 1)
    {
        PrintNumbers(start + 1, end);
        Console.Write(start);//обратный вид строки 
    }
    else
    {
        PrintNumbers(start + 1, end); //обратный вид строки 
        Console.Write(start + ",");
    }
}

int num = InputNum("Введите целое число: ");
PrintNumbers(1, num);
*/







/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNumbers(int start, int end)
{
 
    if (start > end) return 0;
    return start + SumNumbers(start + 1, end);
 
}

int numStart = InputNum("Введите начальное целое число: ");
int numEnd = InputNum("Введите конечное целое число: ");
int sum = SumNumbers(numStart, numEnd);
//int sum = 0;
//if (numStart < numEnd) sum = SumNumbers(numStart, numEnd);
//else sum = SumNumbers( numEnd, numStart);
Console.Write(sum);
*/


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FunctionAckermann(int m, int n)
{

    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAckermann(m - 1, 1);
    else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));

}

int num1 = InputNum("Введите первое целое число: ");
int num2 = InputNum("Введите второе целое число: ");
int result = FunctionAckermann(num1, num2);

Console.Write(result);


