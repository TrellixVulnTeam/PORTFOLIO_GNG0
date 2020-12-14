using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form5 : Form
    {
        public string test3 = Form1.test2.ToString();


        public List<Button> btns = new List<Button>();
        public Form5()
        {
            InitializeComponent();
            int num = 0;
            Text = "3번칸";
            train_3.BackColor = Color.Green;

            foreach (var item in Controls)
            {
                if (item is Button)
                {
                    if ((item as Button).Name.Contains("button_chair"))
                    {
                        btns.Add(item as Button);
                    }

                }
            }

            for (int i = 40; i < 60; i++)
            {
                if (test3[i] == '1')
                {
                    foreach (var item in btns)
                    {
                        if (item.Name.Replace("button_chair", "") == i.ToString())
                        {
                            item.BackColor = Color.Blue;
                            break;
                        }
                    }
                }
            }
        }

        public void chair_reserve(int a)
        {
            string tempString = Form1.test2.ToString();
            StringBuilder sss = new StringBuilder(tempString);
            if (sss[a] == '0')
            {
                if (MessageBox.Show("예약 하시겠습니까?", "예약창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sss[a] = '1';
                    tempString = sss.ToString();
                    DataManager.Reservationing[DataManager.test1 - 1].reserve = tempString;
                    DataManager.Reserve_Save();
                    foreach (var item in btns)
                    {
                        if (item.Name.Replace("button_chair", "") == a.ToString())//이게 어떤건지 잘 모르겠다.
                        {

                            item.BackColor = Color.Blue;//item은 버튼 해당 버튼의 색을 변경하고
                            break;//foreach문을 탈출한다.//이중포문 다시 for문으로 돌아가서 실행
                        }
                    }
                }
            }
            else if (MessageBox.Show("취소하시겠습니까?", "예약창", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sss[a] = '0';
                tempString = sss.ToString();
                DataManager.Reservationing[DataManager.test1 - 1].reserve = tempString;
                DataManager.Reserve_Save();
                foreach (var item in btns)
                {
                    if (item.Name.Replace("button_chair", "") == a.ToString())//이게 어떤건지 잘 모르겠다.
                    {

                        item.BackColor = SystemColors.ButtonFace;//item은 버튼 해당 버튼의 색을 변경하고
                        break;//foreach문을 탈출한다.//이중포문 다시 for문으로 돌아가서 실행
                    }
                }
            }
            this.Visible = false;
        }

        private void button_chair40_Click(object sender, EventArgs e)
        {
            int a = 40;
            chair_reserve(a);
        }

        private void button_chair41_Click(object sender, EventArgs e)
        {
            int a = 41;
            chair_reserve(a);
        }

        private void button_chair42_Click(object sender, EventArgs e)
        {
            int a = 42;
            chair_reserve(a);
        }

        private void button_chair43_Click(object sender, EventArgs e)
        {
            int a = 43;
            chair_reserve(a);
        }

        private void button_chair44_Click(object sender, EventArgs e)
        {
            int a = 44;
            chair_reserve(a);
        }

        private void button_chair45_Click(object sender, EventArgs e)
        {
            int a = 45;
            chair_reserve(a);
        }

        private void button_chair46_Click(object sender, EventArgs e)
        {
            int a = 46;
            chair_reserve(a);
        }

        private void button_chair47_Click(object sender, EventArgs e)
        {
            int a = 47;
            chair_reserve(a);
        }

        private void button_chair48_Click(object sender, EventArgs e)
        {
            int a = 48;
            chair_reserve(a);
        }

        private void button_chair49_Click(object sender, EventArgs e)
        {
            int a = 49;
            chair_reserve(a);
        }

        private void button_chair50_Click(object sender, EventArgs e)
        {
            int a = 50;
            chair_reserve(a);
        }

        private void button_chair51_Click(object sender, EventArgs e)
        {
            int a = 51;
            chair_reserve(a);
        }

        private void button_chair52_Click(object sender, EventArgs e)
        {
            int a = 52;
            chair_reserve(a);
        }

        private void button_chair53_Click(object sender, EventArgs e)
        {
            int a = 53;
            chair_reserve(a);
        }

        private void button_chair54_Click(object sender, EventArgs e)
        {
            int a = 54;
            chair_reserve(a);
        }

        private void button_chair55_Click(object sender, EventArgs e)
        {
            int a = 55;
            chair_reserve(a);
        }

        private void button_chair56_Click(object sender, EventArgs e)
        {
            int a = 56;
            chair_reserve(a);
        }

        private void button_chair57_Click(object sender, EventArgs e)
        {
            int a = 57;
            chair_reserve(a);
        }

        private void button_chair58_Click(object sender, EventArgs e)
        {
            int a = 58;
            chair_reserve(a);
        }

        private void button_chair59_Click(object sender, EventArgs e)
        {
            int a = 59;
            chair_reserve(a);
        }

        private void train_1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void train_2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void train_3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void train_4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void train_5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}

