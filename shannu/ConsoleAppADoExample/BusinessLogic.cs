using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;




namespace ConsoleAppADoExample
{
    internal class BusinessLogic
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public BusinessLogic()
        {
            connection = new SqlConnection("Data Source=tcp:sqlserveryuv.database.windows.net,1433;User ID=sqladmin;Password=P@ssword123;Initial Catalog=empdb");
            command = new SqlCommand();
           
            command.Connection = connection;
            connection.Close();
        }


        public bool AddStudent(Student stu)
        {
            command.CommandText = $"insert into stu_table values({stu.id},'{stu.name}',{stu.year},'{stu.loc}','{stu.gen}')";
            connection.Open();
            int res = command.ExecuteNonQuery();   
            connection.Close() ;
            return res>0;
        }

        public bool UpdateStudent(Student stu)
        {
            command.CommandText = $"update stu_table set stuname = '{stu.name}',stu_year = {stu.year},stu_loc='{stu.loc}' where stuid = {stu.id}";
            connection.Open();
            int res = command.ExecuteNonQuery();
            return res > 0;
        }
        public bool DeleteStudent(int id)
        {
            command.CommandText = $"delete from stu_table  where stuid = {id}";
            connection.Open();
            int res = command.ExecuteNonQuery();
            return res > 0;
        }
        public Student GetStudent(int id)
        {
            command.CommandText = $"select * from stu_table where stuid = {id}";
            connection.Open();
            reader = command.ExecuteReader();
           Student stu = new Student();
            if (reader.Read())
            {
                stu.id = Convert.ToInt32(reader[0]);
                stu.name = reader[1].ToString();
                stu.year = Convert.ToInt32(reader[2]);
                stu.loc = reader[3].ToString();
                stu.gen = reader[4].ToString();
            }
            connection.Close();
            return stu;
        }
        public ArrayList GetStudentList()
        {
            command.CommandText = "select * from stu_table";
            connection.Open();
            reader = command.ExecuteReader();
          ArrayList stuList = new ArrayList();
            Student stu;
            while (reader.Read())
            {
                stu = new Student();
                stu.id = Convert.ToInt32(reader[0]);
                stu.name = reader[1].ToString();
                stu.year = Convert.ToInt32(reader[2]);
                stu.loc = reader[3].ToString() ;
                stu.gen = reader[4].ToString() ;
                stuList.Add(stu);
            }
            connection.Close();
            return stuList;

        }

    }
}
