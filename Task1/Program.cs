// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] PromptNumbers(int intN)
{
    int[] tempArray = new int[intN];
    for (int i = 0; i<intN; i++)
    {
        System.Console.Write($"Введите {i+1}-ое число: ");
        tempArray[i] = int.Parse(System.Console.ReadLine());
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

void PrintCountOfPositive(int[] intArray)
{
    int counter = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0) counter++;
    }
    System.Console.Write("Среди чисел ");
    printArray(intArray);
    System.Console.Write($" - {counter} чисел больше 0");
}
 
System.Console.WriteLine("Данная программа принимает на вход N чисел, среди которых нужно будет определить количество числе больше 0.");
int intN = PromptInt("Сколько целых чисел вы готовы ввести: ");
int[] arrNumbers = PromptNumbers(intN);
PrintCountOfPositive(arrNumbers);