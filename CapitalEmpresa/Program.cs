// See https://aka.ms/new-console-template for more information
Console.WriteLine("**CAPITAL DE EMPRESA**");
Console.WriteLine(" ");

double s1,s2,s3;

Console.WriteLine("Ingrese la aportacion del socio #1");
    s1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la aportacion del socio #2");
    s2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la aportacion del socio #3");
    s3 = double.Parse(Console.ReadLine());

double capital = s1 + s2 + s3;
double p1 = s1 * 100 / capital;
double p2 = s2 * 100 / capital;
double p3 = s3 * 100 / capital;

Console.WriteLine("________________________________________________");
Console.WriteLine("El capital es:           " + capital.ToString("0.00"));
Console.WriteLine("Porcentaje del socio #1: " + p1.ToString("0.00"));
Console.WriteLine("Porcentaje del socio #2: " + p2.ToString("0.00"));
Console.WriteLine("Porcentaje del socio #3: " + p3.ToString("0.00"));
