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
using System.Diagnostics;
namespace Epidsys
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analys f123 = new Analys();
            f123.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog g = new OpenFileDialog();
            if (g.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mystream = g.OpenFile()) !=null)
                {
                    string s = g.FileName;
                    string f = File.ReadAllText(s);
                    richTextBox1.Text = f;
                }
            }

        }

        
    }
}
