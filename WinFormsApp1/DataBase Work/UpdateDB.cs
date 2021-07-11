using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class UpdateDB
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
                    string Update = $"UPDATE Books SET Name = '{book.Name}', Author = '{book.Author}', Genre = '{book.Genre}', Pages = '{book.Pages}', Price = '{book.Price}' WHERE ID = '{book.ID}';";
                    new SqlCommand(Update, connection).ExecuteNonQuery();
                    return "Книга успешно обновлена!";
                }
            }
            catch (Exception ex)
            {
                return $"Обновление не удалось, ошибка: {ex.Message}";
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
                    string Update = $"UPDATE LibOrder SET FIO = '{order.FIO}', PhoneNumber = '{order.Phone}', BookID = '{order.book.ID}' WorkerID = '{order.worker.ID}', DateOrder = '{order.DateOrder}' WHERE ID = '{order.ID}';";
                    new SqlCommand(Update, connection).ExecuteNonQuery();
                    return "Выдача успешно обновлена!";
                }
            }
            catch (Exception ex)
            {
                return $"Обновление не удалось, ошибка: {ex.Message}";
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
                    string Update = $"UPDATE Workers SET FIO = '{worker.FIO}', PhoneNumber = '{worker.Phone}' WHERE ID = '{worker.ID}';";
                    new SqlCommand(Update, connection).ExecuteNonQuery();
                    return "Сотрудник успешно обновлен!";
                }
            }
            catch (Exception ex)
            {
                return $"Обновление не удалось, ошибка: {ex.Message}";
            }
        }
    }
}
