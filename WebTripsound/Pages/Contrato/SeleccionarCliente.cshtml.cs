using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Contrato
{
    public class SeleccionarClienteModel : PageModel
    {
        Model.ClienteDataAcces objgestion = new ClienteDataAcces();
        public List<Cliente> usuario { get; set; }
        public async Task<IActionResult> OnGet()
        {
            //if (HttpContext.Session.GetString("nombres") == null)
            //{
            //    return RedirectToPage("./LoginAdm");
            //}
            //else
            //{
            usuario = await objgestion.GetAllUsuario();

            return Page();
            //}
        }
    }
}
