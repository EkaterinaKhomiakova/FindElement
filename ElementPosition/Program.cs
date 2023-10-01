// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве и возвращает значение этого элемента,
//  или же указание, что такого элемента нет
int a = 0;
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      matrix[i, j] = new Random().Next(0, 16);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }

}


int[] ReadPosition()
{
  Console.Write("Какой элемент вывести?");
  int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
  return position;
}

void FindElement(int[,] matrix, int[] position)
{

  if (position[0] < matrix.GetLength(0) && position[1] < matrix.GetLength(1))
  {
    Console.Write($"{matrix[position[0], position[1]]}");
  }
  else
    Console.Write("Элемента нет");

}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
int[] Indexes = ReadPosition();
FindElement(matrix, Indexes);