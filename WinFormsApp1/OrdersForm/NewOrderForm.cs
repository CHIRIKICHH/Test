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
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();

            RefreshBoxes();
            Book.bookList.ListChanged += delegate { RefreshBoxes(); };
            Worker.workerList.ListChanged += delegate { RefreshBoxes(); };
        }

        private void RefreshBoxes()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            comboBox1.Items.AddRange((from x in Book.bookList orderby x.ID select $"{x.ID} - {x.Name}").ToArray());
            comboBox2.Items.AddRange((from x in Worker.workerList orderby x.ID select $"{x.ID} - {x.FIO}").ToArray());
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if (comboBox1.Text != "")
                        if (comboBox2.Text != "")
                        {
                            int BookID = int.Parse(comboBox1.Text.Split(" - ")[0]);
                            int WorkerID = int.Parse(comboBox2.Text.Split(" - ")[0]);
                            Order order = new Order(DataBase.GetID("LibOrder"), textBox1.Text, textBox2.Text, BookID, WorkerID, dateTimePicker1.Value);
                            Order.orderList.Add(order);
                            label1.Text = DataBase.Insert(order);

                            button2_Click(sender, e);
                            label1.ForeColor = Color.Green;
                        }
                        else
                            label1.Text = "Выберите работника!";
                    else
                        label1.Text = "Выберите книгу!";
                else
                    label1.Text = "Введите Номер телефона заказчика!";
            else
                label1.Text = "Введите ФИО заказчика!";
            Height = 407;
            label1.Left = Width / 2 - label1.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NewBookForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NewWorkerForm().Show();
        }
    }
}
