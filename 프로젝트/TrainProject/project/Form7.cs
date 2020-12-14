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
    public partial class Form7 : Form
    {
        public string test3 = Form1.test2.ToString();


        public List<Button> btns = new List<Button>();
        public Form7()
        {
            InitializeComponent();
            int num = 0;
            Text = "5번칸";
            train_5.BackColor = Color.Green;

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

            for (int i = 80; i < 100; i++)
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

                        item.BackColor =SystemColors.ButtonFace;//item은 버튼 해당 버튼의 색을 변경하고
                        break;//foreach문을 탈출한다.//이중포문 다시 for문으로 돌아가서 실행
                    }
                }
            }
            this.Visible = false;
        }

        private void button_chair80_Click(object sender, EventArgs e)
        {
            int a = 80;
            chair_reserve(a);
        }

        private void button_chair81_Click(object sender, EventArgs e)
        {
            int a = 81;
            chair_reserve(a);
        }

        private void button_chair82_Click(object sender, EventArgs e)
        {
            int a = 82;
            chair_reserve(a);
        }

        private void button_chair83_Click(object sender, EventArgs e)
        {
            int a = 83;
            chair_reserve(a);
        }

        private void button_chair84_Click(object sender, EventArgs e)
        {
            int a = 84;
            chair_reserve(a);
        }

        private void button_chair85_Click(object sender, EventArgs e)
        {
            int a = 85;
            chair_reserve(a);
        }

        private void button_chair86_Click(object sender, EventArgs e)
        {
            int a = 86;
            chair_reserve(a);
        }

        private void button_chair87_Click(object sender, EventArgs e)
        {
            int a = 87;
            chair_reserve(a);
        }

        private void button_chair88_Click(object sender, EventArgs e)
        {
            int a = 88;
            chair_reserve(a);
        }

        private void button_chair89_Click(object sender, EventArgs e)
        {
            int a = 89;
            chair_reserve(a);
        }

        private void button_chair90_Click(object sender, EventArgs e)
        {
            int a = 90;
            chair_reserve(a);
        }

        private void button_chair91_Click(object sender, EventArgs e)
        {
            int a = 91;
            chair_reserve(a);
        }

        private void button_chair92_Click(object sender, EventArgs e)
        {
            int a = 92;
            chair_reserve(a);
        }

        private void button_chair93_Click(object sender, EventArgs e)
        {
            int a = 93;
            chair_reserve(a);
        }

        private void button_chair94_Click(object sender, EventArgs e)
        {
            int a = 94;
            chair_reserve(a);
        }

        private void button_chair95_Click(object sender, EventArgs e)
        {
            int a = 95;
            chair_reserve(a);
        }

        private void button_chair96_Click(object sender, EventArgs e)
        {
            int a = 96;
            chair_reserve(a);
        }

        private void button_chair97_Click(object sender, EventArgs e)
        {
            int a = 97;
            chair_reserve(a);
        }

        private void button_chair98_Click(object sender, EventArgs e)
        {
            int a = 98;
            chair_reserve(a);
        }

        private void button_chair99_Click(object sender, EventArgs e)
        {
            int a = 99;
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
