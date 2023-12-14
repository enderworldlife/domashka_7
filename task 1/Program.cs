
// //zadanye 1

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// void PrintNumbers(int a, int b){
//     if (a <= b){
//         Console.Write(a + " ");
//         PrintNumbers(a + 1, b);
//     }
// }
// PrintNumbers(a, b);




// static int AckermannFunction (int m, int n){
//     if (m == 0){
//         return n + 1;
//     }
//     else if (n == 0){
//         return AckermannFunction(m - 1, 1);
//     }
//     else{
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }



// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = AckermannFunction(m, n);

// Console.WriteLine($"Значение функции Аккермана для m {m} и n {n} равно {result}");




static void PrintArrayReversed(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReversed(array, index - 1);
    }
}

int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReversed(array, array.Length - 1);


