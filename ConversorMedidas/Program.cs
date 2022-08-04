// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(" **cONVERSION DE MEDIDAS **");
Console.WriteLine("");

double metros;

Console.WriteLine("INGRESE LA MEDIA DE LA TELA EN METROS");
metros = int.Parse(Console.ReadLine());

double centimetro, yarda, pulgada, pies;
centimetro = metros * 100.0;
pulgada = centimetro / 2.54;
pies = pulgada / 12.0;
yarda = pies / 3.0 ;

Console.WriteLine("*******************");
Console.WriteLine("LA MEDIDA EN CENTIMETROS ES:"  +centimetro.ToString("0.00"));
Console.WriteLine("LA MEDIDA EN PULGADAS ES : " + pulgada.ToString("0.00"));
Console.WriteLine("LA MEDIDA EN PIES ES: " +pies.ToString("0.00"));
Console.WriteLine("LA MEDIDA EN YARDAS ES: " +yarda.ToString("0.00"));
Console.WriteLine("*******************");





