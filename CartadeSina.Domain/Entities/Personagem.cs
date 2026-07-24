using System;
using System.Collections.Generic;
using System.Text;

namespace CartadeSina.Domain.Entities
{
    public class Personagem
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public bool Sina { get; private set; } = false;
        public int DanoDor { get; private set; }
        public int DanoVida { get; private set; }
        public int Defesa { get; private set; }
        public int Iniciativa { get; private set; }

        public Personagem(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Sina = false;
            DanoDor = 0;
            DanoVida = 0;
            Defesa = 5;
            Iniciativa = 0;
        }
    }
}
