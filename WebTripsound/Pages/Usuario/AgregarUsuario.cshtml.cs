using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Usuario
{
    public class AgregarUsuarioModel : PageModel
    {

        [BindProperty]
        public bool Eliminar { get; set; }


        [BindProperty]
        public Model.Users RegistrarUsuario { get; set; }

        Model.UserDataAccess Registrar = new UserDataAccess();
        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {
            var registro = RegistrarUsuario;
            if (!ModelState.IsValid)
            {
                return Page();
            }
       
            Registrar.AddUsuario(registro);
            return RedirectToPage("ListUsuario");
         

        }
    }
}
