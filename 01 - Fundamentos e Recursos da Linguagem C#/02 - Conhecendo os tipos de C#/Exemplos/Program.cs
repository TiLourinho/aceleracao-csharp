/*
Declaração fortemente tipada

int x;
decimal y;
bool z;

x = 57;
y = 0.45M;
z = false;
*/

/*
Tipos de Linguagem

decimal Name = "Maria";
// Não se pode, implicitamente, converter o tipo "string" para "decimal"

int Age = 29.5;
// Não se pode, implicitamente, converter o tipo "double" para "int", embora haja uma conversão explícita

string Amount = 10;
// Não se pode, implicitamente, converter o tipo "int" para "string"

// Exemplos de boas práticas em nomenclaturas de variáveis
string excerptFromBook = "Ser ou não ser, eis a questão";
float floatValue = 100.0f;
double doubleValue = 100.0d;
decimal decimalValue = 100.0M;
*/

/*
Interface de comunicação com o programa

// Entrada de Dados
int Age = int.Parse(Console.ReadLine());
decimal Average = decimal.Parse(Console.ReadLine());
bool Permission = bool.Parse(Console.ReadLine());
string Name = Console.ReadLine();

// Saída de Dados
Console.WriteLine("Este é um exemplo de saída de dados");

// Exemplo de concatenação de Dados
int Number = 10;
string Name = "Trybe";
Console.WriteLine("O valor da variável numero é: " + Number);
Console.WriteLine("Eu sou um estudante " + Name + "!");
*/

/*
Calcula Lâmpada

// ENTRADA DE DADOS
Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
Console.WriteLine("Informe o nome do cômodo: ");
string convenient = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
int power = int.Parse(Console.ReadLine());

// PROCESSAMENTO
decimal squareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLightBulbs = squareMeter / quotientX;

// SAIDA DE DADOS
Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessário a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");
*/

/*
Outros Tipos de Dados no C#


*/