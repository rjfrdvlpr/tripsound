using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Personal
{
    public class ListPersonalModel : PageModel
    {

        Model.PersonalDataAccess objgestion = new PersonalDataAccess();
        public List<Model.Personal> pers { get; set; }
        public async Task<IActionResult> OnGet()
        {
            //if (HttpContext.Session.GetString("nombres") == null)
            //{
            //    return RedirectToPage("./LoginAdm");
            //}
            //else
            //{
            pers = await objgestion.GetAllPersonal();

            return Page();
            //}
        }
    }
}
