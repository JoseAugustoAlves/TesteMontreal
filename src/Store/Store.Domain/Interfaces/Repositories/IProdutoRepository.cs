using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarComImagem();

        IEnumerable<Produto> BuscarComImagemById(int id);

        IEnumerable<Produto> BuscarFilhos(int id);

    }
}
