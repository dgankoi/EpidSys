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
    public partial class Analys : Form
    {
        public Analys()
        {
            InitializeComponent();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
            Main_menu f465 = new Main_menu();
            f465.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f45 = new Login();
            f45.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZAK f4465 = new ZAK();
            f4465.ShowDialog();
        }

        private void Analys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet1.terretory". При необходимости она может быть перемещена или удалена.
            this.terretoryTableAdapter1.Fill(this.epidsysDataSet1.terretory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet1.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter2.Fill(this.epidsysDataSet1.hvorobu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "epidsysDataSet1.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter2.Fill(this.epidsysDataSet1.hvorobu);
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series["Кількість випадків"].Points.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void np_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void hvor_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void hvor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void np_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        
        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { string gen = "";
            string die = ""; 
            

            string Query = "select idhvorobu,gender,pomerlyu,data_vypadka,vik,lokaciya_vupdaka, count(idZvupadka) as kilkist,data_vypadka from epidsys.zareetstrvani_vipadku where data_vypadka between '"+dateTimePicker1.Value.ToString("yyyy/MM/dd")+ "' and  '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' and idhvorobu=" + hvor.SelectedValue + " and lokaciya_vupdaka=" + np.SelectedValue + "   and   vik  between  " + idVikTextBox.Text + "  and " + idVikTextBox1.Text ;

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

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ZAK gt = new ZAK();
            gt.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hvorobuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hvorobuBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.epidsysDataSet1);

        }

        private void patalogichni_symptomuLabel_Click(object sender, EventArgs e)
        {

        }

        private void hvor_SelectedIndexChanged_2(object sender, EventArgs e)
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
    }
}
/*private void button1_Click(object sender, EventArgs e)
{
    int k, g; string SQLup1 = "", SQL, SQLup2 = ""; int d = 0;
    k = checkedListBox1.Items.Count;
    g = checkedListBox2.Items.Count;
    for (int i = 0; i < k; i++)
    {
        if (checkedListBox1.GetItemChecked(i))
        {
            if (d == 0)
            {
                SQLup1 = SQLup1 + "(Довідник_населених_пунктів.Назва_населеного_пункту)='" + checkedListBox1.Items[i].ToString() + "'";
                d++;
            }
            else SQLup1 = SQLup1 + " Or (Довідник_населених_пунктів.Назва_населеного_пункту)='" + checkedListBox1.Items[i].ToString() + "'";
        }
    }
    d = 0;
    for (int i = 0; i < g; i++)
    {
        if (checkedListBox2.GetItemChecked(i))
        {
            if (d == 0)
            {
                SQLup2 = SQLup2 + "(Довідник_районів.Назва_району)='" + checkedListBox2.Items[i].ToString() + "'";
                d++;
            }
            else SQLup2 = SQLup2 + " Or (Довідник_районів.Назва_району)='" + checkedListBox2.Items[i].ToString() + "'";
        }
    }
    SQL = "SELECT Кримінальна_справа.Номер_справи, Обвинувачуваний.ПІБ, Злочин.Код_статті, Довідник_населених_пунктів.Назва_населеного_пункту+', '+Довідник_районів.Назва_району+', '+Довідник_вулиць.Назва_вулиці+', '+Обвинувачуваний.[Номер_будинку]+', '+Обвинувачуваний.Номер_квартири AS Адреса_проживання FROM (Довідник_районів INNER JOIN (Довідник_населених_пунктів INNER JOIN (Довідник_вулиць INNER JOIN Обвинувачуваний ON Довідник_вулиць.[Код_вулиці] = Обвинувачуваний.[Код_вулиці]) ON Довідник_населених_пунктів.Код_населеного_пункту = Обвинувачуваний.Код_населеного_пункту) ON Довідник_районів.Код_району = Обвинувачуваний.Код_району) INNER JOIN ((Статті INNER JOIN Злочин ON Статті.[Код_статті] = Злочин.[Код_статті]) INNER JOIN Кримінальна_справа ON Злочин.[ІД_злочину] = Кримінальна_справа.[ІД_злочину]) ON Обвинувачуваний.ІПН_обвинувачуваного = Кримінальна_справа.ІПН_обвинуваченого WHERE ((" + SQLup1 + ") AND (" + SQLup2 + "));";
    UpdateData(SQL);

}*/


