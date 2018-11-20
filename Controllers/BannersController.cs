using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BannerApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace BannerApi.Controllers
{
    [Route("api/[controller]")]
    public class BannersController : Controller
    {
        private readonly Banner[] banners = new Banner[]
        {
            new Banner { Id = "banner1", Url = "https://picsum.photos/1024/200/?random/1"},
            new Banner { Id = "banner2", Url = "https://picsum.photos/1024/200/?random/2"},
            new Banner { Id = "banner3", Url = "https://picsum.photos/1024/200/?random/3"},
            new Banner { Id = "banner4", Url = "https://picsum.photos/1024/200/?random/4"},
            new Banner { Id = "banner5", Url = "https://picsum.photos/1024/200/?random/5"},
            new Banner { Id = "banner6", Url = "https://picsum.photos/1024/200/?random/6"},
        };


        // GET: api/banners
        [HttpGet]
        public IEnumerable<Banner> GetAllBanners()
        {
            return banners;
        }
    }
}
