using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class InsertDB
    {
        const string DBName = DataBase.DBName;
        public static string Book(Book book)
        {
            try
            {
                //Открытие подключения с БД и добавление в таблицу
                using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
                {
                    //Открытие подключения
                    connection.Open();

                    //Выполнение запроса
                    string Insert = $"INSERT Books VALUES('{book.ID}', '{book.Name}', '{book.Author}', '{book.Genre}', '{book.Pages}', '{book.Price}');";
                    new SqlCommand(Insert, connection).ExecuteNonQuery();
                    return "Книга успешно добавлена";
                }
            }
            catch (Exception ex)
            {
                return $"Добавление не удалось, ошибка: {ex.Message}";
            }
        }

        public static string Order(Order order)
        {
            try
            {
                //Открытие подключения с БД и добавление в таблицу
                using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
                {
                    //Открытие подключения
                    connection.Open();

                    //Выполнение запроса
                    string Insert = $"INSERT LibOrder VALUES('{order.ID}','{order.FIO}','{order.Phone}','{order.book.ID}','{order.worker.ID}','{order.DateOrder}');";
                    new SqlCommand(Insert, connection).ExecuteNonQuery();
                    return "Выдача успешно совершен";
                }
            }
            catch (Exception ex)
            {
                return $"Добавление не удалось, ошибка: {ex.Message}";
            }
        }

        public static string Worker(Worker worker)
        {
            try
            {
                //Открытие подключения с БД и добавление в таблицу
                using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
                {
                    //Открытие подключения
                    connection.Open();

                    //Выполнение запроса
                    string Insert = $"INSERT Workers VALUES('{worker.ID}', '{worker.FIO}', '{worker.Phone}');";
                    new SqlCommand(Insert, connection).ExecuteNonQuery();
                    return "Работник успешно добавлен";
                }
            }
            catch (Exception ex)
            {
                return $"Добавление не удалось, ошибка: {ex.Message}";
            }
        }
    }
}
