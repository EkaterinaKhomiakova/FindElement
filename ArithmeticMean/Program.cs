// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных
int[,] InputMatrix()
{
  Console.Write("Введите размер матрицы: ");
  int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
  int[,] matrix = new int[size[0], size[1]];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      matrix[i, j] = new Random().Next(1, 50);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
  return matrix;
}

int[] Convert2dTo1d(int[,] matrix)
{
  int k = 0;
  int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      array[k++] = matrix[i, j];
    }
  }
  return array;
}

void PrintFr(int[] array)
{
  int count = 1;
  int oldValue = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (oldValue == array[i])
      count++;
    else
    {
      Console.WriteLine($"{oldValue} встречается в массиве:{count} раз");
      count = 1;
      oldValue = array[i];

    }
  }
  Console.WriteLine($"{oldValue} встречается в массиве:{count} раз");
}
int[,] matrix = InputMatrix();
int[] array = Convert2dTo1d(matrix);
Array.Sort(array);
PrintFr(array);