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
    public partial class MainOrderForm : Form
    {
        public MainOrderForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Order.orderList;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 155;
            dataGridView1.Columns[4].Width = 170;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[7].Width = 60;

            new Form1().Show();
        }

        //При загрузке формы чтение из БД
        private void Form1_Load(object sender, EventArgs e)
        {
            Book.bookList.AddRange(DataBase.Select(new Book()) as List<Book>);
            Worker.workerList.AddRange(DataBase.Select(new Worker()) as List<Worker>);
            Order.orderList.AddRange(DataBase.Select(new Order()) as List<Order>);
        }

        //Двойное нажатие по ячейке
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string numb = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = numb;
            }
        }

        //Добавление заказа
        private void button1_Click(object sender, EventArgs e)
        {
            new NewOrderForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MainBookForm().Show();
        }

        //Кнопка 
        private void button4_Click(object sender, EventArgs e)
        {
            new MainWorkerForm().Show();
        }

        //Строка поиска
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                dataGridView1.DataSource = Order.orderList.Where(x => x.ToString().Contains(textBox1.Text.ToLower())).ToList();
            else
                dataGridView1.DataSource = Order.orderList;
        }

        //Кнопка удаления
        private void button3_Click(object sender, EventArgs e)
        {
            Order order = Order.orderList.Where(x => x.ID.ToString() == textBox2.Text).FirstOrDefault();
            if(order != null)
            {
                MessageBox.Show(DataBase.Delete(order));
                Order.orderList.Remove(order);
                textBox2.Text = "";
            }
        }

        //Кнопка редактирования
        private void button2_Click(object sender, EventArgs e)
        {
            Order order = Order.orderList.Where(x => x.ID.ToString() == textBox2.Text).FirstOrDefault();
            if (order != null)
            {
                new ChangeOrderForm(order).Show();
                textBox2.Text = "";
            }
        }
    }
}
