//Скрипников Сергей 17
Console.WriteLine("Укажите длинну ме`ньшего основания: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите длинну бо`льшего основания: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите угол A при бо`льшем основании: ");
int alfa = Convert.ToInt32(Console.ReadLine());
{
    double tg = Math.Tan(alfa);
    double d = (b - a) / 2;
    double h = tg * d;
    double s1 = d * h;
    double s2 = a * h;
    double s = s1 + s2;
    Console.WriteLine(s);
}
