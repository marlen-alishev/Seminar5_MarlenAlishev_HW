// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] myArray = new int[new Random().Next(1, 20)];

int[] FillArray(int[] newArray){
    for (int i=0; i<newArray.Length; i++){
        newArray[i] = new Random().Next(-100, 100); 
    }
    return newArray;
}

int CountSum(int[] countArray){
    int sum = 0; 
    for (int i=0; i<countArray.Length; i++){
        if (countArray[i] % 2 != 0){
            sum = sum + countArray[i];
        }
    }
return sum;
}

Console.WriteLine("The result is: " + CountSum(FillArray(myArray)));
//Console.WriteLine($"[{string.Join(",", myArray)}]");