using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class query_change: Sql_connection
    {
        public query_change() : base() { }
        public void Insertbook(string isbn ,
        string title,string authorname ,
        string publisher ,string copyright,
        int count)
        {
            query = "insert into book"+
                "(ISBN,title,authorName,publisher,"+
"copy_right,[count]) values"+
"(@isbn,@title,@authorname,@publisher,"+
"@copyright,@count)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@isbn",isbn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@authorname", authorname);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@copyright", copyright);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.ExecuteNonQuery();
            conclose();

        }
        public void updatebook(string lastisbn,string isbn,
        string title, string authorname,
        string publisher, string copyright,
        int count)
        {
            query = "update book" +
                " set isbn=@isbn,title=@title,authorname=@authorname,"+
                "publisher=@publisher,copy_right=@copyright,count=@count" +
                " where isbn=@lastisbn";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@authorname", authorname);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@copyright", copyright);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@lastisbn", lastisbn);
            cmd.ExecuteNonQuery();
            conclose();
                }
        public void deletebook(string lastisbn)
        {
            query = "delete from book "+
                " where isbn=@lastisbn";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@lastisbn", lastisbn);
            cmd.ExecuteNonQuery();
            conclose();
        }

    }
}
