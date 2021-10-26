using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripsound.Model
{
    public class EventoDataAccess
    {
        string connectionString = "";


        public void AddCliente(Evento dato)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("TRIPSOUND_REGISTRAREVENTO", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", dato.nombre);
                cmd.Parameters.AddWithValue("@fechainicio", dato.fechainicio);
                cmd.Parameters.AddWithValue("@horainicio", dato.horainicio);
                cmd.Parameters.AddWithValue("@horafinal", dato.horafinal);
                cmd.Parameters.AddWithValue("@direccion", dato.direccion);
                cmd.Parameters.AddWithValue("@referencia", dato.referencia);
                cmd.Parameters.AddWithValue("@idusuario", dato.idusuario);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
    public class Evento
    {
        public string nombre { get; set; }
        public DateTime fechainicio { get; set; }
        public TimeSpan horainicio { get; set; }

        public TimeSpan horafinal { get; set; }
        public string direccion { get; set; }

        public string referencia { get; set; }
        public int idusuario { get; set; }



    }
}
