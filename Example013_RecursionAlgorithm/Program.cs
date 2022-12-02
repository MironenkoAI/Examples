// Двумерные массивы

// МАССИВ СТРОЧНЫЙ:
/* string[,] table = new string[2,5];
// String.Empty - инициализация для строк
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"{table[rows, columns]}-");
    }
} */


// МАССИВ ЦИФРОВОЙ:
/* int[,] matrix = new int[3,4];
                    //передает количество линий, заданное пользователем (общий случай)
for (int i = 0; i < matrix.GetLength(0); i++)
{                        // пердаст количество столбцов (общий случай)
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
} */

// МЕТОД, который будет выводить на печать
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);

// МЕТОД, который будет заполнять случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1,10) - полуинтервал
        }
    }
}
// int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);