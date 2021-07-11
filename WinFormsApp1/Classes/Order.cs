using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Order
    {
        public static SortableBindingList<Order> orderList = new SortableBindingList<Order>();

        internal int ID;
        internal string FIO;
        internal string Phone;
        internal Book book;
        internal Worker worker;
        internal DateTime DateOrder;

        public int Номер { get { return ID; } }
        public string ФИО_Читателя { get { return FIO; } }
        public string Телефон { get { return Phone; } }
        public string Название_Книги { get { return book.Name; } }
        public string ФИО_Работника { get { return worker.FIO; } } 
        public string Дата_выдачи { get { return DateOrder.ToString("D"); } }
        public string Дата_возврата { get { return DateOrder.AddMonths(1).ToString("D"); } }
        public string Штраф { get { if (DateOrder.AddMonths(1) < DateTime.Now) return $"{Math.Round((DateTime.Now - DateOrder.AddMonths(1)).TotalDays * 2, 2)} ₽"; else return "0 ₽"; } }


        public Order(int ID, string FIO, string Phone, int BookID, int WorkerID, DateTime DateOrder)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.Phone = Phone;
            this.book = Book.bookList.Where(x => x.ID == BookID).FirstOrDefault();
            this.worker = Worker.workerList.Where(x => x.ID == WorkerID).FirstOrDefault();
            this.DateOrder = DateOrder;
        }

        public Order() { }
        public override string ToString()
        {
            return $"{ID} {FIO} {Phone} {Название_Книги} {ФИО_Работника} {Дата_выдачи}".ToLower();
        }
    }
}
