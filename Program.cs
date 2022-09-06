//Задайте две матрицы. 
//Напишите программу, 
//которая будет находить произведение двух матриц.
int[,] m1 = new int[2, 2];
CreateArray(m1);
Console.WriteLine("Первая матрица:");
WriteArray(m1);

int[,] m2 = new int[2, 2];
CreateArray(m2);
Console.WriteLine("Вторая матрица:");
WriteArray(m2);

int[,] proizv = new int[2,2];

MultiplyMatrix(m1, m2, proizv);
Console.WriteLine("Произведение первой и второй матриц:");
WriteArray(proizv);

void MultiplyMatrix(int[,] m1, int[,] m2, int[,] proizv)
{
  for (int i = 0; i < proizv.GetLength(0); i++)
  {
    for (int j = 0; j < proizv.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < m1.GetLength(1); k++)
      {
        sum += m1[i,k] * m2[k,j];
      }
      proizv[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(100);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}