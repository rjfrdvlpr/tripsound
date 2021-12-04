using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Personal
{
    public class AgregarAdminModel : PageModel
    {

        [BindProperty]
        public bool Eliminar { get; set; }


        [BindProperty]
        public Model.Personal RegistrarPersonal { get; set; }

        Model.PersonalDataAccess Registrar = new PersonalDataAccess();
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
       
            Registrar.AddAdmin(registro);
            return RedirectToPage("Listpersonal");
         

        }
    }
}
