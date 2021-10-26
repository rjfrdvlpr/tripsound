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


            string emailorigen = "felix.aparcanap@gmail.com";
            string emaildestino = registro.correo;
            string con = "";

            MailMessage mailMessage = new MailMessage(emailorigen, emaildestino,"TRIPSOUND", "" +
                "Hola, "+registro.nombres+" su contraseña de tripsound es felix123");
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
          
            smtpClient.Credentials = new System.Net.NetworkCredential(emailorigen, con);
            smtpClient.Send(mailMessage);

            return RedirectToPage("ListContrato");


        }
    }
}
