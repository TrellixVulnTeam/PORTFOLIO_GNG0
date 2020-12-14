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
    public partial class Form6 : Form
    {
        public string test3 = Form1.test2.ToString();


        public List<Button> btns = new List<Button>();
        public Form6()
        {
            InitializeComponent();
            int num = 0;
            Text = "4번칸";
            train_4.BackColor = Color.Green;

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

            for (int i = 60; i < 80; i++)
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

        private void button_chair60_Click(object sender, EventArgs e)
        {
            int a = 60;
            chair_reserve(a);
        }

        private void button_chair61_Click(object sender, EventArgs e)
        {
            int a = 61;
            chair_reserve(a);
        }

        private void button_chair62_Click(object sender, EventArgs e)
        {
            int a = 62;
            chair_reserve(a);
        }

        private void button_chair63_Click(object sender, EventArgs e)
        {
            int a = 63;
            chair_reserve(a);
        }

        private void button_chair64_Click(object sender, EventArgs e)
        {
            int a = 64;
            chair_reserve(a);
        }

        private void button_chair65_Click(object sender, EventArgs e)
        {
            int a = 65;
            chair_reserve(a);
        }

        private void button_chair66_Click(object sender, EventArgs e)
        {
            int a = 66;
            chair_reserve(a);
        }

        private void button_chair67_Click(object sender, EventArgs e)
        {
            int a = 67;
            chair_reserve(a);
        }

        private void button_chair68_Click(object sender, EventArgs e)
        {
            int a = 68;
            chair_reserve(a);
        }

        private void button_chair69_Click(object sender, EventArgs e)
        {
            int a = 69;
            chair_reserve(a);
        }

        private void button_chair70_Click(object sender, EventArgs e)
        {
            int a = 70;
            chair_reserve(a);
        }

        private void button_chair71_Click(object sender, EventArgs e)
        {
            int a = 71;
            chair_reserve(a);
        }

        private void button_chair72_Click(object sender, EventArgs e)
        {
            int a = 72;
            chair_reserve(a);
        }

        private void button_chair73_Click(object sender, EventArgs e)
        {
            int a = 73;
            chair_reserve(a);
        }

        private void button_chair74_Click(object sender, EventArgs e)
        {
            int a = 74;
            chair_reserve(a);
        }

        private void button_chair75_Click(object sender, EventArgs e)
        {
            int a = 75;
            chair_reserve(a);
        }

        private void button_chair76_Click(object sender, EventArgs e)
        {
            int a = 76;
            chair_reserve(a);
        }

        private void button_chair77_Click(object sender, EventArgs e)
        {
            int a = 77;
            chair_reserve(a);
        }

        private void button_chair78_Click(object sender, EventArgs e)
        {
            int a = 78;
            chair_reserve(a);
        }

        private void button_chair79_Click(object sender, EventArgs e)
        {
            int a = 79;
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
