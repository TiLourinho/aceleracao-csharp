/* Estruturas de repetição */

/* Instruções While e Do/While */

// while

/* 
    while (condição)
    {
    // bloco de código a ser executado quando a condição for VERDADEIRA
        comandos;
    }
*/

var count1 = 1;

while (count1 <= 10)
{
    Console.WriteLine($"count {count1}");
    count1 += 1;
}

// do/while

var count2 = 1;

do
{
    Console.WriteLine($"count {count2}");
    count2 += 1;
}
while (count2 <= 10);
// A instrução while testa a variável antes de executar o bloco de instruções.
// Já a intrução do/while executa o bloco e testa a variável depois.

/* Instruções For e Foreach */

// for

for (int count = 0; count < 3; count++)
{
    Console.WriteLine($"número: {count}");
}

// foreach

/*
    foreach (tipo elemento in coleção)
    {
        // comandos;
    }
*/

string[] names = new string[] { "Odin", "Thor", "Loki" };

foreach (var name in names)
{
    Console.WriteLine(name);
}

// Instruções de uma única linha

// No C#, um bloco de instrução é sempre escrito entre chaves {} para delimitar seu contexto
// Porém, o uso das chaves não é obrigatório para definir uma instrução de uma linha como ocorre em: for, foreach e while

// for
for (int count = 0; count < 5; count++)
    Console.WriteLine(count);

// foreach
int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;

foreach (var number in numbers)
    sum += number;

Console.WriteLine(sum);

// while
static bool CloseConnection()
{
    return true;
}

var isClosed = false;

while (!isClosed)
    isClosed = CloseConnection();

Console.WriteLine(isClosed);

/* Instruções break e continue */

// break

// É utilizada para interromper a execução de um laço de repetição (for, foreach, do/while, e while)

string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
string[] students = new string[] { "Ellie", "Joel", "Abby" };

foreach (var teacher in teachers)
{
    Console.WriteLine($"Professor: {teacher}. Estudante:");
    foreach (var student in students)
    {
        if (teacher == student)
        {
            break;
        }

        Console.WriteLine(student);
    }
}
// Quando a variável teacher for igual a student o código interromperá somente a execução do laço da variável students
// A linha "Console.WriteLine(student);" não será executada e a execução continuará percorrendo o laço mais externo, da variável teacher

// continue

// É utilizada para saltar uma iteração de um laço de repetição (for, foreach, do/while, e while)

int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2 };
var count3 = 0;

foreach (var vote in votes)
{
    if (vote > 3)
    {
        continue;
    }

    count3 += 1;
}

Console.WriteLine($"{count3} votos válidos");
// O foreach percorrerá todos os itens do array verificando se o valor do mesmo é maior que três
// Se for, fará uso da instrução continue para saltar a iteração do laço. Dessa forma a variável count só será incrementada para votos válidos

/* Fixação */

int numberOfPeople = 0;
int numberOfChildren = 0;

int age = 99;

while (age > 0)
{
    Console.WriteLine("Informe a idade da pessoa. Informe 0 para sair!");
    age = Convert.ToInt32(Console.ReadLine());

    if (age == 0)
        break;

    numberOfPeople += 1;

    if (age < 18)
        numberOfChildren += 1;
}

double rateOfChildren = 0;

if (numberOfPeople > 0)
{
    rateOfChildren = 100 * numberOfChildren / numberOfPeople;
}

Console.WriteLine($"Existe {rateOfChildren:N2}% de crianças");