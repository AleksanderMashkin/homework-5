/* Console.WriteLine("Напишите сколько чисел будет в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[N];
for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("Впишите трехзначное число");
    intArray[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);

*/

/*
Console.WriteLine("Напишите из какого количества чисел создать массив");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] intArray = new int[N];
for (int i = 0; i < intArray.Length; i++)
{
    Random rnd = new Random();
    intArray[i] = rnd.Next(0, 100);
}

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(intArray[i]);
    Console.WriteLine();
}


int count = 0;

for (int i = 1; i < intArray.Length; i = i + 2)
{
    count = count + intArray[i];
}
Console.WriteLine(count + " = " + "сумма элементов, стоящих на нечетных позициях");
*/

Console.WriteLine("Напишите из какого количества чисел создать массив");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] intArray = new double[N];
for (int i = 0; i < intArray.Length; i++)
{
    Random rnd = new Random();
    intArray[i] = rnd.Next(0, 100);
}

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(intArray[i]);
    Console.WriteLine();
}

double max = intArray[0];

for (int i = 1; i < intArray.Length; i++)
{
    if (max < intArray[i])
    {
        max = intArray[i];
    }
}

double min = intArray[0];

for (int i = 1; i < intArray.Length; i++)
{
    if (min > intArray[i])
    {
        min = intArray[i];
    }
}

Console.WriteLine(max-min + " - разница между максимальным и минимальным значением массива");