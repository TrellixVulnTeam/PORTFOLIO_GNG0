using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace project
{
    public partial class Form3 : Form
    {

        //test2는 현재train의 좌석예약현황 100개의숫자로된 문자열
        public string test3 = Form1.test2.ToString();//test2는 문자열인데 왜 ToString?
       
        //button타입의 리스트를 선언하였다.
        public List<Button> btns = new List<Button>();
        public Form3()
        {
            InitializeComponent();
            int num = 0;
            Text = "1번칸";
            train_1.BackColor = Color.Green;

            foreach (var item in Controls) //Form3에 있는 모든 컨트롤들 중에서...
            {
                if (item is Button) //Button인 애들 중에서...
                {
                    if ((item as Button).Name.Contains("button_chair")) //이름에 button_chair가포함 되어있으면... 
                    {
                        btns.Add(item as Button);//이름에 button_chair이 포함되어잇는 객체를 btns에 저장한다.
                                                 //btns의 타입이 버튼이기때문에 가능.
                    }

                }
            }

            for (int i = 0; i < 20; i++)
            {
                //1번칸이면 0~20미만
                //2번칸이면 20부터 40미만
                //~~~

                if (test3[i] == '1')
                {//test3는 문자열이다.
                 //test3[i]는 문자로서 하나의 문자만 가져온다
                 //'1'은 예약이 되어있다는 의미.
                 //예약이 되어있다면.

                    foreach (var item in btns)
                    {
                        if (item.Name.Replace("button_chair", "") == i.ToString())//이게 어떤건지 잘 모르겠다.
                        {

                            item.BackColor = Color.Blue;//item은 버튼 해당 버튼의 색을 변경하고
                            break;//foreach문을 탈출한다.//이중포문 다시 for문으로 돌아가서 실행
                        }
                    }


                }
            }

        }

        public void chair_reserve(int a)//좌석 예약 메서드
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
        private void button_chair0_Click(object sender, EventArgs e)
        {
            int a = 0;
            chair_reserve(a);
            //string tempString = Form1.test2.ToString();//test2에있는 100개의숫자(좌석현황)을 tempString에 할당
            //StringBuilder sss = new StringBuilder(tempString);//

            //if (sss[0] == '0')
            //{
            //    if (MessageBox.Show("예약 하시겠습니까?", "예약창", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {//예약창에서 Yes버튼을 눌렀을시 실행된다(예약한다고 했을때 실행된다)

            //        //100개의 숫자중 0번째 자리
            //        sss[0] = '1';
            //        tempString = sss.ToString();
            //        //tempStirng은 100개의 숫자로 이루어진 문자열이다.
            //        //그 중 tempString[0]째 자리의 문자를 바꾸고싶을때
            //        //StringBuilder를 사용한다.
            //        //지금0번째 좌석을 예약 한 것 이기때문에 sss[0]의 문자를 1로변경해주면
            //        //tempString[0]자리가바뀐상태의 데이터가 저장되어있다..

            //        //DataManager.test1 = trainnumber을 int타입을 변경시킨것.
            //        //0번째 리스트에 1번기차가 들어가있어서 -1을 해준것임.
            //        //그중 reserve 라는데이터를 변경시킨다.
            //        //변경시킨 데이터를 xml에 저장한다.
            //        DataManager.Reservationing[DataManager.test1 - 1].reserve = tempString;
            //        DataManager.Reserve_Save();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("이미 예약된 좌석입니다.");
            //}

        }
        private void button_chair1_Click(object sender, EventArgs e)
        {
            int a = 1;
            chair_reserve(a);
           
        }


        private void button_chair2_Click(object sender, EventArgs e)
        {
            int a = 2;
            chair_reserve(a);
        }

        private void button_chair3_Click(object sender, EventArgs e)
        {
            int a = 3;
            chair_reserve(a);
        }

        private void button_chair4_Click(object sender, EventArgs e)
        {
            int a = 4;
            chair_reserve(a);
        }

        private void button_chair5_Click(object sender, EventArgs e)
        {
            int a = 5;
            chair_reserve(a);
        }

        private void button_chair6_Click(object sender, EventArgs e)
        {
            int a = 6;
            chair_reserve(a);
        }

        private void button_chair7_Click(object sender, EventArgs e)
        {
            int a = 7;
            chair_reserve(a);
        }

        private void button_chair8_Click(object sender, EventArgs e)
        {
            int a = 8;
            chair_reserve(a);
        }

        private void button_chair9_Click(object sender, EventArgs e)
        {
            int a = 9;
            chair_reserve(a);
        }

        private void button_chair10_Click(object sender, EventArgs e)
        {
            int a = 10;
            chair_reserve(a);
        }

        private void button_chair11_Click(object sender, EventArgs e)
        {
            int a = 11;
            chair_reserve(a);
        }

        private void button_chair12_Click(object sender, EventArgs e)
        {
            int a = 12;
            chair_reserve(a);
        }

        private void button_chair13_Click(object sender, EventArgs e)
        {
            int a = 13;
            chair_reserve(a);
        }

        private void button_chair14_Click(object sender, EventArgs e)
        {
            int a = 14;
            chair_reserve(a);
        }

        private void button_chair15_Click(object sender, EventArgs e)
        {
            int a = 15;
            chair_reserve(a);
        }

        private void button_chair16_Click(object sender, EventArgs e)
        {
            int a = 16;
            chair_reserve(a);
        }

        private void button_chair17_Click(object sender, EventArgs e)
        {
            int a = 17;
            chair_reserve(a);
        }

        private void button_chair18_Click(object sender, EventArgs e)
        {
            int a = 18;
            chair_reserve(a);
        }

        private void button_chair19_Click(object sender, EventArgs e)
        {
            int a = 19;
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