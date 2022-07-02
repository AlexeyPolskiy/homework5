// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3, 7, 22, 2, 78] -> 76

int Promt(string massage)
{
    System.Console.Write(massage);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

double[] FillArray(double[] collection, int elementMIN, int elementMAX)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(elementMIN, elementMAX) + new Random().NextDouble();
    }
    return collection;
}

void PrintArray(double[] printMas)
{
    int count = printMas.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{printMas[i]:F3} ");
    }
}

double[] FindAndDiffElement(double[] diffMas)
{
    double min = diffMas[0];
    double max = diffMas[0];
    int lengthMas = diffMas.Length;
    for (int i = 0; i < lengthMas; i++)
    {
        if (diffMas[i] < min) min = diffMas[i];
        if (diffMas[i] > max) max = diffMas[i];
    }
    double diffElements = max - min;
    System.Console.WriteLine($"Разность между максимальным ({max:f3}) и минимальным ({min:f3}) элементом составляет {diffElements:f3}");
    return diffMas;
}

int NumberElementMassiv = Promt("Введите число элементов массива => ");
int elementMIN = -10;
int elementMAX = 10;

double[] array = new double[NumberElementMassiv];

FillArray(array, elementMIN, elementMAX);
PrintArray(array);
System.Console.WriteLine();
FindAndDiffElement(array);

