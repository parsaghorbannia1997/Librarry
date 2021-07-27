using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    class Sql_connection
    {
        SqlConnection con;
        string constr = "Data Source=.;Initial" +
            " catalog=Book;Integrated Security=True";
        public string query = "";
        public SqlCommand cmd = new SqlCommand();

        public SqlDataAdapter ad = new SqlDataAdapter();
        public DataSet ds = new DataSet();
    public Sql_connection()
        {
            con = new SqlConnection(constr);
            cmd.Connection = con;
            con.Open();
        }
    public void conclose()
        {
            query = "";
            cmd.Parameters.Clear();
            con.Close();
        }
    }
}
