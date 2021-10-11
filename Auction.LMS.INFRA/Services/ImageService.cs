using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class ImageService : IImageService
    {
        private readonly IImagesRepoisitory imagesRepoisitory;
        public ImageService(IImagesRepoisitory imagesRepoisitory)
        {
            this.imagesRepoisitory = imagesRepoisitory;
        }
        public bool DeleteImages(int id)
        {
            return imagesRepoisitory.DeleteImages(id);
        }

        public List<Images> GetAllImages()
        {
            return imagesRepoisitory.GetAllImages();
        }

        public Images GetImagesById(int id)
        {
            return imagesRepoisitory.GetImagesById(id);
        }

        public bool InsertImages(Images images)
        {
            return imagesRepoisitory.InsertImages(images);
        }

        public bool UpdateImages(Images images)
        {
            return imagesRepoisitory.UpdateImages(images);
        }
    }
}
