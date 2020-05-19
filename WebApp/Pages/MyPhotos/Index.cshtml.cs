using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using ServiceReferencePhotoManager;

namespace WebApp.Pages.MyPhotos
{
    public class IndexModel : PageModel
    {
        PhotoManagerServiceClient serviceClient = new PhotoManagerServiceClient();
        public List<MediaDTO> Media { get; set; } = new List<MediaDTO>();

        [BindProperty(SupportsGet = true)]
        public string ToSearch { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByPeople { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByDate { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByEvent { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByTags { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByLocation { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool ByDescription { get; set; }
        public async Task OnGetAsync()
        {
            if (ToSearch == null)
                ToSearch = "";
            Media = (await serviceClient.GetAllWhereAsync(ToSearch, ByDate, ByEvent, ByPeople, ByLocation, ByTags, ByDescription)).OrderBy(x => x.Name).ToList();
        }
    }
}
