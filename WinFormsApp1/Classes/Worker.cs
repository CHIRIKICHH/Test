using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Worker
    {
        public static SortableBindingList<Worker> workerList = new SortableBindingList<Worker>();

        internal int ID;
        internal string FIO;
        internal string Phone;

        public int Номер { get { return ID; } }
        public string Фамилия_Имя_Отчество { get { return FIO; } }
        public string Номер_Телефона { get { return Phone; } }

        public Worker(int ID, string FIO, string Phone)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.Phone = Phone;
        }

        public Worker() { }
        public override string ToString()
        {
            return $"{ID} {FIO} {Phone}".ToLower();
        }
    }
}
