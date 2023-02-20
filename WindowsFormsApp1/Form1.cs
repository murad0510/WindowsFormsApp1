using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Students> Students { get; set; }
        public Form1()
        {
            InitializeComponent();
            guna2HtmlLabel1.Text = "FSDM_3912_az(Основы разработки приложений с использованием Windows Forms и WPF(CT - 3)))";

            

            Students = new List<Students>
            {
                new Students
                {
                    FullName="Mehemmet Mehemmedov Mehemmed"
                },
                new Students
                {
                    FullName="osiudgsjidfg"
                },
                new Students
                {
                    FullName="sjkdfdsdfgd"
                }
            };

            int y = 300;
            foreach (var item in Students)
            {
                var uc = new UserControl1();
                uc.Fullname = item.FullName;
                uc.Location=new Point(0, y);
                y += 100;
                this.Controls.Add(uc);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
