// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

Console.Clear();
int Prompt(string message) // То что я ввожу (обработка ввода) Promt это метод записи который мы можем использовать в текущем коде
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int NaturalNumber(int n, int m)
{

    if (n == m)
    {


        {

            return n;
        }


    }


    else 
    
        {
            Console.Write($"{NaturalNumber(n, m + 1)}, ");

            return m;
        }
       
    
}


int n = Prompt("Введите число: ");


Console.Write($"{NaturalNumber(n,1)}, ");


