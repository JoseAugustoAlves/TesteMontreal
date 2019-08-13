using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Infra.Data.Repositories
{
    class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public IEnumerable<Image> BuscarImagesPorProduto(int id)
        {

            return db.Images
                .Where(i => i.ProdutoId == id);

        }
    }
}
