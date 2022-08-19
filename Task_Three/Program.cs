/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите длину массива: ");           

int lengthArray = Convert.ToInt32(Console.ReadLine());

double [] array= new double[lengthArray];
double maxValue = Double.MinValue;
double minValue = Double.MaxValue;
Random rnd = new Random();

for(int i = 0; i < array.Length; i++){
    array[i] = rnd.NextDouble();
    if( maxValue < array[i]){
        maxValue = array[i];
    }if(minValue > array[i]){
        minValue = array[i];
    }
}

Console.WriteLine("Элементы массива : ");
foreach(double elem in array){
    Console.Write($"{elem}, ");
}
    Console.WriteLine();

double differenceMaxMinValue = maxValue - minValue;
Console.WriteLine($"Разница между максимальным и минимальным элементом = {differenceMaxMinValue}");