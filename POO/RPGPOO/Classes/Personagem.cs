using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPOO.Classes
{
    public class Personagem
    {
        public string? Nome;
        public int Idade;
        public string? Armadura;
        public string? IA;

        public void Atacar()
        {
            Console.WriteLine($"o personagem atacou!");
            
        }
        public void Defender()
        {
            Console.WriteLine($"o personagem defendeu!");
            
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"o personagem atacou!");
            
        }
    }
}