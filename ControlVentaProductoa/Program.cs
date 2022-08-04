// See https://aka.ms/new-console-template for more information
Console.WriteLine("**CONTROL DE VENTA DE PRODUCTOS**");
Console.WriteLine(" ");

double precio;
int cpr;

Console.WriteLine("Ingrese la cantidad de producto");
cpr = int.Parse(Console.ReadLine());

double ic = cpr * precio;
double id = 11 / 100 * ic;
double ip = ic - id;

