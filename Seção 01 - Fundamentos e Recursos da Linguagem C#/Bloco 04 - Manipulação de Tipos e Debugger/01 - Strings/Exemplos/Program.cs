/* Strings */

string name = "Aloysius Devadander Abercrombie";
Console.WriteLine($"\"My name is Mud but call me {name}.\"\n");

/* Concat */

string textOne = "\"Hate your enemies, ";
string textTwo = "save your friends, ";
string textThree = "find your place, ";
string textFour = "speak the truth.\"\n";

string concatResult = string.Concat(textOne, textTwo, textThree, textFour);
Console.WriteLine(concatResult);

/* Split */

string emails = "heather.alyse@uol.com;james_bork@gmail.com;davidwilliammaze@yahoo.com";
string[] arrayEmails = emails.Split(";");

foreach (var email in arrayEmails) Console.WriteLine(email);

/* IndexOf */

string band = "Nightmare Cinema";

int? index1 = band.IndexOf("C");
Console.WriteLine($"\nO index de \"C\" é: {index1}.");

int? index2 = band.IndexOf("e", 9);
Console.WriteLine($"O index do segundo \"e\" é: {index2}.");

/* Contains */

List<string> languages = new() { "C#", "JavaScript", "Java", "Python" };

string languageSearch = "PHP";
bool languageExists = languages.Contains(languageSearch);

if (languageExists) Console.WriteLine($"\nEssa linguagem ({languageSearch}) existe no sistema");
else Console.WriteLine($"\nEssa linguagem ({languageSearch}) não existe no sistema");

/* Join */

IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
string numbersText = string.Join(", ", listNumbers);
Console.WriteLine($"\n{{ {numbersText} }}");