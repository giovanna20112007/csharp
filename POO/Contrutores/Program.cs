using Construtores.Classes;

Veículo carro1 = new Veículo("Ford", "ka", 200, "Vermelho");
Veículo carro2 = new Veículo("Ford", "Mustang", 1995, "azul" );


//Exibir dados 

carro1.ExibirDados();
carro2.ExibirDados();


// comecar os testes dos jogos

Jogo jogo1 = new Jogo("Detroit Become Human", 2018, "Ação e aventura", 100.00f);
Jogo jogo2 = new Jogo("The Last of Us", 2013, "Ação e aventura", 80.00f);

//Exibir dados 

jogo1.ExibirDadosJogos();
jogo2.ExibirDadosJogos();

//comecar os testes dos alunos

Aluno aluno1 = n/ew Aluno("giovanna", 123, 16);
Aluno aluno2 = new Aluno("isabelly", 456, 17);

//exibir dados 

aluno1.ExibirDadosAlunos();
aluno2.ExibirDadosAlunos();
