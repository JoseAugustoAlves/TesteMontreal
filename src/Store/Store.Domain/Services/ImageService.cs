using Store.Domain.Entities;
using Store.Domain.Interfaces.Repositories;
using Store.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Services
{
    public class ImageService : ServiceBase<Image>, IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
            : base(imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public IEnumerable<Image> BuscarImagesPorProduto(int id)
        {
            return _imageRepository.BuscarImagesPorProduto(id);
        }
    }
}
