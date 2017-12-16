using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Epidsys
{
    public partial class Login : Form

    {
    
       public static string log = "admin";
       public static string pass = "5";
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVhid_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=23051997";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from epidsys.user where login='" + this.txtLogin.Text + "' and password= '" + this.txtPass.Text + "';", myConn);
                MySqlDataReader myAdmin;
                if (log == txtLogin.Text || pass == txtPass.Text)
                {
                    
                    this.Hide();
                    Main_menu_admin_ f3 = new Main_menu_admin_();
                    f3.ShowDialog();
                }
                else
                {
                    myConn.Open();
                    myAdmin = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myAdmin.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                       
                        this.Hide();
                        Main_menu f2 = new Main_menu();
                        f2.ShowDialog();  }
                    else
                        MessageBox.Show("nevirnyy parol");
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
