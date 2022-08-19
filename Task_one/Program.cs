/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите длину массива: ");

int lengthArray = Convert.ToInt32(Console.ReadLine());

int [] array= new int[lengthArray];
int countEvenNumbers = 0;

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);

    if(array[i] % 2 == 0){
        countEvenNumbers++;
    }
}

 Console.WriteLine($"Все элементы массива");
foreach(int elem in array){
   Console.Write(elem + ",");
}

 Console.WriteLine($" Количество четных чисел в массиве = {countEvenNumbers}");


