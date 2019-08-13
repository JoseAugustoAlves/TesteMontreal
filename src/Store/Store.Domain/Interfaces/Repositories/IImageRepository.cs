using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces.Repositories
{
    public interface IImageRepository : IRepositoryBase<Image>
    {
        IEnumerable<Image> BuscarImagesPorProduto(int id);
    }
}
