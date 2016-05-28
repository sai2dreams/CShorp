using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CShorpApp1.DAL
{
    class dbConnection
    {
        SqlConnection cn = new SqlConnection("server=.;database=CollectionDB;Integrated Security=True;");
        

    }
}
