/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/



int [] array = FillArray(10);
Console.WriteLine(string.Join(",",array));

Console.WriteLine(Count(array));

int[] FillArray(int size) {
    int [] arr = new int[size];
    for(int i = 0; i < size; i++) {
        arr[i] = new Random().Next(100, 1000);
    }
return arr;
}

int Count (int[] arr) {
    int count = 0;
    foreach (int item in arr)
    {
        if(item % 2 == 0) count++;
    }
return count;
}