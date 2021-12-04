using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripsound.Model
{
    public class UserAccess
    {
        string connectionString = "data source=localhost; database=TRIPSOUND; user id=SA; password=SQL-2021";

        public async Task<List<Personal>> GetAllPersonal()
        {
            List<Personal> lstemployee = new List<Personal>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_LISTARPERSONAL", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Personal employee = new Personal();
                    employee.Nombre = rdr["nombre"].ToString();
                    employee.Apellidos = rdr["apellidos"].ToString();
                    employee.Cel = (rdr["celular"].ToString());
                    employee.Cargo = (rdr["cargo"].ToString());
                    employee.Correo = (rdr["correo"].ToString());
                    employee.Dni = (rdr["dni"].ToString());

                    lstemployee.Add(employee);
                }
                con.Close();
            }


            return lstemployee;
        }

        public void AddPersonal(User dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRARPERSONAL", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nom", dato.Nombre);
                cmd.Parameters.AddWithValue("@ape", dato.Apellidos);
                cmd.Parameters.AddWithValue("@nacimie", dato.Fecha);
                cmd.Parameters.AddWithValue("@dni", dato.Dni);
                cmd.Parameters.AddWithValue("@cel", dato.Cel);
                cmd.Parameters.AddWithValue("@correo", dato.Correo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void AddAdmin(User dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRARADMIN", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nom", dato.Nombre);
                cmd.Parameters.AddWithValue("@ape", dato.Apellidos);
                cmd.Parameters.AddWithValue("@nacimie", dato.Fecha);
                cmd.Parameters.AddWithValue("@dni", dato.Dni);
                cmd.Parameters.AddWithValue("@cel", dato.Cel);
                cmd.Parameters.AddWithValue("@correo", dato.Correo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void AddDJ(User dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRARDJ", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nom", dato.Nombre);
                cmd.Parameters.AddWithValue("@ape", dato.Apellidos);
                cmd.Parameters.AddWithValue("@nacimie", dato.Fecha);
                cmd.Parameters.AddWithValue("@dni", dato.Dni);
                cmd.Parameters.AddWithValue("@cel", dato.Cel);
                cmd.Parameters.AddWithValue("@correo", dato.Correo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Solo letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Solo letras")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        [MaxLength(8, ErrorMessage = "DNI debe de tener 8 dígitos")]
        public string Dni { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(9, ErrorMessage = "Celular debe de tener 9 dígitos")]
        [MaxLength(9, ErrorMessage = "Celular debe de tener 9 dígitos")]
        public string Cel { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe de tener un formato correcto el correo")]
        public string Correo { get; set; }
        public int Tipo { get; set; }
        public string Cargo { get; set; }
    }
}
