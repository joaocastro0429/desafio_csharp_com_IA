string nome = "João";
int idade = 20;

// dinâmica
var nome2 = "Marcos";
var idade2 = 20; // agora sim existe idade2

var resultado1 = Convert.ToString(idade2) + " - " + nome2;
var resultado2 = idade2.ToString() + " - " + nome2;
var resultado3 = int.Parse("2") + idade2;

Console.WriteLine(resultado1);
Console.WriteLine(resultado2);
Console.WriteLine(resultado3);