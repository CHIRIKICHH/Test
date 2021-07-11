using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if (textBox3.Text != "")
                        if (textBox4.Text != "" && int.TryParse(textBox4.Text, out int count))
                            if (textBox5.Text != "" && int.TryParse(textBox5.Text, out int price))
                            {
                                Book book = new Book(DataBase.GetID("Books"), textBox1.Text, textBox2.Text, textBox3.Text, count, price);
                                Book.bookList.Add(book);
                                label1.Text = DataBase.Insert(book);

                                button2_Click(sender, e);
                                label1.ForeColor = Color.Green;
                            }
                            else
                                label1.Text = "Введите Цену!";
                        else
                            label1.Text = "Введите Кол-во страниц!";
                    else
                        label1.Text = "Введите Жанр книги!";
                else
                    label1.Text = "Введите Автора книги!";
            else
                label1.Text = "Введите название книги!";
            Height = 281;
            label1.Left = Width / 2 - label1.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
                if (item is TextBox itm)
                    itm.Text = "";
        }
    }
}
