/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int [] array = FillArray(6);
Console.WriteLine(string.Join(",",array));

Console.WriteLine(Sum(array));

int[] FillArray(int size) {
    int [] arr = new int[size];
    for(int i = 0; i < size; i++) {
        arr[i] = new Random().Next(-10,5);
    }
return arr;
}

int Sum (int[] arr) {
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2) {
        sum+=arr[i];
    }
return sum;
}
