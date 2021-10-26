using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripsound.Model
{
    public class InventarioDataAcces
    {
        string connectionString = ";";

        public async Task<List<Inventario>> GetAllInventario()
        {
            List<Inventario> lstemployee = new List<Inventario>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_LISTARINVENTARIO", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Inventario employee = new Inventario();
                    employee.id = Convert.ToInt32(rdr["id"].ToString());
                    employee.Nombre = rdr["nombre"].ToString();
                    employee.Marca = rdr["marca"].ToString();

                    employee.cantidad = Convert.ToInt32( rdr["cantidad"].ToString());
                  


                    lstemployee.Add(employee);
                }
                con.Close();
            }


            return lstemployee;
        }


        public void AddInventario(Inventario dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRAREQUIPOS", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nom", dato.Nombre);
                cmd.Parameters.AddWithValue("@marca", dato.Marca);
                cmd.Parameters.AddWithValue("@cantidad", dato.cantidad);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    public class Inventario

    {
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"/^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$/g", ErrorMessage = "Solo letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(50, ErrorMessage = "Max 50 letras")]
        [RegularExpression(@"/^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$/g", ErrorMessage = "Solo letras")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int cantidad { get; set; }
    }
}
