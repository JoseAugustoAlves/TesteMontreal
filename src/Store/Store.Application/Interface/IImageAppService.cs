using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Application.Interface
{
    public interface IImageAppService : IAppServiceBase<Image>
    {
        IEnumerable<Image> BuscarImagesPorProduto(int id);
    }
}
