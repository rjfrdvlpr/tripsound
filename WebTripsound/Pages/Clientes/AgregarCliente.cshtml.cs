using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Clientes
{
    public class AgregarClienteModel : PageModel
    {
        [BindProperty]
        public Cliente RegistrarCliente { get; set; }


        Model.ClienteDataAcces Registrar = new ClienteDataAcces();
        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {
            var registro = RegistrarCliente;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            registro.contrasenia = "";
            registro.idtipousu = "2";
            Registrar.AddCliente(registro);
            

          
            return RedirectToPage("ListCliente");


        }
    }
}
