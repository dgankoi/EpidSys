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
    public partial class DBEnp : Form
    {
        public DBEnp()
        {
            InitializeComponent();
        }

        private void terretoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terretoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.epidsysDataSet);

        }

        private void DBEnp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.terretory". При необходимости она может быть перемещена или удалена.
            this.terretoryTableAdapter.Fill(this.epidsysDataSet.terretory);

        }

        private void btnAddel_Click(object sender, EventArgs e)
        {
            this.terretoryBindingSource.AddNew();
        }

        private void btnSaverl_Click(object sender, EventArgs e)
        {
            Validate();
            this.terretoryBindingSource.EndEdit();
            this.terretoryTableAdapter.Update(this.epidsysDataSet);
        }

        private void btnDeleterl_Click(object sender, EventArgs e)
        {
            this.terretoryBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            DBEzv g3 = new DBEzv();
            g3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEuser g5 = new DBEuser();
            g5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEhvor g5 = new DBEhvor();
            g5.ShowDialog();
        }

        private void btnUnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login gh = new Login();
            gh.ShowDialog();  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
           Main_menu_admin_ gh = new Main_menu_admin_ ();
            gh.ShowDialog();
        }
    }
}
