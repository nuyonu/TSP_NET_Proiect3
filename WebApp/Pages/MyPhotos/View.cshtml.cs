using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhotoManager;

namespace WebApp.Pages.MyPhotos
{
    public class ViewModel : PageModel
    {
        PhotoManagerServiceClient serviceClient = new PhotoManagerServiceClient();
        public MediaDTO Media { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
                return NotFound();
            Media = await serviceClient.GetMediaByIdAsync(Guid.Parse(id));
            if (Media == null)
                return NotFound();
            return Page();
        }

        public async Task<string> GetBase64(string path)
        {
            return "data:image/png;base64," + await serviceClient.ConvertToBase64Async(path);
        }
        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
                return NotFound();
            Media = await serviceClient.GetMediaByIdAsync(Guid.Parse(id));
            if (Media == null)
                return NotFound();
            await serviceClient.DeleteMediaByIdAsync(Guid.Parse(id));
            return Redirect("/MyPhotos/Index");
        }
    }
}