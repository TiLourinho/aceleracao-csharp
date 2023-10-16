using System.Globalization;

/* Operações Aritméticas */

// Adição
int a = 50, b = 50;
int result1 = a + b;
Console.WriteLine("Adição: " + a + " + " + b + " = " + result1);

// Subtração
int c = 77, d = 21;
int result2 = c - d;
Console.WriteLine("Subtração: " + c + " - " + d + " = " + result2);

// Multiplicação
int e = 5, f = 5;
int result3 = e * f;
Console.WriteLine("Multiplicação: " + e + " * " + f + " = " + result3);

// Divisão
int g = 90, h = 9;
int result4 = g / h;
Console.WriteLine("Divisão: " + g + " / " + h + " = " + result4);

// Módulo
int i = 36, j = 7;
int result5 = i % j;
Console.WriteLine("Módulo: o resto da divisão de " + i + " por " + j + " é: " + result5);

/* Operadores Aritméticos de Atribuição Reduzida */

Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
// Assim é definido a cultura como en-US e podemos usar o float como "10.33"

int num1 = 1;
num1++;
Console.WriteLine($"\nIncrementa + 1 ao valor de num1 => num1 = {num1}");

int num2 = 10;
num2--;
Console.WriteLine($"Decrementa - 1 ao valor de num2 => num2 = {num2}");

int num3 = 23;
num3 += 15;
Console.WriteLine($"num3 = {num3}");

int num4 = 31;
num4 -= 6;
Console.WriteLine($"num4 = {num4}");

int num5 = 11;
num5 *= 3;
Console.WriteLine($"num5 = {num5}");

decimal num6 = 11;
num6 /= 3;
Console.WriteLine($"num6 = {num6:N2}");

decimal num7 = 11;
num7 %= 3;
Console.WriteLine($"num7 = {num7:N2}");
