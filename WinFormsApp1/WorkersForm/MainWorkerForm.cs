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
    public partial class MainWorkerForm : Form
    {
        public MainWorkerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Worker.workerList;

            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 183;
            dataGridView1.Columns[2].Width = 191;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
                dataGridView1.DataSource = Worker.workerList.Where(x => x.ToString().Contains(searchBox.Text.ToLower())).ToList();
            else
                dataGridView1.DataSource = Worker.workerList;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            new NewWorkerForm().Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Worker worker = Worker.workerList.Where(x => x.ID.ToString() == changeBox.Text).FirstOrDefault();
            if (worker != null)
            {
                new ChangeWorkerForm(worker).Show();
                changeBox.Text = "";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Получение удаляемого элемента
            Worker worker = Worker.workerList.Where(x => x.ID.ToString() == changeBox.Text).FirstOrDefault();
            if (worker != null)
            {
                //Удаление из БД и из коллекции с выводом сообщения
                MessageBox.Show(DataBase.Delete(worker));
                Worker.workerList.Remove(worker);
                changeBox.Text = "";
            }
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
