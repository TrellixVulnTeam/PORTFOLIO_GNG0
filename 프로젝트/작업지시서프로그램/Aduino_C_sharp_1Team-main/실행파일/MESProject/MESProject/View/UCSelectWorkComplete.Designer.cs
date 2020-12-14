namespace MESProject.View
{
    partial class UCSelectWorkComplete
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvWCSelect = new System.Windows.Forms.DataGridView();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.lbBlank = new System.Windows.Forms.Label();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWCSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(852, 61);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(82, 25);
            this.cbSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1087, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(940, 61);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 25);
            this.tbSearch.TabIndex = 10;
            // 
            // dgvWCSelect
            // 
            this.dgvWCSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWCSelect.Location = new System.Drawing.Point(3, 92);
            this.dgvWCSelect.Name = "dgvWCSelect";
            this.dgvWCSelect.RowTemplate.Height = 23;
            this.dgvWCSelect.Size = new System.Drawing.Size(1154, 556);
            this.dgvWCSelect.TabIndex = 9;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Location = new System.Drawing.Point(3, 61);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(226, 25);
            this.dtpFirstDate.TabIndex = 14;
            this.dtpFirstDate.ValueChanged += new System.EventHandler(this.dtpFirstDate_ValueChanged);
            // 
            // lbBlank
            // 
            this.lbBlank.AutoSize = true;
            this.lbBlank.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlank.Location = new System.Drawing.Point(235, 67);
            this.lbBlank.Name = "lbBlank";
            this.lbBlank.Size = new System.Drawing.Size(13, 17);
            this.lbBlank.TabIndex = 15;
            this.lbBlank.Text = "-";
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondDate.Location = new System.Drawing.Point(254, 61);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(226, 25);
            this.dtpSecondDate.TabIndex = 16;
            this.dtpSecondDate.ValueChanged += new System.EventHandler(this.dtpSecondDate_ValueChanged);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(3, 41);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(128, 17);
            this.lbDate.TabIndex = 19;
            this.lbDate.Text = "날짜 (기본 한달기준)";
            // 
            // UCSelectWorkComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dtpSecondDate);
            this.Controls.Add(this.lbBlank);
            this.Controls.Add(this.dtpFirstDate);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvWCSelect);
            this.Name = "UCSelectWorkComplete";
            this.Size = new System.Drawing.Size(1160, 681);
            this.Load += new System.EventHandler(this.UCSelectWorkComplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWCSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvWCSelect;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.Label lbBlank;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.Label lbDate;
    }
}
