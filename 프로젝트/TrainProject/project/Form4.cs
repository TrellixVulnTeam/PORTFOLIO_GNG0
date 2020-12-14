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
    public partial class Form4 : Form
    {

        public string test3 = Form1.test2.ToString();


        public List<Button> btns = new List<Button>();
        public Form4()
        {
            InitializeComponent();
            int num = 0;
            Text = "2번칸";
            train_2.BackColor = Color.Green;

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

            for (int i = 20; i < 40; i++)
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

        private void button_chair20_Click(object sender, EventArgs e)
        {
            int a = 20;
            chair_reserve(a);
        }

        private void button_chair21_Click(object sender, EventArgs e)
        {
            int a = 21;
            chair_reserve(a);
        }

        private void button_chair22_Click(object sender, EventArgs e)
        {
            int a = 22;
            chair_reserve(a);
        }

        private void button_chair23_Click(object sender, EventArgs e)
        {
            int a = 23;
            chair_reserve(a);
        }

        private void button_chair24_Click(object sender, EventArgs e)
        {
            int a = 24;
            chair_reserve(a);
        }

        private void button_chair25_Click(object sender, EventArgs e)
        {
            int a = 25;
            chair_reserve(a);
        }

        private void button_chair26_Click(object sender, EventArgs e)
        {
            int a = 26;
            chair_reserve(a);
        }

        private void button_chair27_Click(object sender, EventArgs e)
        {
            int a = 27;
            chair_reserve(a);
        }

        private void button_chair28_Click(object sender, EventArgs e)
        {
            int a = 28;
            chair_reserve(a);
        }

        private void button_chair29_Click(object sender, EventArgs e)
        {
            int a = 29;
            chair_reserve(a);
        }

        private void button_chair30_Click(object sender, EventArgs e)
        {
            int a = 30;
            chair_reserve(a);
        }

        private void button_chair31_Click(object sender, EventArgs e)
        {
            int a = 31;
            chair_reserve(a);
        }

        private void button_chair32_Click(object sender, EventArgs e)
        {
            int a = 32;
            chair_reserve(a);
        }

        private void button_chair33_Click(object sender, EventArgs e)
        {
            int a = 33;
            chair_reserve(a);
        }

        private void button_chair34_Click(object sender, EventArgs e)
        {
            int a = 34;
            chair_reserve(a);
        }

        private void button_chair35_Click(object sender, EventArgs e)
        {
            int a = 35;
            chair_reserve(a);
        }

        private void button_chair36_Click(object sender, EventArgs e)
        {
            int a = 36;
            chair_reserve(a);
        }

        private void button_chair37_Click(object sender, EventArgs e)
        {
            int a = 37;
            chair_reserve(a);
        }

        private void button_chair38_Click(object sender, EventArgs e)
        {
            int a = 38;
            chair_reserve(a);
        }

        private void button_chair39_Click(object sender, EventArgs e)
        {
            int a = 39;
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

