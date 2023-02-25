// /Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine("Создадим случайный массив из вещ чисел");
Console.WriteLine("Укажите сколько случайных чисел вы хотите получить");
int size=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите нижнюю и верхнюю границы через enter");
// double minValue=Convert.ToDouble(Console.ReadLine());
// double maxValue=Convert.ToDouble(Console.ReadLine());
double [] array=new double [size];

for (int i=0; i<size; i++)
{
    array[i]=Math.Round(100*(new Random().NextDouble()), 4);
    //array[i]*=100;
}
//Console.WriteLine(String.Join(";" , array ));
double MAX=array[0];
double MIN=array[0];
for (int i=0; i<size; i++)
{
     if(array[i]>MAX)
     {
         MAX=array[i];
     }
     if(array[i]<MIN)
     {
         MIN=array[i];
     }
}
 double result=MAX-MIN;
Console.WriteLine(String.Join(";  " , array));
Console.WriteLine($"Наше макс число: {MAX}");
Console.WriteLine($"Наше мин число: {MIN}");
Console.WriteLine($"РАзность саммого большого и самого маленького из наших чисел равна: {result}");