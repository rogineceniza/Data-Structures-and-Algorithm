
using System.Numerics;

int[,] number = new int[,]
{
    {0, 0,0},
    { 1, 1, 1},
    { 2, 2, 2},
    { 3, 3, 3},
    { 4, 4, 4},
    { 5, 5, 5},
    { 6, 6, 6},
    { 7, 7 , 7},
    { 8, 8, 8},
    { 9, 9, 9},
    { 10, 10, 10},
    { 11, 11, 11},
};




//for (int i = 0; i < number.GetLength(0); i++)
//{
//    //Console.Write("Row " + i + ": ");

//    for (int j = 0; j < number.GetLength(1); j++)
//    {
//        Console.Write(number[i, j] + " ");
//    }
//    Console.WriteLine();
//}

for (int i = 0; i < number.GetLength(0); i++)
{
    Console.Write($"Row {i}: ");
    for (int j = 0; j <number.GetLength(1); j++)
    {
        Console.Write(number[i,j] + " ");
    }
    Console.WriteLine();
}

    
