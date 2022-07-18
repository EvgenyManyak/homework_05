int[] matrix = new int[8];

void FillArray(int[] matrix, int min, int max){
  for (int i = 0; i < matrix.Length; i++ )
  {
    matrix[i] = new Random().Next(min, max);
  }
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++ )
    {
    Console.Write(matrix[i] + " ");
    }
  Console.WriteLine();
}

int CountNumbers(int[] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.Length; i++ )
    {
    if (matrix[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

FillArray(matrix, 100, 1000);
PrintArray(matrix);
Console.WriteLine();

int count = CountNumbers(matrix);
Console.WriteLine($"Количество чётных чисел: {count}");