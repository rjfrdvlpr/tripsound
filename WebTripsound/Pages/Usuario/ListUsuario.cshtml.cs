using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Usuario
{
    public class ListUsuariolModel : PageModel
    {

        Model.UserDataAccess objgestion = new UserDataAccess();
        public List<Model.Users> pers { get; set; }
        public async Task<IActionResult> OnGet()
        {
            //if (HttpContext.Session.GetString("nombres") == null)
            //{
            //    return RedirectToPage("./LoginAdm");
            //}
            //else
            //{
            pers = await objgestion.GetAllUsuario();

            return Page();
            //}
        }
    }
}
