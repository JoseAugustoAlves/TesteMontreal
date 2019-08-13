using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces.Services
{
    public interface IImageService : IServiceBase<Image>
    {
        IEnumerable<Image> BuscarImagesPorProduto(int id);
    }
}
