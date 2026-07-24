using System;
using System.Collections.Generic;
using System.Text;
using CartadeSina.Domain.Entities;

namespace CartadeSina.Domain.Interfaces
{
    public interface IPersonagemRepository
    {
        Task AdicionarPersonagemAsync(Personagem personagem);
        Task<Personagem?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Personagem>> ObterTodosAsync();
    }
}
