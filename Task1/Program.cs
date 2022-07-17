// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

void PrintEvenNumbers(int firstElement, int twoElement)
{
    if (firstElement > twoElement) return;
    if (twoElement % 2 == 1)
    {
        twoElement--;
    }
    PrintEvenNumbers(firstElement, twoElement - 2);
    System.Console.Write($"{twoElement}; ");
}

int firstElement = Promt("Введите первое число отрезка M => ");
int twoElement = Promt("Введите последнее число отрезка N => ");

System.Console.Write($"На отрезке от M = {firstElement} до N = {twoElement} находятся натуральные числа ");
PrintEvenNumbers (firstElement, twoElement);




