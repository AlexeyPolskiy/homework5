// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int promt(string massage)
{
    System.Console.Write(massage);
    string num = Console.ReadLine();
    int numberInt = int.Parse(num);
    return numberInt;
}

int[] FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-9, 10);
    }
    return collection;
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

int[] array = new int[NumberElementMassiv];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int unswer = 0;

for (int i = 0; i < array.Length; i += 2)
{
    unswer = unswer + array[i];
}

System.Console.WriteLine($"сумма нечетных элементов = {unswer}");