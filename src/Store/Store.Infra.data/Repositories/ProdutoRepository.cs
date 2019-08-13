using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarComImagem()
        {
            return db.Produtos
                .Include("Images")
                .ToList();
        }


        public IEnumerable<Produto> BuscarComImagemById(int id)
        {
            return db.Produtos
                .Include("Images")
                .Where(p => p.Id == id);
        }

        public IEnumerable<Produto> BuscarFilhos(int id)
        {
            return db.Produtos
                .Include("Images")
                .Where(p => p.IdProdutoPai == id);
        }


    }
}
