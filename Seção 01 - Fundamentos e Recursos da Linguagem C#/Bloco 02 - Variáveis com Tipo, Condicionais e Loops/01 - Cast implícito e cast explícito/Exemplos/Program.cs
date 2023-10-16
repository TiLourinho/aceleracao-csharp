/* Cast Implícito */

// Como long e int são compatíveis o casting ocorre implicitamente
int someIntNumber = 51;
long longNumberCast = someIntNumber;

Console.WriteLine(longNumberCast); // 51

// Neste caso há perda de informação. O compilador ignora as casas decimais no resultado da divisão
int intResult = 5 / 2;

Console.WriteLine(intResult); // 2

/* Cast Explícito */

// Tentar atribuir o valor de uma variável do tipo long a uma do tipo inteiro não pode ocorrer naturalmente, pois os espaços de memória, agora, não são compatíveis
// long someLongNumber = 516144066604654;
// int intNumber = someLongNumber;

// Console.WriteLine(intNumber); // Não é possível converter implicitamente tipo "long" em "int". Existe uma conversão explícita (há uma conversão ausente?)

long someLongNumber = 516144066604654;
int intNumber = (int)someLongNumber;

Console.WriteLine(intNumber); // 666775150
// Houve perda de informação e esse é o perigo de usar o cast (int). O C# não avisará sobre esse erro

// int otherIntNumber = Convert.ToInt32(someLongNumber);

// Console.WriteLine(otherIntNumber); // Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
// Nesse caso, o Convert.ToInt32 vai nos avisar que o número que está sendo convertido não cabe em uma variável int

long otherLongNumber = 42;
int anotherNumber = Convert.ToInt32(otherLongNumber);

Console.WriteLine(anotherNumber); // 42
// Se for possível converter o número, a conversão ocorrerá sem problemas

/* Conversão de String para Números */

string userEntry = "40";
int valueConverted;

bool canConvert = Int32.TryParse(userEntry, out valueConverted);
// Se a conversão for possível, a variável canConvert terá o valor de true e valueConverted terá o valor convertido
// Se houver erro, canConvert será false e valueConverted será 0

Console.WriteLine(canConvert);
Console.WriteLine(valueConverted);
Console.WriteLine();

/* Exemplo: Valores de Parcelas */

/*
    1 - Mostrar o valor total
    2 - Pedir para digitar o número de parcelas
    3 - Informar o valor da parcela
*/

double totalValue = 152.60;
Console.WriteLine($"O valor total é: R$ {totalValue:N2}.");

Console.WriteLine("Digite o número de parcelas:");
int installments = Convert.ToInt32(Console.ReadLine());

double installmentValue = totalValue / installments;
Console.WriteLine($"O valor da parcela é: R$ {installmentValue:N2}.");
