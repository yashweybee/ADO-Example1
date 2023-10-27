using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection("data source=.; database=Employees; integrated security=SSPI");


                //string createTable = "create table emp_new(id int not null, name varchar(100), email varchar(50), join_date date)";

                string insertValues = "insert into emp(id, name,email,join_date) values ('2', 'Ravi', 'ravi@gmail.com', '1/2/2023'), ('3', 'Miral', 'miral@gmail.com', '1/2/2023'), ('4', 'ABCD', 'abcd@gmail.com', '1/2/2023'), ('5', 'qwer', 'qwer@gmail.com', '1/2/2023'), ('6', 'zxcv', 'zxcv@gmail.com', '1/2/2023')";

                //string retriveRec = "select * from emp";

                //string del = "delete from emp where id = 2";
                SqlCommand cm = new SqlCommand(insertValues, conn);

                conn.Open();

                cm.ExecuteNonQuery();

                //for read data only
                //SqlDataReader rdr = cm.ExecuteReader();
                //while (rdr.Read())
                //{
                //    Console.WriteLine(rdr["id"] + " " + rdr["name"] + "Nums of Cols " + rdr.FieldCount);
                //}

                Console.WriteLine("Query Executed");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
