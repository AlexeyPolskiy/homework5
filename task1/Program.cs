// Задача 1: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int promt(string massage)
{
    System.Console.Write(massage);
    string num = Console.ReadLine();
    int numberInt = int.Parse(num);
    return numberInt;
}

void FillArray(int[] collection, int limitMIN, int limitMAX)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(limitMIN, limitMAX);
    }
}

void PrintArray(int[] printMas)
{
    int count = printMas.Length;
    for (int position = 0; position < count; position++)
    {
        System.Console.Write($"{printMas[position]} ");
    }
}


int NumberElementMassiv = promt("Введите число элементов массива => ");

int limitMIN = 100;
int limitMAX = 1000;

int[] Massiv = new int[NumberElementMassiv];

FillArray(Massiv, limitMIN, limitMAX);
System.Console.WriteLine();
PrintArray(Massiv);

int unswer = 0;

for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i] % 2 == 0)
    {
        unswer++;
    }
}

System.Console.WriteLine($" в массиве {unswer} четных чисел");