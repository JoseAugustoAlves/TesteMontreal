using Store.Application.Interface;
using Store.Domain.Entities;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Application
{
    public class ImageAppService : AppServiceBase<Image>, IImageAppService
    {
        private readonly IImageService _imageService;

        public ImageAppService(IImageService imageService)
            : base(imageService)
        {
            _imageService = imageService;
        }

        public IEnumerable<Image> BuscarImagesPorProduto(int id)
        {
            return _imageService.BuscarImagesPorProduto(id);
        }

    }
}
