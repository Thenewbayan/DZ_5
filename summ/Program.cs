// /Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.WriteLine("Сщздадим случайный массив из  чисел и найдем количество чисел на четных позициях (0,2,4 и тд)");
Console.WriteLine("Укажите сколько случайных чисел вы хотите получить");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите нижнюю и верхнюю границы через enter");
int minValue=Convert.ToInt32(Console.ReadLine());
int maxValue=Convert.ToInt32(Console.ReadLine());
int [] array=new int [size];
for (int i=0; i<size; i++)
{
    array[i]=new Random().Next(minValue, maxValue+1);
}
int summ=0;
for  (int i=0; i<size; i=i+2)
{
    summ+=array[i];
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(summ);