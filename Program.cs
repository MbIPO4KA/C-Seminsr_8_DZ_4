/*...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
//=================================================================



int[,,] ThreeDimensionalArray(int rows, int cols, int depth, int min, int max)
{
    // Чтобы создать двумерный массив мы создаём некую матрицу
    int[,,] matrix = new int[rows, cols, depth];
    // наш двумерный массив проходим сначала по строчкам, потом по столбцам
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = new Random().Next(min, max );
            }
        }
    }
    return matrix;
}
//===========================================================
/// <summary>
/// Метод печатает матрицу, переданную на вход
/// </summary>
/// <param name="inputMatrix"> Входная матрица</param>
 void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++) 
            { 
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k})\t"); 
            }
            Console.WriteLine();
        }
    }
}

int[,,] rezultMatrix = ThreeDimensionalArray(2, 2, 2, 10, 100);

// 2. Печать матрицы
PrintMatrix(rezultMatrix);
Console.WriteLine();
