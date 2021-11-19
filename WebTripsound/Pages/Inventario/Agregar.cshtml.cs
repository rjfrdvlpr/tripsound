using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Inventario
{
    public class AgregarModel : PageModel
    {
        [BindProperty]
        public Model.Inventario RegistrarInventario { get; set; }


        Model.InventarioDataAcces Registrar = new InventarioDataAcces();
        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {
            var registro = RegistrarInventario;
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            Registrar.AddInventario(registro);
            return RedirectToPage("ListInventario");


        }
    }
}
