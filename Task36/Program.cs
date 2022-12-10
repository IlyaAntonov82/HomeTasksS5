// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void PushArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 100);
  }
}
void PrintArray(int[] array)
{
  foreach (int i in array)
  {
    Console.Write((i) + " ");
  }
}
void SumNotEven (int [] array)
{
  int result = 0;
  for (int i=0; i<array.Length; i++ )
  {
    if(i%2!=0)
    {
      result = result + array[i];
    }
  }
  Console.WriteLine($"Сумма элементов, которые стоят на нечетной позици равна {result}");
} 
int [] numbers = new int[5];
PushArray(numbers);
PrintArray(numbers);
SumNotEven(numbers);
