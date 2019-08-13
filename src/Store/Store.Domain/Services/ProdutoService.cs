using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarComImagem()
        {
            return _produtoRepository.BuscarComImagem();
        }

        public IEnumerable<Produto> BuscarComImagemById(int id)
        {
            return _produtoRepository.BuscarComImagemById(id);
        }

        public IEnumerable<Produto> BuscarFilhos(int id)
        {
            return _produtoRepository.BuscarFilhos(id);
        }
    }
}
