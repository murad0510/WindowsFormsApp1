using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UserControl1 uc;
        static int count = 1;
        public List<Students> Students { get; set; }
        public Form1()
        {
            InitializeComponent();
            guna2HtmlLabel1.Text = "FSDM_3912_az(Основы разработки приложений с использованием Windows Forms и WPF(CT - 3)))";

            Students = new List<Students>
            {
                new Students
                {
                    FullName="John Johnlu Bob",
                    History="12/03/2023",
                },
                new Students
                {
                    FullName="Mike Tyson Bob",
                    History="4/09/2023",
                },
                new Students
                {
                    FullName="Orxan Qurbanov Bob",
                    History="6/09/2022",
                }
            };
            int y = 250;

            foreach (var item in Students)
            {
                uc = new UserControl1();
                
                uc.Fullname = item.FullName;
                uc.History = item.History;
                uc.Index = count;
                count += 1;
                uc.Location = new Point(0, y);
                y += 100;
                this.Controls.Add(uc);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is UserControl1 uc)
                {
                    uc.Enabled = true;
                }
            }
            guna2TextBox1.Enabled = true;
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            guna2HtmlLabel2.Enabled = true;
            guna2PictureBox1.Enabled = true;

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is UserControl1 uc)
                {
                    uc.Enabled = true;
                }
            }
            guna2TextBox1.Enabled = true;
            guna2Button1.Enabled = true;
            guna2Button2.Enabled = true;
            guna2Button3.Enabled = true;
            guna2HtmlLabel2.Enabled = true;
            guna2PictureBox1.Enabled = true;
        }
    }
}
