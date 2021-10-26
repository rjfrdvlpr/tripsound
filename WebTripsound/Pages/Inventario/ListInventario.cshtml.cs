using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Inventario
{
    public class ListInventarioModel : PageModel
    {
        Model.InventarioDataAcces objgestion = new InventarioDataAcces();
        public List<Model.Inventario> inven { get; set; }
        public async Task<IActionResult> OnGet()
        {
            //if (HttpContext.Session.GetString("nombres") == null)
            //{
            //    return RedirectToPage("./LoginAdm");
            //}
            //else
            //{
            inven = await objgestion.GetAllInventario();

            return Page();
            //}
        }
    }
}
