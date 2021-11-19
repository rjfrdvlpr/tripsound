using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripsound.Model
{
    public class ClienteDataAcces
    {
        string connectionString = "data source=DESKTOP-631U6UP; database=TRIPSOUND; integrated security = true";


        public async Task<List<Cliente>> GetAllUsuario()
        {
            List<Cliente> lstemployee = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_LISTARCLIENTES", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente employee = new Cliente();
                    employee.id = Convert.ToInt32(rdr["id"].ToString());
                    employee.nombres = rdr["nombres"].ToString();
                    employee.apellidos = rdr["apellidos"].ToString();

                    employee.cel = rdr["celular"].ToString();
                    employee.correo = rdr["correo"].ToString();
                    employee.dni = rdr["dni"].ToString();


                    lstemployee.Add(employee);
                }
                con.Close();
            }


            return lstemployee;
        }

        public void AddCliente(Cliente dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRARCLIENTES", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nom", dato.nombres);
                cmd.Parameters.AddWithValue("@apellidos", dato.apellidos);
                cmd.Parameters.AddWithValue("@cel", dato.cel);
                cmd.Parameters.AddWithValue("@correo", dato.correo);
                cmd.Parameters.AddWithValue("@contraseña", dato.correo);
                cmd.Parameters.AddWithValue("@tipo", dato.idtipousu);
                cmd.Parameters.AddWithValue("@dni", dato.dni);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public async Task<List<Cliente>> GetCliente(int id)
        {
            List<Cliente> lstemployee = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_BUSCARCLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter oidParameter =
                 cmd.Parameters.Add(new SqlParameter("@id",
                     SqlDbType.Int));
                oidParameter.Value = id;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente employee = new Cliente();
                    employee.id = Convert.ToInt32(rdr["id"].ToString());
                    employee.nombres = rdr["nombres"].ToString();
                    employee.apellidos = rdr["apellidos"].ToString();

                    employee.cel = rdr["cel"].ToString();
                    employee.correo = (rdr["correo"].ToString());
                    employee.contrasenia = (rdr["contra"].ToString());
                    employee.dni = (rdr["DNI"].ToString());


                    lstemployee.Add(employee);
                }
                con.Close();
            }


            return lstemployee;
        }

    }

    public class Cliente
    {
        public int id { get; set; }

        [Required (ErrorMessage ="Este campo es obligatorio")]
        [MinLength(3,ErrorMessage ="Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"^[a-zA-Z ]+$",ErrorMessage ="Solo letras")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Solo letras")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(9, ErrorMessage = "Celular debe de tener 9 dígitos")]
        [MaxLength(9, ErrorMessage = "Celular debe de tener 9 dígitos")]
        public string cel { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(5, ErrorMessage = "Minimo 3 letras")]      
     
       [EmailAddress(ErrorMessage = "Debe de tener un formato correcto el correo")]
        public string correo { get; set; }

        public string contrasenia { get; set; }
        public string idtipousu { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        [MaxLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        public string dni { get; set; }
    }
}
