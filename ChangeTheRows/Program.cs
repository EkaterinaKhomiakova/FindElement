// Задайте двумерный массив. 
// Напишите программу,которая поменяет местами первую и последнюю сроку массива

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


void ChangeArray(int[,] matrix)
{
  int temp;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    temp = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = temp;
  }

}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }

}
int[,] matrix = InputMatrix();
ChangeArray(matrix);
Console.WriteLine();
PrintArray(matrix);