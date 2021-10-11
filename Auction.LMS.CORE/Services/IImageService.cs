using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Services
{
   public interface IImageService
    {
        public List<Images> GetAllImages();

        public bool InsertImages(Images images);
        public bool UpdateImages(Images images);
        public bool DeleteImages(int id);
        public Images GetImagesById(int id);
    }
}
