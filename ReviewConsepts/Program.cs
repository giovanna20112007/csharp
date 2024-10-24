// variaveis e tipo de dados

// clw
// Console.WriteLine($"ola,digite seu nome: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"agora digite o seu sobrenome: ");
// string sobrenome = Console.ReadLine();

// Console.WriteLine("qual e a sua idade");
// int idade = int.Parse("")(Console.ReadLine()!);


Console.WriteLine(@"

+---------------------------------------------+
|           progrma de cadastro               |
+---------------------------------------------+
|                  ola :)                     |
|Por favor digite seus dados a baixo          |
+---------------------------------------------+");

Console.WriteLine(); //linha em vazia

//pedir os dados de cadastro

//nome
Console.WriteLine($"Digite seu nome"); 
string nome = Console.ReadLine()!;

//sobrenome
Console.WriteLine($"Digite seu sobrenome"); 
string sobrenome = Console.ReadLine()!;

//e-mail
Console.WriteLine($"Digite qual e o seu e-mail?"); 
string  email = Console.ReadLine()!;

//cpf
Console.WriteLine($"Digite qual seu cpf"); 
int  cpf =int.Parse(Console.ReadLine()!);

//endereco
Console.WriteLine($"Digite endereco"); 
string estadocivil = Console.ReadLine()!;

//telefone
Console.WriteLine($"Digite seu telefone"); 
int telefone= int.Parse (Console.ReadLine()!);

//idade
Console.WriteLine($"Digite a sua idade"); 
int idade =int.Parse(Console.ReadLine()!);

int anoAtual = DateTime.Now.Year;
int anoNascimento = anoAtual - idade;


Console.WriteLine(@$"obrigado:
-{nome} {sobrenome}
-{idade} {anoNascimento}
- {email}
-{telefone}
-{cpf}
-{estadocivil}");












// estruturas condicionais
// lacos de repeticao
// arrays
