int numero;
string entradaUsuario;
long resultadoAbsoluto;

Console.WriteLine("Escriba un numero :");
numero = int.Parse(Console.ReadLine());
resultadoAbsoluto = Math.Abs(numero);
Console.WriteLine("El Valor Absoluto es : " + resultadoAbsoluto);
Console.WriteLine("El numero ingresado elevado ^3 es : " + Math.Pow(numero, 3));
Console.WriteLine("La raiz cuadrada : " + Math.Sqrt(numero));
Console.WriteLine("El SEN es : " + Math.Sin(numero * Math.PI / 180));
Console.WriteLine("El COS es : " + Math.Cos(numero * Math.PI / 180));
Console.WriteLine("Numero max : " + Math.Max(numero, 50));
Console.WriteLine("Numero min : " + Math.Min(numero, 50));
Console.WriteLine("Parte entera : " + Math.Truncate(18.78));
Console.WriteLine("Redondeo : " + Math.Round(18.78));
Console.ReadKey();
