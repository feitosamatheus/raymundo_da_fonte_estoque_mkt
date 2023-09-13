using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Repository
{
    public class InfraRepository : IInfraRepository
    {
        private readonly ApplicationDbContext _context;

        public InfraRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<IEnumerable<Filial>> GetFiliais()
        {
            var resultado = await _context.Filiais.ToListAsync();
            return resultado;
        }
    }
}
