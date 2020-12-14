namespace project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myTrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTrainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myTrainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainnumberDataGridViewTextBoxColumn,
            this.trainnameDataGridViewTextBoxColumn,
            this.startrouteDataGridViewTextBoxColumn,
            this.endrouteDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myTrainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(746, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // myTrainBindingSource
            // 
            this.myTrainBindingSource.DataSource = typeof(project.MyTrain);
            // 
            // myTrainBindingSource1
            // 
            this.myTrainBindingSource1.DataSource = typeof(project.MyTrain);
            // 
            // myTrainBindingSource2
            // 
            this.myTrainBindingSource2.DataSource = typeof(project.MyTrain);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTrainBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource myTrainBindingSource;
        private System.Windows.Forms.BindingSource myTrainBindingSource1;
        private System.Windows.Forms.BindingSource myTrainBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
    }
}