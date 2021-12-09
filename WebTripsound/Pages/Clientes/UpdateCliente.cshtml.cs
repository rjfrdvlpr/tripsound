using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Clientes
{
    public class UpdateClienteModel : PageModel
    {
        Model.ClienteDataAcces objgestion = new ClienteDataAcces();
        public List<Cliente> usuario { get; set; }
        [BindProperty]
        public Model.Cliente UpdateCliente { get; set; }


        Model.ClienteDataAcces Registrar = new ClienteDataAcces();


        public async Task<IActionResult> OnGet(int id)
        {
          usuario = await objgestion.GetCliente(id);
         
            return Page();
        }

        public ActionResult OnPost(int id)
        {
            var registro = UpdateCliente;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Registrar.AddUpCliente(registro);
            registro.oldid=id;          

            return RedirectToPage("ListCliente");
        }
    }
}
