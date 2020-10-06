using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Data;
using Web.Models.Products;
using Web.Services;

namespace Web.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;
        private readonly IUploadServices upload;

        public CreateModel(Web.Data.ApplicationDbContext context, IUploadServices upload)
        {
            _context = context;
            this.upload = upload;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Beer Beer { get; set; }

        [TempData]
        public string UploadedFileName { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        [TempData]
        public string UploadedFileLink { get; private set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Beer.Add(Beer);
            await _context.SaveChangesAsync();

            UploadedFileName = Image?.FileName;
            using var stream = Image.OpenReadStream();
            UploadedFileLink = await upload.UploadFile(Image.FileName, stream);
            return RedirectToPage("./Index");
        }
    }
}
