//cria um array tamanho 3 (de 0 a 2)
string[] carros = new string [3];

Console.WriteLine($"Digite o nome do carro a ser cadastrado");
carros [0] = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro a ser cadastrado");
carros [1] = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro a ser cadastrado");
carros [2]= Console.ReadLine()!;

Console.WriteLine($"Os carros cadastrados são: {carros [0]}, {carros [1]}, {carros [2]}");
