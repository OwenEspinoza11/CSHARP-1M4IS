// See https://aka.ms/new-console-template for more information
Console.WriteLine(" **CONVERSION DE MEDIDAS**");
Console.WriteLine(" ");

double mt;

Console.WriteLine("Ingrese los metros de tela");
    mt = double.Parse(Console.ReadLine());

double cm = mt * 100;
double pul = cm / 2.54;
double pie = pul / 12.0;
double ya = pie / 3.0;

Console.WriteLine("     .____________________________________________.");
Console.WriteLine("     |Centimetros:     " + cm.ToString("0.00"));
Console.WriteLine("     |Pulgadas:        " + pul.ToString("0.00"));
Console.WriteLine("     |Pies:            " + pie.ToString("0.00"));
Console.WriteLine("     |Yardas:          " + ya.ToString("0.00"));
Console.WriteLine("     |____________________________________________");
