using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarComImagem();

        IEnumerable<Produto> BuscarComImagemById(int id);

        IEnumerable<Produto> BuscarFilhos(int id);
    }
}
