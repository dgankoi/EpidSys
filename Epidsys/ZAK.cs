using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Epidsys
{
    public partial class ZAK : Form
    {
        string Filepath = null;
        public ZAK()
        {
            InitializeComponent();
        }

        public ZAK(string[] file)
        {
            if (file.Length != 0)
            {
                Filepath = file[0];

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            if (svd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }

        }

        private void ZAK_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();


            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = OpenFile.ReadToEnd();
                OpenFile.Close();
            }
            catch
            {
                MessageBox.Show("Unknown Error, could not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                saveFileDialog1.ShowDialog();
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                SaveFile.WriteLine(richTextBox1.Text);
                SaveFile.Close();
            }
            catch
            {
                MessageBox.Show("Unknown Error, could not save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(openFileDialog1.FileName);
                SaveFile.WriteLine(richTextBox1.Text);
                SaveFile.Close();
            }
            catch
            {
                MessageBox.Show("Unknown Error, could not save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Analys f45f = new Analys();
            f45f.ShowDialog();
        }
    }
}
