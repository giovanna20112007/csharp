// See https://aka.ms/new-console-template for more information
using PilaresPOO.Classes.aprendizagem;

pessoa giovanna = new pessoa();
giovanna.nome = "giovanna";

Console.WriteLine($"{giovanna.nome} nasceu com {giovanna.idade} anos");

aluno senhorini = new luno();
senhorini.idade = 16;
senhorini.Matricula = 12345;
senhorini.curso = "dev";
senhorini.media = 7.9f;

Console.WriteLine($"idade: {senhorini.idade}");
Console.WriteLine($"aluno: {senhorini.Matricula}");
Console.WriteLine($"curso: {senhorini.curso}");
Console.WriteLine($"media: {senhorini.media}");


