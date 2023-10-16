/* Estruturas de controle */

Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro):");
string? response = Console.ReadLine();

int radius = 0;
var canConvert = Int32.TryParse(response, out radius);

if (canConvert)
{
    const double PI = 3.14159;
    double circumference = PI * (2 * radius);

    Console.WriteLine($"A circunferência de um círculo com raio {radius} é igual a: {circumference:N2}");
}
else
{
    Console.WriteLine("O texto digitado não é um número inteiro");
}
// O programa acima define se calcula e imprime a circunferência de acordo com o valor da variável canConvert
// Assim, conseguimos alterar a ordem na qual as instruções são executadas de acordo com o valor informado pela pessoa usuária

Console.WriteLine();

/* Estrutura de seleção If */

/*
if (condição)
{
    //bloco de código a ser executado quando a condição for VERDADEIRA
    comandos;
}
*/

// if/else

// Nem todo if precisa de um else, mas todo else precisa de um if
// A cláusula else é opcional na estrutura if e seu conteúdo só será executado se o resultado da condição avaliada no if for uma expressão booleana falsa.

int month = 7;

if (month == 1)
{
    Console.WriteLine("mês janeiro");
}
else
{
    Console.WriteLine("mês diferente de janeiro");
}

// Efeito cascata

int number = -158;

if (number > 0)
{
    Console.WriteLine("maior que zero");
}
else
{
    if (number < 0)
    {
        Console.WriteLine("menor que zero");
    }
    else
    {
        Console.WriteLine("igual a zero");
    }
}

// Instruções de uma única linha

// No C# um bloco de instrução é sempre colocado entre {}, para delimitar seu contexto
// Porém o uso das chaves não é obrigatório para definir uma instrução de uma linha do if/else

if (number > 10)
    Console.WriteLine("maior que 10");
else
    Console.WriteLine("menor ou igual a 10");

// Pode-se reduzir a quebra de linha também

if (number > 10) Console.WriteLine("maior que 10");
else Console.WriteLine("menor ou igual a 10");

/* Estrutura de seleção múltipla switch/case */

switch (number)
{
    case > 0:
        Console.WriteLine("maior que 0");
        break;
    case 0:
        Console.WriteLine("igual a zero");
        break;
    default:
        Console.WriteLine("menor que zero");
        break;
}

/* Operadores de comparação no C# */

/*
    >     ---     Maior
    >=    ---     Maior ou igual
    <     ---     Menor
    <=    ---     Menor ou igual
    ==    ---     Igual
    !=    ---     Diferente
*/

/* Operadores lógicos no C# */

/*
    &&     ---     And/E
    ||     ---     Or/Ou
    !      ---     Not/Não
*/

static string IdentifyPolygon(int sideCount)
{
    var name = string.Empty;

    // Atualmente há uma sintaxe de switch mais atualizada
    switch (sideCount)
    {
        case < 3:
            name = "Não é um polígono";
            break;
        case 3:
            name = "Triângulo";
            break;
        case 4:
            name = "Quadrado";
            break;
        case 5:
            name = "Pentágono";
            break;
        default:
            name = "Polígono não identificado";
            break;
    }

    return name;
}

Console.WriteLine(IdentifyPolygon(4));
Console.WriteLine();

/* Identificador de Polígonos no Console */

Console.WriteLine("--- Identificador de Polígonos ---\n");
Console.WriteLine("Informe o número de lados:");
int numberOfSides = Convert.ToInt32(Console.ReadLine());

string polygon = string.Empty;

if (numberOfSides == 3)
{
    polygon = "Triângulo";
}
else if (numberOfSides == 4)
{
    polygon = "Retângulo";
}
else if (numberOfSides == 5)
{
    polygon = "Pentágono";
}
else if (numberOfSides == 6)
{
    polygon = "Hexágono";
}
else
{
    polygon = "Polígono não identificado!";
}

Console.WriteLine($"O polígono é um {polygon}.");

string complexity = string.Empty;

switch (numberOfSides)
{
    case <= 3:
    case 4:
    case 5:
        complexity = "básico";
        break;
    default:
        complexity = "complexo";
        break;
}

Console.WriteLine($"O polígono é {complexity}.");