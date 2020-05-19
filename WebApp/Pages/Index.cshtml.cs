using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferencePhotoManager;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        PhotoManagerServiceClient serviceClient;
        public string TotalMediaFromBegin { get; set; }
        public string TotalMediaNow { get; set; }
        public string TotalVideos { get; set; }
        public string TotalPhotos { get; set; }
        public string TotalMediaDeleted { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            serviceClient = new PhotoManagerServiceClient();
        }
        public async Task OnGetAsync()
        {

            var media = await serviceClient.GetAllAsync();

            TotalMediaFromBegin = "Total media stored from begin: " + media.Count;
            int mediaNow = (from m in media
                            where m.Deleted == false
                            select m).Count();
            TotalMediaNow = "Total media avaible now: " + mediaNow;
            int totalVideos = (from m in media
                               where m.Deleted == false && m.Type == MediaType.Video
                               select m).Count();
            TotalVideos = "Total videos now: " + totalVideos;
            int totalPhotos = (from m in media
                               where m.Deleted == false && m.Type == MediaType.Photo
                               select m).Count();
            TotalPhotos = "Total photos now: " + totalPhotos;
            int mediaDeleted = (from m in media
                                where m.Deleted
                                select m).Count();
            TotalMediaDeleted = "Total media deleted: " + mediaDeleted;
        }
    }
}
