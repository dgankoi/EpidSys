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
    public partial class DBEhvor : Form
    {
        public DBEhvor()
        {
            InitializeComponent();
        }

        private void hvorobuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hvorobuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.epidsysDataSet);

        }

        private void DBEhvor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter.Fill(this.epidsysDataSet.hvorobu);

        }

        private void btnAdde_Click(object sender, EventArgs e)
        {
            this.hvorobuBindingSource.AddNew();
        }

        private void btnSaver_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hvorobuBindingSource.EndEdit();
            this.hvorobuTableAdapter.Update(this.epidsysDataSet);
        }

        private void btnDeleter_Click(object sender, EventArgs e)
        {
            this.hvorobuBindingSource.RemoveCurrent();
        }

        private void btnUnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login(); 
            f2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_menu_admin_ f3 = new Main_menu_admin_();
            f3.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEnp f1 = new DBEnp();
            f1.ShowDialog();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEzv f4 = new DBEzv();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEuser f5 = new DBEuser();
            f5.ShowDialog();
        }

        
    }
}
