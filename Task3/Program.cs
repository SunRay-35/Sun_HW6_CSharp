// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray (int[,] arrNums, int rows, int cols)
{
    for (int i=0; i<rows; i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j=1; j<cols; j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");    
    }
}

int FindSumOfMax (int[,] arrNums, int rows, int cols)
{
    int intSum = 0;
    System.Console.Write("Сумма максимумов: ");
    for (int i=0; i<rows; i++)
    {
        if (i>0) System.Console.Write("+");
        int temp = FindMaxInRow(arrNums, i, cols);
        System.Console.Write(temp);
        intSum += temp;
    }
    System.Console.WriteLine($"={intSum}");
    return intSum;
}

int FindMaxInRow (int[,] arrNums, int row, int cols)
{
    int intMax = arrNums[row, 0];
    for (int j=1; j<cols; j++)
    {
        if (arrNums[row,j]>intMax) intMax = arrNums[row,j];
    }
    return intMax;
}

int FindSumOfMin (int[,] arrNums, int rows, int cols)
{
    int intSum = 0;
    System.Console.Write("Сумма минимумов: ");
    for (int j=0; j<cols; j++)
    {
        if (j>0) System.Console.Write("+");
        int temp = FindMinInCol(arrNums, rows, j);
        System.Console.Write(temp);
        intSum += temp;
    }
    System.Console.WriteLine($"={intSum}");
    return intSum;
}

int FindMinInCol (int[,] arrNums, int rows, int col)
{
    int intMin = arrNums[0, col];
    for (int i=1; i<rows; i++)
    {
        if (arrNums[i,col]<intMin) intMin = arrNums[i,col];    
    }
    return intMin;    
}

int[,] arrNums = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } }; // задаем начальный массив
// пока решил не выводить в отдельную функцию поиск размерности, подумаю как оптимально сделать
int intRows = arrNums.GetUpperBound(0) + 1; // количество строк
int intCols = arrNums.Length / intRows; // количество столбцов  

PrintArray(arrNums, intRows, intCols);

int SumOfMax = FindSumOfMax(arrNums, intRows, intCols);
int SumofMin = FindSumOfMin(arrNums, intRows, intCols);

System.Console.WriteLine($"Разница между суммами максимумов и минимумов: {SumOfMax}-{SumofMin}={SumOfMax-SumofMin}");