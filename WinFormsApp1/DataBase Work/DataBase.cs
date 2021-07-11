using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DataBase
    {
        //Название Базы Данных
        public const string DBName = "Library";

        //Получение уникального ID для записи
        public static int GetID(string TableName)
        {
            //Открытие подключения с БД и получение ID
            using (SqlConnection connection = new SqlConnection($"Data Source=.\\SQLEXPRESS; Initial Catalog= {DBName}; Integrated Security=True"))
            {
                connection.Open();

                //Запрос на получение максимального ID из таблицы
                string selectID = $"SELECT MAX(ID) FROM {TableName};";
                SqlCommand SelectID = new SqlCommand(selectID, connection);
                SqlDataReader reader = SelectID.ExecuteReader();
                int ID = 1;
                //Чтение из БД
                while (reader.Read())
                    //Если значение не NULL то Максимальное число + 1
                    if (!reader.IsDBNull(0))
                        ID = reader.GetInt32(0) + 1;
                return ID;
            }
        }

        //Метод вывода из БД
        public static object Select(object item)
        {
            if (item is Book)
                return SelectDB.Book() as object;
            if (item is Order)
                return SelectDB.Order();
            if (item is Worker)
                return SelectDB.Worker();
            return null;
        }

        //Метод добавления в БД
        public static string Insert(object item)
        {
            if (item is Book)
                return InsertDB.Book(item as Book);
            if (item is Order)
                return InsertDB.Order(item as Order);
            if (item is Worker)
                return InsertDB.Worker(item as Worker);
            return "Передаваемый объект неоступен для добавления";
        }

        //Метод обновления информации в БД
        public static string Update(object item)
        {
            if (item is Book)
                return UpdateDB.Book(item as Book);
            if (item is Order)
                return UpdateDB.Order(item as Order);
            if (item is Worker)
                return UpdateDB.Worker(item as Worker);
            return "Передаваемый объект неоступен для изменения";
        }

        //Метод удаления из БД
        public static string Delete(object item)
        {
            if (item is Book)
                return DeleteDB.Book(item as Book);
            if (item is Order)
                return DeleteDB.Order(item as Order);
            if (item is Worker)
                return DeleteDB.Worker(item as Worker);
            return "Передаваемый объект неоступен для изменения";
        }
    }
}
