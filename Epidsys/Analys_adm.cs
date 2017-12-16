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
    public partial class Analys_adm : Form
    {
        public Analys_adm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Login f45 = new Login();
            f45.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_menu_admin_ f465 = new Main_menu_admin_();
            f465.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZAKadm f4465 = new ZAKadm();
            f4465.ShowDialog();
        }

        private void Analys_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.terretory". При необходимости она может быть перемещена или удалена.
            this.terretoryTableAdapter.Fill(this.epidsysDataSet.terretory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter.Fill(this.epidsysDataSet.hvorobu);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hvorobuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void hvorobuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hvorobuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.epidsysDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gen = "";
            string die = "";


            string Query = "select idhvorobu,gender,pomerlyu,data_vypadka,vik,lokaciya_vupdaka, count(idZvupadka) as kilkist,data_vypadka from epidsys.zareetstrvani_vipadku where data_vypadka between '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and  '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' and idhvorobu=" + hvor.SelectedValue + " and lokaciya_vupdaka=" + np.SelectedValue + "   and   vik  between  " + idVikTextBox.Text + "  and " + idVikTextBox1.Text;

            if (checkBox3.Checked == true)
            {
                die = "Так";
                Query += " and pomerlyu = '" + die + "'";
            }

            else if (checkBox4.Checked == true)
            {
                die = "Ні";
                Query += " and pomerlyu = '" + die + "'";
            }

            else if (checkBox3.Checked == false || checkBox4.Checked == false)
            {
                Query += "  ";

            }

            if (checkBox1.Checked == true)
            {
                gen = "чол";
                Query += " and gender = '" + gen + "' group by data_vypadka;";
            }

            else if (checkBox2.Checked == true)
            {
                gen = "жін";
                Query += " and gender = '" + gen + "' group by data_vypadka;";
            }

            else if (checkBox2.Checked == false || checkBox1.Checked == false)
            {
                Query += "  group by data_vypadka;";

            }


            chart1.Series[0].Points.Clear();
            string constring = "datasource=localhost;port=3306;username=root;password=23051997";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            conDataBase.Open();
            MySqlDataReader myReader = cmdDatabase.ExecuteReader();



            string strK = "";
            string strP = "";

            while (myReader.Read())
            {
                chart1.Series["Кількість випадків"].Points.AddXY(myReader.GetString("data_vypadka"), myReader.GetString("kilkist"));
                //textBox3.Text += myReader.GetString("idgender");

            }

            /* foreach (DataRow dataRowK in myReader)
             {

                 strK = strK + String.Format("{0}: {1} \r\n", dataRowK[0].ToString(), dataRowK[2].ToString());
                 chart1.Series["Кількість голосів"].Points.AddXY(dataRowK[0].ToString(), dataRowK[2].ToString());
             }
             */
            conDataBase.Close();




        }

        private void hvor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=23051997";
            string Query = "select * from epidsys.hvorobu where idhvorobu = '" + hvor.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string symp = myReader.GetString("patalogichni_symptomu");
                    richTextBox1.Text = symp;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main_menu_admin_ ghy = new Main_menu_admin_();
            ghy.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Login ghy = new Login ();
            ghy.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ZAKadm ghy = new ZAKadm();
            ghy.ShowDialog();

        }

        

       
       
    }
    }

