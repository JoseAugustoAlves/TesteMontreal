using Store.Application.Interface;
using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Store.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarComImagem()
        {
            return _produtoService.BuscarComImagem();
        }

        public IEnumerable<Produto> BuscarComImagemById(int id)
        {
            return _produtoService.BuscarComImagemById(id);
        }

        public IEnumerable<Produto> BuscarFilhos(int id)
        {
            return _produtoService.BuscarFilhos(id);
        }
    }
}
