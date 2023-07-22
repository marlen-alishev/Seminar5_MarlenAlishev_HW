// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

double[] myArray = new double[10];

//Заполняем массив случайными числами
double[] FillArray(double[] newArray){
    for (int i=0; i<newArray.Length; i++){
        newArray[i] = Math.Round(new Random().NextDouble() * ((100.99) - (-100.01)) + (-100.01), 2); 
    }
    return newArray;
}

//Создаем массив
Console.WriteLine($"[{string.Join("; ", FillArray(myArray))}]");

//Ищем максимальное число
double max = 0;
for (int i=0; i<myArray.Length; i++) {
    if (myArray[i]>max) {
        max = myArray[i];
    }
}

//Ищем минимальное число
double min = max;
for (int i=0; i<myArray.Length; i++) {
    if (min > myArray[i]) {
        min = myArray[i];
    }
}

//Разница между макс и мин
double result = max - min; 

Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine("The final result is: " + Math.Round(result, 2));

//Я пытался все аккуратно засунуть в функции, но выходили постоянные ошибки на тип значений переменных и результатов. 
//Поэтому сделал как мог :-) 