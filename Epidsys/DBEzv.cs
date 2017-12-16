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
    public partial class DBEzv : Form
    {
        public DBEzv()
        {
            InitializeComponent();
        }

        private void zareetstrvani_vipadkuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zareetstrvani_vipadkuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.epidsysDataSet);

        }

        private void DBEzv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter.Fill(this.epidsysDataSet.hvorobu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.zareetstrvani_vipadku". При необходимости она может быть перемещена или удалена.
            this.zareetstrvani_vipadkuTableAdapter.Fill(this.epidsysDataSet.zareetstrvani_vipadku);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEuser f5 = new DBEuser();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnAddel_Click(object sender, EventArgs e)
        {
            this.zareetstrvani_vipadkuBindingSource.AddNew();
        }

        private void btnSaverl_Click(object sender, EventArgs e)
        {
            Validate();
            this.zareetstrvani_vipadkuBindingSource.EndEdit();
            this.zareetstrvani_vipadkuTableAdapter.Update(this.epidsysDataSet);
        }

        private void btnDeleterl_Click(object sender, EventArgs e)
        {
            this.zareetstrvani_vipadkuBindingSource.RemoveCurrent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
