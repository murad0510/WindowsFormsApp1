using Guna.UI2.WinForms;
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
    public partial class UserControl1 : UserControl
    {
        public string Fullname
        {
            get { return guna2HtmlLabel1.Text; }
            set { guna2HtmlLabel1.Text = value; }
        }

        public string History
        {
            get { return guna2HtmlLabel2.Text; }
            set { guna2HtmlLabel2.Text = value; }
        }

        public int Index
        {
            get { return int.Parse(IndexLbl.Text); }
            set { IndexLbl.Text = value.ToString(); }
        }

        List<int> studentsRate = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12
            };

        List<int> studentsRate2 = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12
            };

        public void AddCostList1()
        {
            ElaveQiymetComboBox.DataSource = studentsRate;  
            ElaveQiymetComboBox.SelectedIndex = -1;
        }

        public void AddCostList2()
        {
            guna2ComboBox2.DataSource = studentsRate2;
            guna2ComboBox2.SelectedIndex = -1;
        }

        public UserControl1()
        {
            InitializeComponent();
            AddCostList1();
            AddCostList2();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
