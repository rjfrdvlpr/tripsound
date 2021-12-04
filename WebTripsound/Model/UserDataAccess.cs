using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripsound.Model
{
    public class UserDataAccess
    {
        string connectionString = "data source=localhost; database=TRIPSOUND; user id=SA; password=SQL-2021";

        public async Task<List<Users>> GetAllUsuario()
        {
            List<Users> lstemployee = new List<Users>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_LISTARUSERST", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Users employee = new Users();
                    employee.Nombre = rdr["nombres"].ToString();
                    employee.Apellidos = rdr["apellidos"].ToString();
                    employee.Cel = (rdr["cel"].ToString());
                    employee.Correo = (rdr["correo"].ToString());
                    employee.Dni = (rdr["DNI"].ToString());

                    lstemployee.Add(employee);
                }
                con.Close();
            }


            return lstemployee;
        }
       
        public void AddUsuario(Users dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRARUSERST", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@correo", dato.Correo);                
                cmd.Parameters.AddWithValue("@contraseña", dato.Pass);
                cmd.Parameters.AddWithValue("@dni", dato.Dni);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        
    }
    public class Users
    {

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe de tener un formato correcto el correo")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(6, ErrorMessage = "Minimo caracteres")]
        [MaxLength(20, ErrorMessage = "Max 20 caracteres")]
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

     
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        [MaxLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        public string Dni { get; set; }
        
        public string Cel { get; set; }

        
    }
}
