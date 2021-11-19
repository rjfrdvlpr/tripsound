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
            registro.idtipousu = "1";
            Registrar.AddCliente(registro);
            

            string emailorigen = "jampierts@gmail.com";
            string emaildestino = registro.correo;
            string con = "data source=DESKTOP-631U6UP; database=TRIPSOUND; integrated security = SSPI";

            return RedirectToPage("ListCliente");


        }
    }
}
