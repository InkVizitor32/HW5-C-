                        // Задача 34: 
                        //             Задайте массив заполненный случайными положительными трёхзначными числами.
                        //             Напишите программу, которая покажет количество чётных чисел в массиве.
                        //             [345, 897, 568, 234] -> 2

// Console.Clear();

// int[] CreateFillArray()

// {
//     int n = new Random().Next(2, 100);
//     int[] arr = new int[n];

//     for (int i = 0; i < n; i++)
//     {


//         arr[i] = new Random().Next(100, 1000);
//         Console.Write($"{arr[i]} ");
//     }

//     return arr;
// }


// void FindCount(int[] arr)
// {
//     int count = 0;
//     foreach (int el in arr)
//     {
//         if (el%2 == 0 ) count++;
//     }
//     Console.Write($"количество чётных чисел в массиве {count}");
// }

// int[] arr = CreateFillArray();
// Console.WriteLine();
// FindCount(arr);



                                    // Задача 36: 
                                    //             Задайте одномерный массив, заполненный случайными числами.
                                    //             Найдите сумму элементов, стоящих на нечётных позициях.
                                    //             [3, 7, 23, 12] -> 19
                                    //             [-4, -6, 89, 6] -> 0

// Console.Clear();

// int[] CreateFillArray()

// {
//     int n = new Random().Next(3, 10);
//     int[] array = new int[n];



//     for (int i = 0; i < n; i++)
//     {


//         array[i] = new Random().Next(-100, 100);
//         Console.Write($"{array[i]} ");
//     }

//     return array;
// }

// void FindCount(int[] array)
// {

//     int lenght = array.Length;
//     int index = 0;
//     int count = 0;
//     while (index < lenght)
//     {
//         if (index % 2 == 1) count = count + array[index];

//         index++;

//     }
//     Console.Write($"сумма элементов, стоящих на нечётных позициях равна {count}");

// }

// int[] array = CreateFillArray();
// Console.WriteLine();
// FindCount(array);





                                        //   Задача 38:                      
                                        //             Задайте массив вещественных чисел.
                                        //             Найдите разницу между максимальным и минимальным элементов массива.


Console.Clear();

double[] CreateFillArray()
{
    double[] array = new double[5];
    Random a = new Random();   //экземпляр генератора случайных чисел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = a.Next(-100, 100) + a.NextDouble();
        Console.Write("{0,6:F2}  ",   array[i]);     // "{0,6:F2}  " ---вывод двух знаков после запятой

    }
    return array;
}


void FindCount (double[] array)
{
    int index = 0;
    double max = array[index];
    double min = array[index];

    foreach ( double el in array) 
    {
        if ( el>max) max =  el;
        if ( el<min) min =  el;
        
     
    }
     Console.WriteLine($" Максимальный элемент: {max}");
     Console.WriteLine($" Минимальный элемент: {min}");
     Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

}


double[] array = CreateFillArray();
Console.WriteLine();
Console.WriteLine();
FindCount(array);



