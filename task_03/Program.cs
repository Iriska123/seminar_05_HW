/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76*/



int [] array = FillArray(6);
Console.WriteLine(string.Join(",",array));

Console.WriteLine(DifferenceMaxMin(array));

int[] FillArray(int size) {
    int [] arr = new int[size];
    for(int i = 0; i < size; i++) {
        arr[i] = new Random().Next(-10,11);
    }
return arr;
}

int DifferenceMaxMin (int[] arr) {
    int result = 0;
    int max = arr[0];
    int min = arr[0];

    for(int i = 0; i < arr.Length; i++) { 
        if(arr[i] > max) {
            max = arr[i];
        } else {
            if (arr[i] < min) {
                min = arr[i];
            }
        }
    }
    result = max - min;
return result;
}