// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void PushArray (double[] array)
{
  for(int i=0; i<array.Length; i++)
  {
    array[i] = new Random().Next(-50,50);
    array[i] = array[i]/10;
  }
}
void PrintArray (double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine(array[i]);
  }
}

void DiffElem(double [] array)
{
  double maxNum = array[0];
  double minNum = array[0];

  for(int i=0; i<array.Length; i++)
  {
    if(maxNum<array[i]) maxNum = array[i];
    if(minNum > array[i]) minNum = array[i];
  }
  Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round((maxNum-minNum),2)}");
}
double[] numbers = new double[5];
PushArray(numbers);
PrintArray(numbers);
DiffElem(numbers);
