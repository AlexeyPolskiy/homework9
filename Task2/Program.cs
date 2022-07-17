// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

int SumNumbers(int firstElement, int twoElement)
{
    if (firstElement > twoElement) return 0;
    return SumNumbers(firstElement, twoElement - 1) + twoElement;
}

int firstElement = Promt("Введите первое число отрезка M => ");
int twoElement = Promt("Введите последнее число отрезка N => ");

System.Console.Write($"На отрезке от M = {firstElement} до N = {twoElement} сумма натуральных чисел равна {SumNumbers(firstElement, twoElement)}");
;
