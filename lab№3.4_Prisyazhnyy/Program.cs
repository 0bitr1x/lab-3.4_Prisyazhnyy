//Сборник задач/тема 3/подтема 3.4/высокий уровень/вариант 22
try
{
Console.Write("Введите верхний придел сигмы k: ");
double kMax = double.Parse(Console.ReadLine());
Console.WriteLine("|   x   |  f (x)  |");
double sum = 0;
for (double x = 1; x <= 2.1; x += 0.1)
{
    for(double k = 1; k <= kMax; k++)
    {
        double factorial = 1;
        double f = 2 * k - 1;
        for(double i = 1; i <= f; i++) factorial *= i;
        sum += (Math.Exp(k) * Math.Pow(x, k)) / factorial;
    }
    Console.WriteLine($"|{x,5:F2}{"|",3}{sum,7:F2}{"|",3}");
}
catch (Exception ex)
{
Console.WriteLine(ex.Message);
}
