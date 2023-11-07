/* Funções em C# */

// Uma função é um bloco de código contendo um conjunto de instruções. Também pode ser chamada de Método

/*
    Estrutura de uma função

    Nível de Acessibilidade Retorno Nome (Parâmetros)
    {
        Bloco de código com instruções a serem executadas
    }
*/

/*
    Nível de Acessibilidade

    É opcional. Essa característica é responsável por garantir quem pode ou não acessar a função
    Public: significa que a função pode ser acessada de qualquer lugar do código
    Private: seta a função como privada, só podendo ser acessada na mesma classe em que foi criada
        Se a função não tiver nível de acessibilidade especificado, ela será Private por padrão
*/

/*
    Retorno

    Campo obrigatório. No retorno é indicado o tipo que a função irá retornar, e se irá retornar algo
*/

/*
    Parâmetros

    Campo opcional. Uma função pode ter ou não a presença de parâmetros. Ficam entre parênteses, são separados
    por vírgula e sua estrutura é baseada em tipo do campo e seu nome
*/

/*
    Bloco de Código

    Tudo que fica entre as chaves. É o escopo que vai conter as instruções a serem executadas por aquela função
*/

double CalculateBMI(int weight, double height)
{
    return weight / (height * height);
}

Console.WriteLine($"O resultado do meu IMC é {CalculateBMI(92, 1.67):N2}.");
