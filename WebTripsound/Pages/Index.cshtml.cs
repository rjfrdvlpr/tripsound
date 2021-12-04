using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTripsound.Model;


namespace WebTripsound.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Model.User RegistrarPersonal { get; set; }

        Model.UserAccess Registrar = new UserAccess();


        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            var registro = RegistrarPersonal;
            if (!ModelState.IsValid)
            {
                return Page();
            }
       
            Registrar.AddPersonal(registro);
            return RedirectToPage("Listpersonal");
         

        }
    }
}
