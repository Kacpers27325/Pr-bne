// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Frytki !");

Console.WriteLine("Pora na smażenie");
Console.WriteLine("Modyfikacja 3 nie mam pomysłu");


static double GetAverage(int [] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return (double)sum / numbers.Length;
}

int[] tablica = { 1, 2, 3, 4, 5 };
/*double average = GetAverage(tablica);
Console.WriteLine(average);*/