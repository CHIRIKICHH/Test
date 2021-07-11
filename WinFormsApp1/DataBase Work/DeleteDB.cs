using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DeleteDB
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
                    string Delete = $"DELETE FROM Books WHERE ID = '{book.ID}'";
                    new SqlCommand(Delete, connection).ExecuteNonQuery();
                    return "Книга успешно удалена!";
                }
            }
            catch
            {
                return $"Запись невозможно удалить, так как она уже используется!";
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
                    string Delete = $"DELETE FROM LibOrder WHERE ID = '{order.ID}'";
                    new SqlCommand(Delete, connection).ExecuteNonQuery();
                    return "Выдача успешно удалена!";
                }
            }
            catch
            {
                return $"Запись невозможно удалить, так как она уже используется!";
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
                    string Delete = $"DELETE FROM Workers WHERE ID = '{worker.ID}'";
                    new SqlCommand(Delete, connection).ExecuteNonQuery();
                    return "Сотрудник успешно удален!";
                }
            }
            catch
            {
                return $"Запись невозможно удалить, так как она уже используется!";
            }
        }
    }
}
