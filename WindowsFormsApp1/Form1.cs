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
        int diamond = 5;
        public EventHandler<EventArgs> DiamondClick { get; set; }
        public EventHandler<EventArgs> DiamondClickDouble { get; set; }

        public List<Students> Students { get; set; }
        public Form1()
        {
            InitializeComponent();

            DiamondClick = new EventHandler<EventArgs>(Diamond);

            DiamondClickDouble = new EventHandler<EventArgs>(DiamondSubtract);

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
                uc.DiamondClicked = DiamondClick;
                uc.DiamondClickedDouble = DiamondClickDouble;
                uc.Fullname = item.FullName;
                uc.History = item.History;
                uc.Index = count;
                count += 1;
                uc.Location = new Point(0, y);
                y += 100;
                this.Controls.Add(uc);
            }
        }

        private void Diamond(object sender, EventArgs e)
        {
            if (diamond > 0)
            {
                --diamond;
                DiamondCountLbl.Text = diamond.ToString();
            }
        }

        private void DiamondSubtract(object sender, EventArgs e)
        {
            if (diamond < 5)
            {
                ++diamond;
                DiamondCountLbl.Text = diamond.ToString();
            }
        }

        public bool IcClicked { get; set; } = false;
        Label label = new Label();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IcClicked)
            {
                label.Text = guna2TextBox.Text;
                guna2TextBox.Text = string.Empty;
            }
            else
            {
                label.Text = guna2TextBox1.Text;
            }
            label.Location = new Point(990, 65);
            label.Font = new Font("Oblique", 12);
            label.ForeColor = Color.Gray;
            this.Controls.Remove(guna2TextBox);
            this.Controls.Add(label);
            guna2TextBox1.Dispose();
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

        Guna2TextBox guna2TextBox = new Guna2TextBox();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            IcClicked = true;
            guna2TextBox.Location = new Point(879, 90);
            guna2TextBox.ForeColor = Color.Black;
            guna2TextBox.Width = 300;
            guna2TextBox.Height = 58;
            this.Controls.Remove(label);
            this.Controls.Add((Control)guna2TextBox);
            guna2TextBox1.Enabled = true;
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }
        public bool IsGreenRadioBtnClicked { get; set; } = false;
        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is UserControl1 uc)
                {
                    uc.GreenBtn.Checked = true;
                }
            }
        }
    }
}
