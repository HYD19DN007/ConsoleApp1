using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class SpEx1
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());

            SqlConnection Con = new SqlConnection("Password=admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6M2QS4F");
            SqlDataAdapter Adp = new SqlDataAdapter("Example1",Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //Input parameter of Stored Procedure
            Adp.SelectCommand.Parameters.AddWithValue("@a",i);
            Adp.SelectCommand.Parameters.AddWithValue("@b", j);
            //output parameter of Stored Procedure
            //SqlParameter P = new SqlParameter("@a", SqlDbType.Int);
            //P.Value = i;
            //Adp.SelectCommand.Parameters.Add(P);
            SqlParameter P = new SqlParameter("@c", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            SqlParameter P1 = new SqlParameter("@d", SqlDbType.Int);
            P1.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P1);
            DataSet Ds = new DataSet();
            Adp.Fill(Ds);
            Console.WriteLine(P.Value);
            Console.WriteLine(P1.Value);
            Console.Read();


        }
    }
}
