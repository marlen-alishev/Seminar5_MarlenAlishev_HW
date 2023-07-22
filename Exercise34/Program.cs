// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] myArray = new int[new Random().Next(1, 20)];

int[] FillArray(int[] newArray){
    for (int i=0; i<newArray.Length; i++){
        newArray[i] = new Random().Next(100, 1000); 
    }
    return newArray;
}

int CountEvenNumbers(int[] countArray){
    int count = 0; 
    for (int i=0; i<countArray.Length; i++){
        if (countArray[i] % 2 == 0){
            count++;
        }
    }
return count;
}

Console.WriteLine("The result is: " + CountEvenNumbers(FillArray(myArray)));
//Console.WriteLine($"[{string.Join(",", myArray)}]");