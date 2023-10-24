/* A estrutura Array */

// Os Arrays em C# são parecidos com os Arrays em Javascript. O que os diferencia é que, em C#,
// por se tratar de uma linguagem Fortemente Tipada, os dados são armazenados de apenas um tipo definido previamente

/*
    <Tipo>[] <Nome do Array>;

    int[] myFirstArray;
*/

// Inicializando o array com 5 posições

int[] myFirstArray;
myFirstArray = new int[5];

Console.WriteLine($"[{string.Join(", ", myFirstArray)}]");
// Quando utilizamos esta forma para instanciar um Array de inteiros, todas as posições do Array iniciam com 0, o valor padrão para o int

// Inicialização direta

int[] mySecondArray = new int[3];

Console.WriteLine($"[{string.Join(", ", mySecondArray)}]");

// Inicialização com valores pré-definidos

int[] myThirdArray = new int[] { 1, 2, 3, 4, 5 };

int[] myFourthArray = { 6, 7, 8, 9, 10 };

Console.WriteLine($"[{string.Join(", ", myThirdArray)}]");
Console.WriteLine($"[{string.Join(", ", myFourthArray)}]");

// Inicialização para outros tipos

string[] myFifthArray = new string[] { "Vamo", "que", "vamo!" };

string[] mySixthArray = { "Foguete", "não", "tem", "ré!" };

Console.WriteLine($"{string.Join(" ", myFifthArray)}");
Console.WriteLine($"{string.Join(" ", mySixthArray)}");

// Utilizando Arrays

int[] mySeventhArray = new int[4] { 6, 9, 5, 8 };

Console.WriteLine(mySeventhArray[3]);
