using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class query_select:Sql_connection
    {
      public  query_select() : base()
        {

        }
        public DataSet selectallbooks()
        {
            query = "select * from book";
            cmd.CommandText = query;
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds, "book");
            conclose();
            return ds;
           
        }
        public DataSet selectbook(int combo,string txt)
        {
            if (combo==1)
            query = "select * from book where isbn=@txt";
            else if (combo==2)
              query = "select * from book where title like @txt";
            cmd.Parameters.AddWithValue("@txt", txt);
            cmd.CommandText = query;
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds, "book");
            conclose();
            return ds;

        }
    }
}
