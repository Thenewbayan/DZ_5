// /Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Сщздадим случайный массив из 3 значных чисел и найдем количество четных чисел в нем");
Console.WriteLine("Укажите сколько случайных чисел вы хотите получить");
int size=Convert.ToInt32(Console.ReadLine());
int [] array=new int [size];
for (int i=0; i<size; i++)
{
    array[i]=new Random().Next(100, 1000);
}
int count=0;// счетчик четных чисел
for (int i=0; i<size; i++)
{
    if(array[i]%2==0)
    {
        count++;
        
    }
}
Console.WriteLine(String.Join(";", array));
Console.WriteLine(count);