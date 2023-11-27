using Exemplos;

// var rocket1 = new Rocket();
// var rocket2 = new Rocket();

// rocket1.Name = "Apollo 11";
// rocket2.Name = "Falcon 9";

Rocket rocket1 = new("Apollo 11");
Rocket rocket2 = new("Falcon 9");

Console.WriteLine(rocket1.Name);
Console.WriteLine(rocket2.Name);