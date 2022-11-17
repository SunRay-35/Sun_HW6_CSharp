// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int qRows, int qCols, int minLim, int maxLim)
{
    int[,] table = new int[qRows, qCols];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(minLim, maxLim);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintList (string msg, List<int> list, bool IsRow) // научимся выводить и в строку и в столбик, универсальная функция =)
{
    Console.WriteLine(msg);
    if (IsRow)
    foreach (int item in list)
    {

        Console.WriteLine($"{item} "); // здесь делаю вывод, что с list выводить удобней
    }
    else
    foreach (int item in list)
    {

        Console.Write($"{item} ");
    }
    if (!IsRow) Console.WriteLine(); // для красоты
    Console.WriteLine(); // для красоты
}

List<int> MaxRow(int[,] array)
{
    List<int> rowsMax = new List<int>(); // я душнила))) и поменял тебе raws на rows, надеюсь я был прав)
    int i = 0;
    do
    {
        int maxRow = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxRow)
            {
                maxRow = array[i, j];
            }
        }
        rowsMax.Add(maxRow);
        i++;
    }
    while (i < array.GetLength(0));
    PrintList ("List with maximum value by rows: ", rowsMax, true);
    return rowsMax;
}

int SumOfMaxRows (List <int> anyList)
{
    int [] maxrows = anyList.ToArray();
    int sum = 0;
    for(int i = 0; i < maxrows.Length; i++)
    {
        sum+=maxrows[i];
    }
    return sum;
}

List<int> MinColumn(int[,] array)
{
    List<int> colsMin = new List<int>(); // раз rows то и cols
    int j = 0;
    do
    {
        int minCol = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < minCol)
            {
                minCol = array[i, j];
            }
        }
        colsMin.Add(minCol);
        j++;
    }
    while (j < array.GetLength(1));
    PrintList("List with minimum value by columns: ", colsMin, false);
    return colsMin;
}

int SumOfMinColumns (List <int> anyList)
{
    int [] mincolumn = anyList.ToArray();
    int sum = 0;
    for(int i = 0; i < mincolumn.Length; i++)
    {
        sum+=mincolumn[i];
    }
    return sum;
}

int DiffBetweenSums (int sumMax, int sumMin)
{
    int maxMinusMin = sumMax - sumMin;
    return maxMinusMin;
}

void Runner()
{
    Console.WriteLine(); // для красоты
    int minLim = Prompt("Enter lower threshold for the value of matrix element ");
    int maxLim = Prompt("Enter upper threshold for the value of matrix element ");
    Console.WriteLine(); // для красоты
    int[,] matrix = CreateArray(4, 6, minLim, maxLim);
    PrintArray(matrix);
    List<int> maxRows = MaxRow(matrix);
    List<int> minColumn = MinColumn(matrix);
    int sumMaxRows = SumOfMaxRows(maxRows);
    int sumMinColumns = SumOfMinColumns(minColumn);
    int sumMaxMinusMin = DiffBetweenSums(sumMaxRows, sumMinColumns);
    Console.WriteLine($"Sum of Maximums of each row equals {sumMaxRows} "); // Владимир сказал считать и печатать отдельно =)
    Console.WriteLine($"Sum of Minimuns of each column equals {sumMinColumns} ");
    Console.WriteLine($"Sum of Maximums by rows minus Sum of Minimums by columns equals {sumMaxMinusMin} ");
    Console.WriteLine(); // для красоты
}

Runner();