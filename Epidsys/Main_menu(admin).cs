﻿using System;
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
    public partial class Main_menu_admin_ : Form
    {
        public Main_menu_admin_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBEnp f32 = new DBEnp();
            f32.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f332 = new Login();
            f332.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analys_adm f3 = new Analys_adm();
            f3.ShowDialog();
        }

        private void Main_menu_admin__Load(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog g = new OpenFileDialog();
            if (g.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mystream = g.OpenFile()) != null)
                {
                    string s = g.FileName;
                    string f = File.ReadAllText(s);
                    richTextBox1.Text = f;
                }
            }

        }
    }
}
