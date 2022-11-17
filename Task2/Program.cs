// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

string Findintersection (int intB1, int intK1, int intB2, int intK2)
{
    if (intB1==intB2 && intK1==intK2) return "Прямые совпадают, бесконечное число общих точек.";
    if (intK1==intK2) return "Прямые параллельны, нет точек пересечения.";
    double dblX =  Math.Round((double)(intB2 - intB1) / (double)(intK1 - intK2),2);
    double dblY = Math.Round(intK1 * dblX + intB1,2);
    return $"Прямые пересекутся в точке({dblX}, {dblY}).";
}

System.Console.WriteLine("Данная программа принимает на вход переменные b1, k1, b2 и k2, затем находит точку пересечения двух прямых y = k1 * x + b1, y = k2 * x + b2.");
int intB1 = PromptInt("Введите b1: ");
int intK1 = PromptInt("Введите k1: ");
int intB2 = PromptInt("Введите b2: ");
int intK2 = PromptInt("Введите k2: ");
System.Console.Write(Findintersection (intB1: intB1, intK1, intB2, intK2));