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
    public partial class ChangeWorkerForm : Form
    {
        Worker worker;
        public ChangeWorkerForm(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            textBox1.Text = worker.FIO;
            textBox2.Text = worker.Phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                {
                    Worker worker = new Worker(this.worker.ID, textBox1.Text, textBox2.Text);
                    int index = Worker.workerList.IndexOf(this.worker);
                    Worker.workerList[index] = worker;
                    label1.Text = DataBase.Update(worker);

                    Close();
                }
                else
                    label1.Text = "Введите Номер телефона!";
            else
                label1.Text = "Введите ФИО сотрудника!";
            Height = 223;
            label1.Left = Width / 2 - label1.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
