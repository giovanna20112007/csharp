// int = senha (1234);

// tipodedado nomevariavel = valor;

int Senha = 1234;

Console.WriteLine($"Digite sua senha:");
int confirmarSenha = int.Parse(Console.ReadLine()!);

if(Senha == confirmarSenha){
    Console.WriteLine("ACESSO PERMITIDO");
    
}else {
    Console.WriteLine($"ACESSO NEGADO");  
}

 
