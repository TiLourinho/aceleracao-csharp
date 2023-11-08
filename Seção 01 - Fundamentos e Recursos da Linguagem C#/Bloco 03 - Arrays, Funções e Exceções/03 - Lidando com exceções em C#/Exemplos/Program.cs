/* Lidando com exceções em C# */

using Exemplos;

try
{
    static int DivideNumbers(int numberOne, int numberTwo)
    {
        return numberOne / numberTwo;
    }

    int numberOne = 20;
    int numberTwo = 2;
    var division = DivideNumbers(numberOne, numberTwo);

    Console.WriteLine($"O resultado da divisão de {numberOne} por {numberTwo} é: {division}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}

/*
    Try-catch

    try
    {
        // Código a ser executado
    }
    catch
    {
        // Caso aconteça uma exceção no código dentro do bloco try, aqui vai ser requisitado!
    }
*/

string[] chemicalProduct = new string[3];

try
{
 chemicalProduct[0] = "Cálcio";
 chemicalProduct[1] = "Zinco";
 chemicalProduct[2] = "Hidrazina";
 chemicalProduct[3] = "Anilina"; 
}
catch (IndexOutOfRangeException) 
{
 Console.WriteLine("Erro Específico, sabemos exatamente o motivo do erro.");
}
catch (Exception)
{
 Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
}

/*
    Finally

    try
    {
        // Código a ser executado
    }
    catch
    {
        // Caso aconteça uma exceção no código dentro do bloco try, aqui vai ser requisitado!
    }
    finally
    {
        // Aqui sempre vai ser chamado
    }
*/

static bool VerifyProductValidity(int productId)
{
    Database db = new();

    try
    {
        db.Open();
        var product = db.GetProduct(productId);

        if (product == null)
        {
            throw new NullReferenceException("Produto não encontrado.");
        }

        return product.IsNormalized();
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine(ex.Message);
        throw;
    }
    finally
    {
        db.Close();
    }
}

VerifyProductValidity(43876159);