﻿using Estoque.Domain.Entities;
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
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly ApplicationDbContext _context;

        public EstoqueRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public async Task<Item> GetItemPorId(int id)
        {
            var resultado = await _context.Itens.FirstAsync(i => i.IdItem == id);
            return resultado;

        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            var resultado =  await _context.Itens.ToListAsync();
            return resultado;
        }

        public IQueryable<Item> GetItensFiltro(string filter, int tipo, int filial)
        {
            var resultado = _context.Itens.AsNoTracking().AsQueryable();

            if (string.IsNullOrEmpty(filter) == false || filial != 0)
                resultado = resultado.Where(r => r.DescItem.Contains(filter) && r.IdFilial == filial);

            if (!string.IsNullOrEmpty(filter))
                resultado = resultado.Where(r =>  r.DescItem.Contains(filter));

            if (filial != 0)
                resultado = resultado.Where(r => r.DescItem.Contains(filter));

            return resultado;
        }
    }
}
