using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESProject.cmdTable;

namespace MESProject.View
{
    public partial class UCSelectWorkComplete : UserControl
    {
        private DateTime tstart;
        private DateTime tend;
        private MssqlCmdTable mscmd = new MssqlCmdTable();

        public UCSelectWorkComplete()
        {
            InitializeComponent();

            cbSearch.Text = "종합";
            dtpFirstDate.Value = DateTime.Now.AddMonths(-1);
        }
        private void UCSelectWorkComplete_Load(object sender, EventArgs e)
        {
            // 기본화면 1달간 조회 상태로 만들기 위해
            dtpFirstDate.Value = DateTime.Now.AddMonths(-1);
            dtpSecondDate.Value = DateTime.Now;
            //dateTimePicker 날짜 표현 수정사항 
            dtpFirstDate.Format = DateTimePickerFormat.Custom;
            dtpFirstDate.CustomFormat = "yyyy-MM-dd-dddd";
            dtpSecondDate.Format = DateTimePickerFormat.Custom;
            dtpSecondDate.CustomFormat = "yyyy-MM-dd-dddd";

            //ComboBox 칼럼 추가
            cbSearch.Items.Add("종합");
            cbSearch.Items.Add("담당자");
            cbSearch.Items.Add("제품명");
            cbSearch.Items.Add("설비명");
            cbSearch.Items.Add("LOT 번호");
        }

        private void dtpFirstDate_ValueChanged(object sender, EventArgs e)
        {
            //2020-10-15 오전 11:34:26 -> 2020-10-15 오전 12:00:00
            this.tstart = dtpFirstDate.Value.Date;
            Console.WriteLine(this.tstart);
        }

        private void dtpSecondDate_ValueChanged(object sender, EventArgs e)
        {
            //2020-10-15 오전 11:34:26 -> 2020-10-16 오전 12:00:00
            this.tend = dtpSecondDate.Value.Date.AddDays(1);
            Console.WriteLine(this.tend);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string comtext = cbSearch.Text;
            string boxtext = tbSearch.Text;

            dgvWCSelect.DataSource = this.mscmd.doDataTableResult(this.tstart, this.tend, comtext, boxtext);
        }
    }
}
