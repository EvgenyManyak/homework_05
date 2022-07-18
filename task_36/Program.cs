int[] matrix = new int[10];
for (int i = 0; i < matrix.Length; i++)
{
    Console.Write($"Введите matrix[{i}] = ");
    matrix[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < matrix.Length; i++)
{
    if (matrix[i] % 2 == 1)
        sum += matrix[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}");
