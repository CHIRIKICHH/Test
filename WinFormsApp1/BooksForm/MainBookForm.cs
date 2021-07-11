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
    public partial class MainBookForm : Form
    {
        public MainBookForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Book.bookList;

            dataGridView1.Columns[0].Width = 52;
            dataGridView1.Columns[1].Width = 173;
            dataGridView1.Columns[2].Width = 177;
            dataGridView1.Columns[3].Width = 165;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 66;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
                dataGridView1.DataSource = Book.bookList.Where(x => x.ToString().Contains(searchBox.Text.ToLower())).ToList();
            else
                dataGridView1.DataSource = Book.bookList;
        }

        //Кнопка редактирования
        private void changeButton_Click(object sender, EventArgs e)
        {
            Book book = Book.bookList.Where(x => x.ID.ToString() == changeBox.Text).FirstOrDefault();
            if (book != null)
            {
                new ChangeBookForm(book).Show();
            }
        }

        //Кнопка удаления
        private void removeButton_Click(object sender, EventArgs e)
        {
            //Получение удаляемого элемента
            Book book = Book.bookList.Where(x => x.ID.ToString() == changeBox.Text).FirstOrDefault();
            if (book != null)
            {
                //Удаление из БД и из коллекции с выводом сообщения
                MessageBox.Show(DataBase.Delete(book));
                Book.bookList.Remove(book);
            }
        }

        private void MainBookForm_Load(object sender, EventArgs e)
        {

        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            new NewBookForm().Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string numb = dataGridView1[0, e.RowIndex].Value.ToString();
                changeBox.Text = numb;
            }
        }
    }
}
