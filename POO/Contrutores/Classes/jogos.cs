using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome { get; set; }

        public int lancamento { get; set; }

        public string genero { get; set; }

        public float preco { get; set; }

        public Jogo (string nm, int lnc, string gnr, float prc)
        {
            nome = nm;
            lancamento = lnc;
            genero = gnr;
            preco = prc;
        }
        public void ExibirDadosJogos()
        {
            Console.WriteLine(@$"
            Nome: {nome}
            Lançamento: {lancamento}
            Gênero: {genero}
            Preço: {preco}
            ");
            
        }
    }
}
