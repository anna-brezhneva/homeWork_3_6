// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
//Console.Write("Введите четыре числа через пробел: ");
//string tochki = Console.ReadLine();
//double[] baseArray = StartArray(tochki);
//Console.WriteLine(String.Join(";", TochkaArray(baseArray)));

    //double[] StartArray(string[] stringArray)
    //{
    //    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    //    double[] result = new double[nums.Length];
    //    for (double i = 0; i < nums.Length; i++)
    //    {
    //        result[i] = double.Parse(nums[i]);
    //    }
    //    return result;
    //}
Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine($"[{String.Join(";", TochkaArray(b1, k1, b2, k2))}]");

double[] TochkaArray(double b1, double k1, double b2, double k2)
{
    int size = 2;
     double[] res = new double[size];
     res[0] = (b2 - b1) / (k1 - k2);
     res[1] = k1 * ((b2 - b1) / (k1 - k2)) + b1;
     return res;
}