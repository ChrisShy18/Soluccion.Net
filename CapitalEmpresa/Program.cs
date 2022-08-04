// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("CAPITAL DE EMPRESA");
Console.WriteLine("");

double monto1, monto2, monto3;

Console.WriteLine("INGRESE EL MONTO QUE APORTO EL PRIMER SOCIO: C$ ");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL MONTO QUE APORTO EL SEGUNDO SOCIO: C$");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL MONTO QUE APORTO EL TERCER SOCIO: C$ ");
monto3 = double.Parse(Console.ReadLine());

double capital;
capital= monto1 + monto2 + monto3;

double PSocio1, PSocio2, PSocio3;
PSocio1 = (monto1 * 100) / capital;
PSocio2 = (monto2 * 100) / capital;
PSocio3 = (monto3 * 100) / capital;

Console.WriteLine("EL PROMEDIO DEL PRIMER SOCIO ES: " + PSocio1.ToString("0.00"));
Console.WriteLine("EL PROMEDIO DEL SEGUNDO SOCIO ES: " + PSocio2.ToString("0.00"));
Console.WriteLine("EL PROMEDIO DEL TERCER SOCIO ES: " + PSocio3.ToString("0.00"));
