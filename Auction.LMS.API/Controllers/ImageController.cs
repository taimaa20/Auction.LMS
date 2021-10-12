using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService imageService;
        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }
        [HttpGet]
        public List<Images> GetAllImages()
        {
            return imageService.GetAllImages();
        }

        [HttpPost]
        public bool InsertImages([FromBody]Images images)
        {
            return imageService.InsertImages(images);
        }

        [HttpPut]
        public bool UpdateImages(Images images)
        {
            return imageService.UpdateImages(images);
        }

        [HttpDelete("delete/{id}")]
        public bool DeleteImages(int id)
        {
            return imageService.DeleteImages(id);
        }

        [HttpGet]
        [Route("getimagebyid/{id}")]
        public Images GetImagesById(int id)
        {
            return imageService.GetImagesById(id);
        }
    }
}
