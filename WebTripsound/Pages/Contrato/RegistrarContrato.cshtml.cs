using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTripsound.Model;

namespace WebTripsound.Pages.Contrato
{
    public class RegistrarContratoModel : PageModel
    {
        Model.ClienteDataAcces objgestion = new ClienteDataAcces();
        public List<Cliente> usuario { get; set; }




        [BindProperty]
        public Model.Evento RegistrarEvento { get; set; }


        Model.EventoDataAccess Registrar = new EventoDataAccess();


        public async Task<IActionResult> OnGet(int id)
        {
          usuario = await objgestion.GetCliente(id);
         
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var registro = RegistrarEvento;
            registro.idusuario = id;
            Registrar.AddCliente(registro);


            string emailorigen = "felix.aparcanap@gmail.com";
            string emaildestino = "felix.aparcanap@gmail.com";
            string con = "";
            string path = @"D:\contrato.pdf";

            MailMessage mailMessage = new MailMessage(emailorigen, emaildestino, "TRIPSOUND", "" +
                "Hola, FELIX se adjunta su contrato " );
            mailMessage.Attachments.Add(new Attachment(path));
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
         
            smtpClient.Credentials = new System.Net.NetworkCredential(emailorigen, con);
            smtpClient.Send(mailMessage);

            return RedirectToPage("Listcontrato");
        }
    }
}
