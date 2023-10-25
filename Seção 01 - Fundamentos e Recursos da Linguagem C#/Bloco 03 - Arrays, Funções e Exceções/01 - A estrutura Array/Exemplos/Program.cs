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

/* Arrays multidimensionais */

int[,] multidimensionalArray1 = new int[2, 3];

Console.WriteLine(multidimensionalArray1[1, 2]);

// Inicialização com valores pré-definidos

int[,] multidimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

Console.WriteLine(multidimensionalArray2[1, 2]);

// Jagged Array

// Somente instanciamos o array mais externo neste primeiro passo
// Repare que apenas o primeiro colchetes contém números
int[][] jaggedArray1 = new int[4][];

// Agora precisamos instanciar um novo array para cada posição do array mais externo
jaggedArray1[0] = new int[4] { 6, 6, 6, 6 };
jaggedArray1[1] = new int[3] { 6, 6, 6 };
jaggedArray1[2] = new int[5] { 6, 6, 6, 6, 6 };
jaggedArray1[3] = new int[2] { 6, 6 };

// Jagged Array com três dimensionais

int[,,] multiDimensionalArray3 = new int[2, 3, 3];

int[,,] multiDimensionalArray4 = { { { 1, 2 }, { 3, 4 } },{ { 5, 6 }, { 7, 8 } } };

// O array jagged precisa ser instanciado em partes. Primeiro instanciamos o array com 3 dimensões
int[][][] jaggedArray2 = new int[6][][];

// Depois vamos instanciar a primeira linha do array, recebendo um novo array jagged de 2 dimensões
jaggedArray2[0] = new int[3][];

// E assim finalmente podemos instanciar a primeira coluna da primeira linha do array com um novo array de 1 dimensão
jaggedArray2[0][0] = new int[4] { 1, 2, 3, 4 };