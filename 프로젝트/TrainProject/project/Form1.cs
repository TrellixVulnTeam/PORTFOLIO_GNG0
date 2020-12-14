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

namespace project
{
    
    public partial class Form1 : Form
    {
      
        public static string test2;

        public Form1()
        {
            InitializeComponent();
            Text = "기차 예약 프로그램";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {//출발,도착역 조회
            int count_StartRoute = 0;
            int count_EndRoute = 0;
            string tbox1 = textBox1.Text;
            string tbox2 = textBox2.Text;
            foreach (var item in DataManager.Trains)
            {
                if (item.startroute == tbox1)
                    count_StartRoute++;
                if (item.endroute == tbox2)
                    count_EndRoute++;
            }
            if(count_StartRoute==0)
            {
                MessageBox.Show("잘못된 출발역을 입력하셨습니다.");
            }
            else if(count_EndRoute==0)
            {
                MessageBox.Show("잘못된 도착역을 입력하셨습니다.");
            }
            else if( (count_EndRoute>0) && (count_StartRoute>0) )
            {
                maingrid.DataSource = null;
                DataManager.Find(tbox1, tbox2);
                maingrid.DataSource = DataManager.Search;
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {//전체조회기능

            Form2 temp = new Form2();
            temp.ShowDialog();
            //DataManager.Load();

        }

        private void button_buy_Click(object sender, EventArgs e)
        {//예매


            try
            {
                int.TryParse(textbox_clicknumber.Text, out DataManager.test1);
                DataManager.Reserve();
                test2 = DataManager.Reservationing[DataManager.test1 - 1].reserve.ToString();

                Form3 temp = new Form3();
                temp.ShowDialog();
            }
            catch
            {
                MessageBox.Show("잘못된 기차번호를 입력하셨습니다.");
            }

        }

        private void maingrid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                MyTrain clicktonumber = maingrid.CurrentRow.DataBoundItem as MyTrain;
                textbox_clicknumber.Text = clicktonumber.trainname.ToString();
            }
            catch (Exception)
            {
            }

        }


    }
}
