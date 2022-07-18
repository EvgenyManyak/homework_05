Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите {0} число : ", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int max = array[0];
int min = array[0];
for (int i = 1; i < n; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);