/*
Двумерные массивы
*/

string[,] table = new string[2, 5];
// [0,0] [0,1] [0,2] [0,3] [0,4]
// [1,0] [1,1] [1,2] [1,3] [1,4]


// table [1, 2] = "слово";
// for (int rows=0; rows<2; rows++)
// {
//     for (int columns=0; columns<5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintArray (int [,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            System.Console.Write($"{matr[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray (matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray (matrix);