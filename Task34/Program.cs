// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PushArray(int [] array)
{
  for(int i=0; i<array.Length; i++)
  {
    array[i] = new Random().Next(99, 1000);
  }
}
void PrintArray(int [] array)
{
  foreach (int i in array)
  {
    Console.Write((i) + " ");
  }
}
void SearchEven(int [] array) 
{
  int count = 0;
  foreach (int i in array)
  {
    if(i%2==0) count ++;
  }
  Console.WriteLine($"Четных чисел в массиве {count}");
}

int [] numbers = new int[5];
PushArray(numbers);
PrintArray(numbers);
SearchEven(numbers);
