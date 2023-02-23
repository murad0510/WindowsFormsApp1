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
            RedRadioBtn.Checked = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void RedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ElaveQiymetComboBox.Enabled = false;
            guna2ComboBox2.Enabled = false;
            Dimamond1Btn.Enabled = false;
            Dimamond2Btn.Enabled = false;
            Dimamond3Btn.Enabled = false;
            SubtractRadioBtn.Enabled = false;

            //foreach (var item in this.Controls)
            //{
            //    if (item is UserControl1 uc)
            //    {
            //        uc.Enabled = false;
            //    }
            //}
        }

        private void YellowRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ElaveQiymetComboBox.Enabled = true;
            guna2ComboBox2.Enabled = true;
            Dimamond1Btn.Enabled = true;
            Dimamond2Btn.Enabled = true;
            Dimamond3Btn.Enabled = true;
            SubtractRadioBtn.Enabled = true;

            //foreach (var item in this.Controls)
            //{
            //    if (item is UserControl1 uc)
            //    {
            //        uc.GreenRadioBtn.Enabled = true;
            //    }
            //}
        }
        public bool IsClicDiamond1 { get; set; } = true;
        public bool IsClicDiamond2 { get; set; } = true;
        public bool IsClicDiamond3 { get; set; } = true;
        public EventHandler<EventArgs> DiamondClicked { get; set; }
        public EventHandler<EventArgs> DiamondClickedDouble { get; set; }
        private void Diamond1Btn_Click(object sender, EventArgs e)
        {
            if (IsClicDiamond1)
            {
                DiamondClicked.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_48;
                }
            }
            else
            {
                DiamondClickedDouble.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_24;
                }
            }

            IsClicDiamond1 = !IsClicDiamond1;
        }

        private void Diamond2Btn_Click(object sender, EventArgs e)
        {
            if(IsClicDiamond2 && IsClicDiamond1 == false)
            {
                DiamondClicked.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_48;
                }
            }
            else if (IsClicDiamond2 && IsClicDiamond1 == true)
            {
                IsClicDiamond1 = true;

                Diamond1Btn_Click(Dimamond1Btn, e);
                DiamondClicked.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_48;
                }
            }
            else
            {
                Diamond1Btn_Click(Dimamond1Btn, e);
                DiamondClickedDouble.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_24;
                }
            }

            IsClicDiamond2 = !IsClicDiamond2;
        }

        private void Diamond3Btn_Click(object sender, EventArgs e)
        {
            if (IsClicDiamond3 && IsClicDiamond1 == true && IsClicDiamond2 == true)
            {
                IsClicDiamond2 = true;

                Diamond2Btn_Click(Dimamond2Btn, e);

                DiamondClicked.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_48;
                }
            }
            else
            {
                Diamond2Btn_Click(Dimamond2Btn, e);

                DiamondClickedDouble.Invoke(sender, e);
                if (sender is Guna2Button btn)
                {
                    btn.BackgroundImage = Properties.Resources.icons8_diamond_24;
                }
            }

            IsClicDiamond3 = !IsClicDiamond3;
        }

        private void SubtractRadioBtn_Click(object sender, EventArgs e)
        {
            IsClicDiamond1 = false;
            IsClicDiamond2 = false;
            IsClicDiamond3 = false;

            Diamond3Btn_Click(Dimamond3Btn, e);
        }
    }
}
