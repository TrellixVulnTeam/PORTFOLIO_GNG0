namespace MESProject.View
{
    partial class UCInsertWorkOrder
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlbWorkOrder = new System.Windows.Forms.TableLayoutPanel();
            this.tbNull = new System.Windows.Forms.TextBox();
            this.lbNull = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbOrderTime = new System.Windows.Forms.Label();
            this.lbTimeLimit = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbOrnerName = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbOrnerName = new System.Windows.Forms.TextBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnOrderInsert = new System.Windows.Forms.Panel();
            this.lbOrderInsert = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnOrderList = new System.Windows.Forms.Panel();
            this.btnUpdateTrue = new System.Windows.Forms.Button();
            this.lbConfirmOrder = new System.Windows.Forms.Label();
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.oD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateFalse = new System.Windows.Forms.Button();
            this.tlbWorkOrder.SuspendLayout();
            this.pnOrderInsert.SuspendLayout();
            this.pnOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(833, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tlbWorkOrder
            // 
            this.tlbWorkOrder.ColumnCount = 4;
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21967F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.58876F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21967F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9719F));
            this.tlbWorkOrder.Controls.Add(this.tbNull, 3, 5);
            this.tlbWorkOrder.Controls.Add(this.lbNull, 2, 5);
            this.tlbWorkOrder.Controls.Add(this.lbCount, 2, 4);
            this.tlbWorkOrder.Controls.Add(this.tbCount, 3, 4);
            this.tlbWorkOrder.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tlbWorkOrder.Controls.Add(this.lbOrderTime, 0, 0);
            this.tlbWorkOrder.Controls.Add(this.lbTimeLimit, 0, 3);
            this.tlbWorkOrder.Controls.Add(this.dateTimePicker2, 1, 3);
            this.tlbWorkOrder.Controls.Add(this.lbProductName, 2, 3);
            this.tlbWorkOrder.Controls.Add(this.lbCustomer, 2, 0);
            this.tlbWorkOrder.Controls.Add(this.lbOrnerName, 2, 1);
            this.tlbWorkOrder.Controls.Add(this.tbCustomer, 3, 0);
            this.tlbWorkOrder.Controls.Add(this.tbOrnerName, 3, 1);
            this.tlbWorkOrder.Controls.Add(this.cbProductName, 3, 3);
            this.tlbWorkOrder.Location = new System.Drawing.Point(140, 47);
            this.tlbWorkOrder.Name = "tlbWorkOrder";
            this.tlbWorkOrder.RowCount = 6;
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlbWorkOrder.Size = new System.Drawing.Size(975, 228);
            this.tlbWorkOrder.TabIndex = 20;
            // 
            // tbNull
            // 
            this.tbNull.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNull.Location = new System.Drawing.Point(646, 193);
            this.tbNull.Name = "tbNull";
            this.tbNull.Size = new System.Drawing.Size(226, 25);
            this.tbNull.TabIndex = 16;
            // 
            // lbNull
            // 
            this.lbNull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbNull.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNull.Location = new System.Drawing.Point(488, 190);
            this.lbNull.Name = "lbNull";
            this.lbNull.Size = new System.Drawing.Size(120, 32);
            this.lbNull.TabIndex = 9;
            this.lbNull.Text = "비고란 :";
            this.lbNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCount
            // 
            this.lbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(488, 152);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(120, 32);
            this.lbCount.TabIndex = 12;
            this.lbCount.Text = "수량 :";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCount.Location = new System.Drawing.Point(646, 155);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(226, 25);
            this.tbCount.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 25);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lbOrderTime
            // 
            this.lbOrderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbOrderTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderTime.Location = new System.Drawing.Point(3, 0);
            this.lbOrderTime.Name = "lbOrderTime";
            this.lbOrderTime.Size = new System.Drawing.Size(120, 32);
            this.lbOrderTime.TabIndex = 0;
            this.lbOrderTime.Text = "작업지시일";
            this.lbOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeLimit
            // 
            this.lbTimeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbTimeLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLimit.Location = new System.Drawing.Point(3, 114);
            this.lbTimeLimit.Name = "lbTimeLimit";
            this.lbTimeLimit.Size = new System.Drawing.Size(120, 32);
            this.lbTimeLimit.TabIndex = 10;
            this.lbTimeLimit.Text = "작업기한일 :";
            this.lbTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 25);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(488, 114);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(120, 32);
            this.lbProductName.TabIndex = 8;
            this.lbProductName.Text = "제품명 :";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCustomer
            // 
            this.lbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(488, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(120, 32);
            this.lbCustomer.TabIndex = 11;
            this.lbCustomer.Text = "납품처 :";
            this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrnerName
            // 
            this.lbOrnerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbOrnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrnerName.Location = new System.Drawing.Point(488, 38);
            this.lbOrnerName.Name = "lbOrnerName";
            this.lbOrnerName.Size = new System.Drawing.Size(120, 32);
            this.lbOrnerName.TabIndex = 7;
            this.lbOrnerName.Text = "지시담당자 :";
            this.lbOrnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(646, 3);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(226, 25);
            this.tbCustomer.TabIndex = 18;
            // 
            // tbOrnerName
            // 
            this.tbOrnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrnerName.Location = new System.Drawing.Point(646, 41);
            this.tbOrnerName.Name = "tbOrnerName";
            this.tbOrnerName.Size = new System.Drawing.Size(226, 25);
            this.tbOrnerName.TabIndex = 14;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Items.AddRange(new object[] {
            "light_001",
            "light_002",
            "light_003"});
            this.cbProductName.Location = new System.Drawing.Point(646, 117);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(226, 20);
            this.cbProductName.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(932, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnOrderInsert
            // 
            this.pnOrderInsert.BackColor = System.Drawing.Color.White;
            this.pnOrderInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOrderInsert.Controls.Add(this.lbOrderInsert);
            this.pnOrderInsert.Controls.Add(this.btnClear);
            this.pnOrderInsert.Controls.Add(this.tlbWorkOrder);
            this.pnOrderInsert.Controls.Add(this.btnAdd);
            this.pnOrderInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOrderInsert.Location = new System.Drawing.Point(0, 0);
            this.pnOrderInsert.Name = "pnOrderInsert";
            this.pnOrderInsert.Size = new System.Drawing.Size(1160, 332);
            this.pnOrderInsert.TabIndex = 0;
            // 
            // lbOrderInsert
            // 
            this.lbOrderInsert.AutoSize = true;
            this.lbOrderInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderInsert.Location = new System.Drawing.Point(10, 10);
            this.lbOrderInsert.Name = "lbOrderInsert";
            this.lbOrderInsert.Size = new System.Drawing.Size(64, 17);
            this.lbOrderInsert.TabIndex = 22;
            this.lbOrderInsert.Text = "지시 입력";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(932, 291);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(80, 35);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "업로드";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // pnOrderList
            // 
            this.pnOrderList.BackColor = System.Drawing.Color.White;
            this.pnOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOrderList.Controls.Add(this.btnUpdateTrue);
            this.pnOrderList.Controls.Add(this.lbConfirmOrder);
            this.pnOrderList.Controls.Add(this.dgvWorkOrder);
            this.pnOrderList.Controls.Add(this.btnUpload);
            this.pnOrderList.Controls.Add(this.btnUpdateFalse);
            this.pnOrderList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOrderList.Location = new System.Drawing.Point(0, 338);
            this.pnOrderList.Name = "pnOrderList";
            this.pnOrderList.Size = new System.Drawing.Size(1160, 343);
            this.pnOrderList.TabIndex = 1;
            // 
            // btnUpdateTrue
            // 
            this.btnUpdateTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnUpdateTrue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateTrue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTrue.Location = new System.Drawing.Point(846, 291);
            this.btnUpdateTrue.Name = "btnUpdateTrue";
            this.btnUpdateTrue.Size = new System.Drawing.Size(80, 35);
            this.btnUpdateTrue.TabIndex = 24;
            this.btnUpdateTrue.Text = "수정";
            this.btnUpdateTrue.UseVisualStyleBackColor = false;
            this.btnUpdateTrue.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbConfirmOrder
            // 
            this.lbConfirmOrder.AutoSize = true;
            this.lbConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmOrder.Location = new System.Drawing.Point(10, 10);
            this.lbConfirmOrder.Name = "lbConfirmOrder";
            this.lbConfirmOrder.Size = new System.Drawing.Size(64, 17);
            this.lbConfirmOrder.TabIndex = 23;
            this.lbConfirmOrder.Text = "지시 확인";
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oD,
            this.eN,
            this.dD,
            this.pN,
            this.pQ,
            this.cC,
            this.rm});
            this.dgvWorkOrder.Location = new System.Drawing.Point(140, 27);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.ReadOnly = true;
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(872, 258);
            this.dgvWorkOrder.TabIndex = 23;
            this.dgvWorkOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrder_CellValueChanged);
            this.dgvWorkOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvWorkOrder_MouseUp);
            // 
            // oD
            // 
            this.oD.HeaderText = "지시일";
            this.oD.Name = "oD";
            this.oD.ReadOnly = true;
            // 
            // eN
            // 
            this.eN.HeaderText = "지시담당자";
            this.eN.Name = "eN";
            this.eN.ReadOnly = true;
            // 
            // dD
            // 
            this.dD.HeaderText = "기한일";
            this.dD.Name = "dD";
            this.dD.ReadOnly = true;
            // 
            // pN
            // 
            this.pN.HeaderText = "제품명";
            this.pN.Name = "pN";
            this.pN.ReadOnly = true;
            // 
            // pQ
            // 
            this.pQ.HeaderText = "수량";
            this.pQ.Name = "pQ";
            this.pQ.ReadOnly = true;
            // 
            // cC
            // 
            this.cC.HeaderText = "납품처";
            this.cC.Name = "cC";
            this.cC.ReadOnly = true;
            // 
            // rm
            // 
            this.rm.HeaderText = "비고란";
            this.rm.Name = "rm";
            this.rm.ReadOnly = true;
            // 
            // btnUpdateFalse
            // 
            this.btnUpdateFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnUpdateFalse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateFalse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFalse.Location = new System.Drawing.Point(846, 291);
            this.btnUpdateFalse.Name = "btnUpdateFalse";
            this.btnUpdateFalse.Size = new System.Drawing.Size(80, 35);
            this.btnUpdateFalse.TabIndex = 23;
            this.btnUpdateFalse.Text = "수정불가";
            this.btnUpdateFalse.UseVisualStyleBackColor = false;
            this.btnUpdateFalse.Visible = false;
            this.btnUpdateFalse.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UCInsertWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnOrderList);
            this.Controls.Add(this.pnOrderInsert);
            this.Name = "UCInsertWorkOrder";
            this.Size = new System.Drawing.Size(1160, 681);
            this.tlbWorkOrder.ResumeLayout(false);
            this.tlbWorkOrder.PerformLayout();
            this.pnOrderInsert.ResumeLayout(false);
            this.pnOrderInsert.PerformLayout();
            this.pnOrderList.ResumeLayout(false);
            this.pnOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlbWorkOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbNull;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbOrnerName;
        private System.Windows.Forms.Label lbNull;
        private System.Windows.Forms.TextBox tbOrnerName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbOrderTime;
        private System.Windows.Forms.Label lbTimeLimit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnOrderInsert;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel pnOrderList;
        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn oD;
        private System.Windows.Forms.DataGridViewTextBoxColumn eN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dD;
        private System.Windows.Forms.DataGridViewTextBoxColumn pN;
        private System.Windows.Forms.DataGridViewTextBoxColumn pQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn cC;
        private System.Windows.Forms.DataGridViewTextBoxColumn rm;
        private System.Windows.Forms.Label lbOrderInsert;
        private System.Windows.Forms.Label lbConfirmOrder;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Button btnUpdateFalse;
        private System.Windows.Forms.Button btnUpdateTrue;
    }
}
