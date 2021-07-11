using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Book
    {
        //Статическая коллекция для хранения книг
        public static SortableBindingList<Book> bookList = new SortableBindingList<Book>();
        
        //Свойства класса
        internal int ID;
        internal string Name;
        internal string Author;
        internal string Genre;
        internal int Pages;
        internal int Price;

        //Поля класса
        public int Номер { get { return ID; } }
        public string Название_книги { get { return Name; } }
        public string Автор { get { return Author; } }
        public string Жанр { get { return Genre; } }
        public int Колво_страниц { get { return Pages; } }
        public int Цена { get { return Price; } }

        //Конструктор класса
        public Book(int ID, string Name, string Author, string Genre, int Pages, int Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Author = Author;
            this.Genre = Genre;
            this.Pages = Pages;
            this.Price = Price;
        }

        public Book() { }

        //Переопределенный метод возврата строки, используется в строках поиска
        public override string ToString()
        {
            return $"{ID} {Name} {Author} {Genre} {Pages} {Price}".ToLower();
        }
    }
}
