using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CdisMart_DAL
{
    public class SubastaDAL
    {


        CdisMartEntities modelo;

        public SubastaDAL()
        {
            modelo = new CdisMartEntities();
        }

        public List<object> cargarSubastas()
        {
            var subastas = from mSubasta in modelo.Auction
                           select new
                           {
                               AuctionId = mSubasta.AuctionId,
                               Productname = mSubasta.ProductName,
                               Description = mSubasta.Description,
                               StarDate = mSubasta.StartDate,
                               EndDate = mSubasta.EndDate
                           };
            return subastas.AsEnumerable<object>().ToList();
        }

        //public List<object> obtenerUsuarios()
        //{
        //    var usuarios = from mUsuarios in modelo.Users
        //                   select new
        //                   {
        //                       UserId = mUsuarios.UserId

        //                   };
        //    return usuarios.AsEnumerable<object>().ToList();
        //}
        //public DataTable cargarSubastas()
        //{
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = @"Server=DESKTOP-Q82E1Q9\SQLEXPRESS;Database=CdisMart;Trusted_connection=true;";

        //    SqlCommand command = new SqlCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "sp_cargarSubastas";
        //    command.Connection = connection;

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dtSubastas = new DataTable();

        //    connection.Open();

        //    adapter.SelectCommand = command;
        //    adapter.Fill(dtSubastas);

        //    connection.Close();

        //    return dtSubastas;
        //}
        public void agregarSubasta(string nombreProducto, string descripcionProducto, DateTime fechaInicio, DateTime fechaFinal, int usuariodeOferta)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-Q82E1Q9\SQLEXPRESS;Database=CdisMart;Trusted_connection=true;";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarSubasta";
            command.Connection = connection;

            command.Parameters.AddWithValue("pNombreProducto", nombreProducto);
            command.Parameters.AddWithValue("pDescripcionProducto", descripcionProducto);
            command.Parameters.AddWithValue("pFechaInicio", fechaInicio);
            command.Parameters.AddWithValue("pFechaFinal", fechaFinal);
            command.Parameters.AddWithValue("pUsuariodeOferta", usuariodeOferta);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        

        

    }
}
