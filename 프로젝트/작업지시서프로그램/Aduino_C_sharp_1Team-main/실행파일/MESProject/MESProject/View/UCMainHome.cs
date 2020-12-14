using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MESProject.DBConnect;

namespace MESProject.View
{
    public partial class UCMainHome : UserControl
    {
        public UCMainHome()
        {
            InitializeComponent();

            chartData.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartData.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        }

        public DataSet GetTblWork()
        {
            SqlConnection conn = DataSources.getConnection();
            // 임시 지시서데이터로 출력 - 수정필
            SqlCommand cmd = new SqlCommand
                ("select productName, sum (productionQuantity) from OrderTable group by productName;", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            DataSources.setClose();
            return ds;
        }

        int[] ledCnt = new int[3];
        int i = 0;
        int sumCnt = 0;
        float perCnt1 = 0;
        float perCnt2 = 0;
        float perCnt3 = 0;

        private void UCMainHome_Load(object sender, EventArgs e)  //은수 ->진영->은수
        {
            try
            {
                //제품명 리스트에 담아 비교 "light_001", "light_002", "light_003"
                List<string> pLightList = new List<string> { "light_001", "light_002", "light_003" };
                DataSet ds = GetTblWork();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // 데이터베이스 칼럼 수정필
                    if (pLightList.Contains(row[0].ToString()))
                    {
                        ledCnt[i++] = int.Parse(row[1].ToString());
                        chartData.Series[0].Points.AddXY(row[0], row[1]);
                    }
                }

                sumCnt = ledCnt[0] + ledCnt[1] + ledCnt[2];

                perCnt1 = float.Parse(ledCnt[0].ToString()) / float.Parse(sumCnt.ToString());
                perCnt2 = float.Parse(ledCnt[1].ToString()) / float.Parse(sumCnt.ToString());
                perCnt3 = float.Parse(ledCnt[2].ToString()) / float.Parse(sumCnt.ToString());

                lbProductCount1.Text = ledCnt[0].ToString("N0"); //0,000 자리별 , 표시
                lbProductCount2.Text = ledCnt[1].ToString("N0");
                lbProductCount3.Text = ledCnt[2].ToString("N0");

                lbProductPercent1.Text = string.Format("{0:P1}", perCnt1);
                lbProductPercent2.Text = string.Format("{0:P1}", perCnt2);
                lbProductPercent3.Text = string.Format("{0:P1}", perCnt3);

                lbTotalCount.Text = sumCnt.ToString("N0");
                lbTotalPercent.Text = string.Format("{0:P1}", perCnt1 + perCnt2 + perCnt3);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("동작");
            chartData.Series[0].Points.Clear();
            DataSet ds = GetTblWork();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // 데이터베이스 칼럼 수정필
                //Console.WriteLine(row[4].ToString() + row[5].ToString() + "");
                chartData.Series[0].Points.AddXY(row[0], row[1]);
            }
        }
    }
}
