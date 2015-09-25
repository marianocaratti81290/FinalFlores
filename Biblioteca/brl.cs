using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;

namespace Biblioteca
{
   public static class brl
    {

       public static int logearUsuario(string usuario, string password)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("Logeo_buscarSocio_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@usuario", usuario);
               cmd.Parameters.AddWithValue("@password", password);
               SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
               existe.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(existe);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)existe.Value;
           }
           catch (Exception ex)
          
           {
               throw ex;
           }

       }
       public static void agregarUsuarioBdLogin(string usuario, string password, string permiso, string nombre,
           string apellido, string dni, string fecha_nacimiento, string sexo, string cel, string tel, string domicilio,
           string provincia, string localidad, string cp, int estado, string observacion)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("socio_insertarCliente_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id", "");
               cmd.Parameters.AddWithValue("@usuario", usuario);
               cmd.Parameters.AddWithValue("@password", password);
               cmd.Parameters.AddWithValue("@permiso", permiso);
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@apellido", apellido);
               cmd.Parameters.AddWithValue("@dni", dni);
               cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
               cmd.Parameters.AddWithValue("@sexo", sexo);
               cmd.Parameters.AddWithValue("@cel", cel);
               cmd.Parameters.AddWithValue("@tel_fijo", tel);
               cmd.Parameters.AddWithValue("@domicilio", domicilio);
               cmd.Parameters.AddWithValue("@provincia", provincia);
               cmd.Parameters.AddWithValue("@localidad", localidad);
               cmd.Parameters.AddWithValue("@cp", cp);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@observacion", observacion);
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);
              
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void agregarLibros(string titulo, string autor, string editorial, string anio,
          string genero, string paginas, int estado, string observacion)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("libros_insertarLibro_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id", "");
               cmd.Parameters.AddWithValue("@titulo", titulo);
               cmd.Parameters.AddWithValue("@autor", autor);
               cmd.Parameters.AddWithValue("@editorial", editorial);
               cmd.Parameters.AddWithValue("@anio", anio);
               cmd.Parameters.AddWithValue("@genero", genero);
               cmd.Parameters.AddWithValue("@paginas", paginas);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@observacion", observacion);
              
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

    }
}
