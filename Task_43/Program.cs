// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)



double[,] value = new double[2, 2];        
double[] crossPoint = new double[2];        
void InputRatio()
{
  for (int i = 0; i < value.GetLength(0); i++)
  {
    Console.WriteLine($"Enter value {i+1}-equation (y = k{i+1} * x + b{i+1})");
    for (int j = 0; j < value.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Input value k{i+1}: ");
      else Console.Write($"Input value b{i+1}: ");
      value[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
InputRatio();
double[] Decision(double[,] value)
{
  crossPoint[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
  crossPoint[1] = crossPoint[0] * value[0,0] + value[0,1];
  return crossPoint;
}
void OutputResponse(double[,] value)
{
  if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
  {
    Console.Write($"Straight lines match");
  }
  else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
  {
    Console.Write($"straight lines are parallel");
  }
  else 
  {
    Decision(value);
    Console.Write($"Point of intersection of straight lines: ({crossPoint[0]}, {crossPoint[1]})");
  }
}
OutputResponse(value);