namespace project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maingrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button_buy = new System.Windows.Forms.Button();
            this.textbox_clicknumber = new System.Windows.Forms.TextBox();
            this.trainnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myTrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maingrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 21);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maingrid);
            this.groupBox1.Location = new System.Drawing.Point(21, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 319);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // maingrid
            // 
            this.maingrid.AutoGenerateColumns = false;
            this.maingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maingrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainnumberDataGridViewTextBoxColumn,
            this.trainnameDataGridViewTextBoxColumn,
            this.startrouteDataGridViewTextBoxColumn,
            this.endrouteDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn});
            this.maingrid.DataSource = this.myTrainBindingSource;
            this.maingrid.Location = new System.Drawing.Point(10, 28);
            this.maingrid.Name = "maingrid";
            this.maingrid.RowTemplate.Height = 23;
            this.maingrid.Size = new System.Drawing.Size(746, 277);
            this.maingrid.TabIndex = 0;
            this.maingrid.CurrentCellChanged += new System.EventHandler(this.maingrid_CurrentCellChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "전체조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_buy
            // 
            this.button_buy.Location = new System.Drawing.Point(617, 18);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(91, 65);
            this.button_buy.TabIndex = 7;
            this.button_buy.Text = "예약";
            this.button_buy.UseVisualStyleBackColor = true;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // textbox_clicknumber
            // 
            this.textbox_clicknumber.Location = new System.Drawing.Point(470, 40);
            this.textbox_clicknumber.Name = "textbox_clicknumber";
            this.textbox_clicknumber.Size = new System.Drawing.Size(133, 21);
            this.textbox_clicknumber.TabIndex = 9;
            // 
            // trainnumberDataGridViewTextBoxColumn
            // 
            this.trainnumberDataGridViewTextBoxColumn.DataPropertyName = "trainnumber";
            this.trainnumberDataGridViewTextBoxColumn.HeaderText = "고유번호";
            this.trainnumberDataGridViewTextBoxColumn.Name = "trainnumberDataGridViewTextBoxColumn";
            // 
            // trainnameDataGridViewTextBoxColumn
            // 
            this.trainnameDataGridViewTextBoxColumn.DataPropertyName = "trainname";
            this.trainnameDataGridViewTextBoxColumn.HeaderText = "기차번호";
            this.trainnameDataGridViewTextBoxColumn.Name = "trainnameDataGridViewTextBoxColumn";
            // 
            // startrouteDataGridViewTextBoxColumn
            // 
            this.startrouteDataGridViewTextBoxColumn.DataPropertyName = "startroute";
            this.startrouteDataGridViewTextBoxColumn.HeaderText = "출발역";
            this.startrouteDataGridViewTextBoxColumn.Name = "startrouteDataGridViewTextBoxColumn";
            // 
            // endrouteDataGridViewTextBoxColumn
            // 
            this.endrouteDataGridViewTextBoxColumn.DataPropertyName = "endroute";
            this.endrouteDataGridViewTextBoxColumn.HeaderText = "도착역";
            this.endrouteDataGridViewTextBoxColumn.Name = "endrouteDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "starttime";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "endtime";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "도착시간";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // payDataGridViewTextBoxColumn
            // 
            this.payDataGridViewTextBoxColumn.DataPropertyName = "pay";
            this.payDataGridViewTextBoxColumn.HeaderText = "가격";
            this.payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            // 
            // myTrainBindingSource
            // 
            this.myTrainBindingSource.DataSource = typeof(project.MyTrain);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(project.Reservation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "기차번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_clicknumber);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maingrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView maingrid;
        private System.Windows.Forms.BindingSource myTrainBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_buy;
        private System.Windows.Forms.TextBox textbox_clicknumber;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}

