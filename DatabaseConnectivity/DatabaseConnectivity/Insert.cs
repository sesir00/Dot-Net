using System;
using System.Data.SqlClient;//to connect with sql server
//to connect with external data source like database xml file: System.Data.SqlClient package should be imported.
////to connect with server SQLConnection class is used and to execute the query SQLCommand class is used. 
///steps to connect and performing CRUD operation in dot net:
///1.create connection stringthat contains all the necessary parameter like server, db and security
///2. create object of SQLConnection to connect with database
///3.open connection using open() method
///4.write appropriate query
///5.execute query using object of SqlCommand
///6. close the connection

namespace DatabaseConnectivity
{
    class Insert
    {
        public void InsertOperation() 
        {
            //create connection string
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true";
            //datasource: servername, Initial Catalog= dbname
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            try
            {
                //creating table
                string tblQuery = "create table tbl_emp(eid int primary key," +
                    "ename varchar(50), gender varchar(50), department varchar(50), salary varchar(50))";
                //executing query 
                SqlCommand sc = new SqlCommand(tblQuery, conn); //(query, connection)
                sc.ExecuteNonQuery();   //insert, delete, update, delete
                Console.WriteLine("table created");
                conn.Close();
            }catch (SqlException ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void dataInsert() 
        {
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                /*string insQuery = "Insert into tbl_emp values(1, 'ram', 'male', 'IT', 10000)";
                SqlCommand sc = new SqlCommand(insQuery, conn);
                int res = sc.ExecuteNonQuery();//return 1 if every executed else return 0
                if(res>0)
                {
                    Console.WriteLine(res + " data inserted");
                }*/

                //user input
                Console.WriteLine("enter your id ");
                string id = Console.ReadLine();
                Console.WriteLine("enter your name ");
                string name = Console.ReadLine();
                Console.WriteLine("enter your gender ");
                string gender = Console.ReadLine();
                Console.WriteLine("enter  your department ");
                string depart = Console.ReadLine();
                Console.WriteLine("enter your salary ");
                string salary = Console.ReadLine();
                //query using prepared statement or using parameter
                string insQuery1 = "insert into tbl_emp values(@eid, @ename, @gender, @department, @salary)";
                SqlCommand sc1 = new SqlCommand(insQuery1, conn);
                sc1.Parameters.AddWithValue("@eid", id);
                sc1.Parameters.AddWithValue("@ename", name);
                sc1.Parameters.AddWithValue("@gender", gender);
                sc1.Parameters.AddWithValue("@department", depart);
                sc1.Parameters.AddWithValue("@salary", salary);
                int res = sc1.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " data inserted");
                }

            }
            catch(SqlException ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public void dataFetch()
        {
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                //query for fetching data
                string disQuery = "select * from tbl_emp";
                //to fetch data execute reader is used which return object SqlDataReader
                
                SqlCommand sc = new SqlCommand(disQuery, conn);
                SqlDataReader row = sc.ExecuteReader();
                while (row.Read()) 
                {
                    Console.WriteLine("ID is " + row["eid"]);
                    Console.WriteLine("name is " + row["ename"]);
                    Console.WriteLine("Gender is " + row["gender"]);
                    Console.WriteLine("Department is " + row["department"]);
                    Console.WriteLine("Salary is " + row["salary"]);
                    Console.WriteLine("------------------------------------");
                }
            }catch(SqlException s)
            {
                Console.WriteLine(s);
            }
        }
        public void updateData()
        {
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try 
            {
                conn.Open();
                //update name and salary to the value send by user whose id is also given by user
                string updateQuery = "update tbl_emp set ename=@ename, gender=@gender, salary=@salary where eid=@eid";
                Console.WriteLine("enter id of person of which you want to update ");
                string upid = Console.ReadLine();
                Console.WriteLine("enter updated name ");
                string upname = Console.ReadLine();
                Console.WriteLine("enter updated gender ");
                string upgender = Console.ReadLine();
                Console.WriteLine("enter updated salary ");
                string upsalary = Console.ReadLine();
                SqlCommand sc = new SqlCommand (updateQuery, conn);
                sc.Parameters.AddWithValue("@eid", upid);
                sc.Parameters.AddWithValue("@ename", upname);
                sc.Parameters.AddWithValue("@gender", upgender);
                sc.Parameters.AddWithValue("@salary", upsalary);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("data updated");
                }

            }
            catch(SqlException s) 
            {
                Console.WriteLine(s);
            }
        }
        public void deleteData()
        {
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                //delete record of employee whose id is given by user
                string delQuery = "delete from tbl_emp where eid=@eid";
                Console.WriteLine("enter id of employee for which you want to delete ");
                string delid = Console.ReadLine();
                SqlCommand sc = new SqlCommand (delQuery, conn);
                sc.Parameters.AddWithValue("@eid", delid);
                int res = sc.ExecuteNonQuery();
                if(res>0)
                {
                    Console.WriteLine("data deleted");
                }

            }catch(SqlException s) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
