using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.aprendizagem
{
    public abstract class veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int potencia { get; set; }
        public int qtdpassageiros { get; set; }
    }
}