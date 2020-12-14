using MESProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            UCMainHome uCMainHome = new UCMainHome();
            UCInsertWorkOrder uCInsertWorkOrder = new UCInsertWorkOrder();
            UCSelectWorkOrder uCSelectWorkOrder = new UCSelectWorkOrder();
            UCSelectWorkComplete uCSelectWorkComplete = new UCSelectWorkComplete();
            InitializeComponent();

            // 현재시간 함수 호출 - 이은수
            timer1_Tick(null, null);
         }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucMainHome1.BringToFront();

            // 버튼 클릭시 색상 변화
            this.btnHome.BackColor = Design.DesignBinding.DarkGray;
            this.btnWOinsert.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWOSelect.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWCSelect.BackColor = Design.DesignBinding.LiteGray; ;

        }

        private void btnWOinsert_Click(object sender, EventArgs e)
        {
            ucInsertWorkOrder1.BringToFront();

            this.btnHome.BackColor = Design.DesignBinding.LiteGray;
            this.btnWOinsert.BackColor = Design.DesignBinding.DarkGray; ;
            this.btnWOSelect.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWCSelect.BackColor = Design.DesignBinding.LiteGray; ;
        }

        private void btnWOSelect_Click(object sender, EventArgs e)
        {
            ucSelectWorkOrder1.BringToFront();

            this.btnHome.BackColor = Design.DesignBinding.LiteGray;
            this.btnWOinsert.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWOSelect.BackColor = Design.DesignBinding.DarkGray; ;
            this.btnWCSelect.BackColor = Design.DesignBinding.LiteGray; ;
        }

        private void btnWCSelect_Click(object sender, EventArgs e)
        {
            ucSelectWorkComplete1.BringToFront();

            this.btnHome.BackColor = Design.DesignBinding.LiteGray;
            this.btnWOinsert.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWOSelect.BackColor = Design.DesignBinding.LiteGray; ;
            this.btnWCSelect.BackColor = Design.DesignBinding.DarkGray; ;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 현재시간 타이머 - 이은수
            string s3 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lbNowDate.Text = s3;
        }
    }
}
