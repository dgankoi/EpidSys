using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidsys
{
    public partial class DBEuser : Form
    {
        public DBEuser()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.epidsysDataSet);

        }

        private void DBEuser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.epidsysDataSet.user);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEnp f1 = new DBEnp();
            f1.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEhvor f3 = new DBEhvor();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEzv f4 = new DBEzv();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddel_Click(object sender, EventArgs e)
        {
            this.userBindingSource.AddNew();
        }

        private void btnSaverl_Click(object sender, EventArgs e)
        {
            Validate();
            this.userBindingSource.EndEdit();
            this.userTableAdapter.Update(this.epidsysDataSet);

        }

        private void btnDeleterl_Click(object sender, EventArgs e)
        {
            this.userBindingSource.RemoveCurrent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f7 = new Login();
            f7.ShowDialog();

        }

        
    }


}
