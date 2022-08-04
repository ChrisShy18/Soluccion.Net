// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CALCULADORA DE MONTOS ** ");
Console.WriteLine("");

int cantidad;
double precio;

Console.WriteLine("Ingrese la cantidad seleccionada: ");
cantidad= int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto C$: ");
precio = double.Parse(Console.ReadLine());

double monto = cantidad * precio;

Console.WriteLine("*******************");
Console.WriteLine("MONTO A CANCELAR C$: " + monto.ToString("0.00"));


