/* Tipos avançados */

using Exemplos;

GenericList<string> listStr = new();
listStr.Add("Olá");
listStr.Add("Hello");
listStr.Add("Hola");
listStr.Add("Hallo");

listStr.Print();

/* Tipos anônimos */

var anonimousType = new { Amount = 42, Message = "Olá", Value = 3.95 };

Console.WriteLine(anonimousType.Amount);
Console.WriteLine(anonimousType.Message);
Console.WriteLine(anonimousType.Value);
