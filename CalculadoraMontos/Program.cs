// See https://aka.ms/new-console-template for more information
Console.WriteLine("** CALCULADORA DE MONTOS **");
Console.WriteLine(" ");

int cantidad;
double precio;

Console.WriteLine("Ingrese la cantidad seleccionada: ");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto C$: ");
precio = int.Parse(Console.ReadLine());

double monto = cantidad * precio;
double descuento = 11 / 100 * monto; 
double total = monto - descuento;

Console.WriteLine("_____________________________________________");
Console.WriteLine("MONTO A CANCELAR C$: "+ monto.ToString("0.00"));
Console.WriteLine("DESCUENTO C$:        " + descuento.ToString("0.00"));
Console.WriteLine("TOTAL A PAGAR C$:    " + total.ToString("0.00"));