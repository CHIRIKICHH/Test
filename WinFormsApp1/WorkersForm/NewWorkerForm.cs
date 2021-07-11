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
    public partial class NewWorkerForm : Form
    {
        public NewWorkerForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                {
                    Worker worker = new Worker(DataBase.GetID("Workers"), textBox1.Text, textBox2.Text);
                    Worker.workerList.Add(worker);
                    label1.Text = DataBase.Insert(worker);

                    button2_Click(sender, e);
                    label1.ForeColor = Color.Green;
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

        private void NewWorkerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
