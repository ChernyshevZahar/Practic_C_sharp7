// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// int stro = 3;
// int col = 4;


// PrintDoudleArray(ArrayDoudle(col,stro,-5,10));

// double[,] ArrayDoudle(int coll, int stro,int start, int stop){
//     Random random = new Random();
//     double[,] arr = new double[stro,coll];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//             arr[i,j]= Math.Round(random.Next(start,stop) * random.NextDouble(),1);
//        }   
//     }
//     return arr;
// }

// void PrintDoudleArray( double [,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < arr.GetLength(1); j++)
//                 {
//                     Console.Write($"{arr[i,j]} ");
//                 }
//     }
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.Write("Напишите сточка: ");
// int srtoch = int.Parse(Console.ReadLine());
// Console.Write("Напишите столбик: ");
// int coll = int.Parse(Console.ReadLine());

// int[,] arr = ArrayInt(3,4,1,10);
// PrintArrayDouble(arr);
// Console.WriteLine();
// SearchElement(arr,srtoch,coll);


// void SearchElement(int[,]arr, int st, int cl){
//     if(st-1<=arr.GetLength(0)&&cl-1<=arr.GetLength(1)){ // условия с -1 для того чтобы пользователь не знающий правила отсчёта от 0 в массиве мог вводить строики и столбцы 
//     Console.WriteLine($"На строке: {st} и столбике: {cl} -> такое число есть в массиве: {arr[st-1,cl-1]}");
//     }else{
//         Console.WriteLine($"{st},{cl} -> такого числа в массиве нет");
//     }
// }


void PrintArrayDouble( int [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
    }
}

int[,] ArrayInt(int stro, int coll,int start, int stop){
    Random random = new Random();
    int[,] arr = new int[stro,coll];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            arr[i,j]= random.Next(start,stop);
       }   
    }
    return arr;
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr3 = ArrayInt(3,4,0,10);
PrintArrayDouble(arr3);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(ArithmeticMeanColl(arr3));


double[] ArithmeticMeanColl(int[,] array){
        double[] arr = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[j] = arr[j]+array[i,j];
            }
        }
        for (int g = 0; g < arr.GetLength(0); g++)
        {
            arr[g] = Math.Round(arr[g]/array.GetLength(0),1) ;
        }
        return arr;
}



void PrintArray( double [] arr){
    for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"{arr[j]} ");
        }
}
