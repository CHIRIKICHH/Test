using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class SelectDB
    {
        const string DBName = DataBase.DBName;
        public static List<Book> Book()
        {
            List<Book> list = new List<Book>();
            //Открытие подключения с БД и добавление в таблицу
            using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
            {
                connection.Open();
                SqlDataReader reader = new SqlCommand("SELECT * FROM Books", connection).ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Book(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5)
                        ));
                }
            }
            return list;
        }

        public static List<Order> Order()
        {
            List<Order> list = new List<Order>();
            //Открытие подключения с БД и добавление в таблицу
            using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
            {
                connection.Open();
                SqlDataReader reader = new SqlCommand("SELECT * FROM LibOrder", connection).ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Order(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4),
                        reader.GetDateTime(5)
                        ));
                }
            }
            return list;
        }

        public static List<Worker> Worker()
        {
            List<Worker> list = new List<Worker>();
            //Открытие подключения с БД и добавление в таблицу
            using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
            {
                connection.Open();
                SqlDataReader reader = new SqlCommand("SELECT * FROM Workers", connection).ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Worker(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2)
                        ));
                }
            }
            return list;
        }
    }
}
