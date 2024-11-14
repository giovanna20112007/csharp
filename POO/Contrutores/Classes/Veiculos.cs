using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrutores.Classes
{
    public class Veiculos
    {
        public string marca {get; set; }
        public string modelo { get; set; }
        public int ano  { get; set; }  
        public string cor { get; set; } 
        public void exibirdados ()
        {
            Console.WriteLine(@$"
            marca:{marca}
            modelo:{modelo}
            ano:{ano}
            cor:{cor}
            ");
        }

















    }


}