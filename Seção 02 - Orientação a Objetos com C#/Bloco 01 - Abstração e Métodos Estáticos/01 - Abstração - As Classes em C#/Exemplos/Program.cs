using Exemplos;

// var rocket1 = new Rocket();
// var rocket2 = new Rocket();

// rocket1.Name = "Apollo 11";
// rocket2.Name = "Falcon 9";

// Rocket rocket1 = new("Apollo 11");
// Rocket rocket2 = new("Falcon 9");

Rocket rocket1 = new("Apollo 11", 2300000000000);
Rocket rocket2 = new("Falcon 9", 90000000);

Console.WriteLine(rocket1.Name);
Console.WriteLine(rocket2.Name);

rocket1.FuelAsPercentage = 85;
rocket2.FuelAsPercentage = 60;

Console.WriteLine($"A {rocket1.Name}, que terá seu lançamento com {rocket1.FuelAsPercentage}% de sua capacidade total de combustível, teve seu custo no total de $ {rocket1.Price}.");
Console.WriteLine($"A {rocket2.Name}, que terá seu lançamento com {rocket2.FuelAsPercentage}% de sua capacidade total de combustível, teve seu custo no total de $ {rocket2.Price}.");