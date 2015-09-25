using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca
{
   public static class Comun
    {
       public static SqlConnection establecerConexion = new SqlConnection("Data Source=HACHITO\\SQLEXPRESS; database=sgpp_desarrollo; integrated security= true");
       }
}


