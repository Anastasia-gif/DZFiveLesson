/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите длину массива: ");

int lengthArray = Convert.ToInt32(Console.ReadLine());
int [] array = new int [lengthArray];
int sumOddPositionsElem = 0;

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-9, 9);
    if(i % 2 != 0){
        sumOddPositionsElem += array[i];
    }
}

Console.WriteLine("Элементы массива : ");

foreach(int elem in array){
    Console.Write($"{elem}, ");
}
Console.WriteLine();

Console.WriteLine($"Сумма чисел находящихся на нечётных позициях = {sumOddPositionsElem}");