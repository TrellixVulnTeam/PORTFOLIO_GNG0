namespace MESProject
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.lbDBIP = new System.Windows.Forms.Label();
            this.lbNowDate = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbIPNum = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.ucMainHome1 = new MESProject.View.UCMainHome();
            this.ucSelectWorkOrder1 = new MESProject.View.UCSelectWorkOrder();
            this.ucSelectWorkComplete1 = new MESProject.View.UCSelectWorkComplete();
            this.ucInsertWorkOrder1 = new MESProject.View.UCInsertWorkOrder();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnWCSelect = new System.Windows.Forms.Button();
            this.btnWOSelect = new System.Windows.Forms.Button();
            this.btnWOinsert = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.pnLeft.Controls.Add(this.lbDBIP);
            this.pnLeft.Controls.Add(this.btnShutDown);
            this.pnLeft.Controls.Add(this.btnWCSelect);
            this.pnLeft.Controls.Add(this.btnWOSelect);
            this.pnLeft.Controls.Add(this.lbNowDate);
            this.pnLeft.Controls.Add(this.lbDate);
            this.pnLeft.Controls.Add(this.btnWOinsert);
            this.pnLeft.Controls.Add(this.lbIPNum);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Controls.Add(this.pnTop);
            this.pnLeft.Location = new System.Drawing.Point(12, 12);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(1160, 50);
            this.pnLeft.TabIndex = 0;
            // 
            // lbDBIP
            // 
            this.lbDBIP.AutoSize = true;
            this.lbDBIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBIP.ForeColor = System.Drawing.Color.White;
            this.lbDBIP.Location = new System.Drawing.Point(849, 24);
            this.lbDBIP.Name = "lbDBIP";
            this.lbDBIP.Size = new System.Drawing.Size(45, 17);
            this.lbDBIP.TabIndex = 4;
            this.lbDBIP.Text = "DB IP :";
            // 
            // lbNowDate
            // 
            this.lbNowDate.AutoSize = true;
            this.lbNowDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowDate.ForeColor = System.Drawing.Color.White;
            this.lbNowDate.Location = new System.Drawing.Point(922, 6);
            this.lbNowDate.Name = "lbNowDate";
            this.lbNowDate.Size = new System.Drawing.Size(126, 17);
            this.lbNowDate.TabIndex = 1;
            this.lbNowDate.Text = "2020-10-12 12:12:12";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(849, 6);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "현재시간 :";
            // 
            // lbIPNum
            // 
            this.lbIPNum.AutoSize = true;
            this.lbIPNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPNum.ForeColor = System.Drawing.Color.White;
            this.lbIPNum.Location = new System.Drawing.Point(968, 24);
            this.lbIPNum.Name = "lbIPNum";
            this.lbIPNum.Size = new System.Drawing.Size(80, 17);
            this.lbIPNum.TabIndex = 2;
            this.lbIPNum.Text = "192.168.0.19";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Controls.Add(this.lbProgramName);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(278, 50);
            this.pnTop.TabIndex = 1;
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.ForeColor = System.Drawing.Color.White;
            this.lbProgramName.Location = new System.Drawing.Point(6, 6);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(269, 32);
            this.lbProgramName.TabIndex = 1;
            this.lbProgramName.Text = "작업지시 프로그램 傑作";
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Controls.Add(this.ucMainHome1);
            this.pnCenter.Controls.Add(this.ucSelectWorkOrder1);
            this.pnCenter.Controls.Add(this.ucSelectWorkComplete1);
            this.pnCenter.Controls.Add(this.ucInsertWorkOrder1);
            this.pnCenter.Location = new System.Drawing.Point(12, 68);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1160, 681);
            this.pnCenter.TabIndex = 2;
            // 
            // ucMainHome1
            // 
            this.ucMainHome1.BackColor = System.Drawing.Color.White;
            this.ucMainHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainHome1.Location = new System.Drawing.Point(0, 0);
            this.ucMainHome1.Name = "ucMainHome1";
            this.ucMainHome1.Size = new System.Drawing.Size(1160, 681);
            this.ucMainHome1.TabIndex = 3;
            // 
            // ucSelectWorkOrder1
            // 
            this.ucSelectWorkOrder1.BackColor = System.Drawing.Color.White;
            this.ucSelectWorkOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectWorkOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectWorkOrder1.Name = "ucSelectWorkOrder1";
            this.ucSelectWorkOrder1.Size = new System.Drawing.Size(1160, 681);
            this.ucSelectWorkOrder1.TabIndex = 2;
            // 
            // ucSelectWorkComplete1
            // 
            this.ucSelectWorkComplete1.BackColor = System.Drawing.Color.White;
            this.ucSelectWorkComplete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectWorkComplete1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectWorkComplete1.Name = "ucSelectWorkComplete1";
            this.ucSelectWorkComplete1.Size = new System.Drawing.Size(1160, 681);
            this.ucSelectWorkComplete1.TabIndex = 1;
            // 
            // ucInsertWorkOrder1
            // 
            this.ucInsertWorkOrder1.BackColor = System.Drawing.Color.White;
            this.ucInsertWorkOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInsertWorkOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucInsertWorkOrder1.Name = "ucInsertWorkOrder1";
            this.ucInsertWorkOrder1.Size = new System.Drawing.Size(1160, 681);
            this.ucInsertWorkOrder1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Brown;
            this.btnShutDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnShutDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Image = global::MESProject.Properties.Resources.icons8_shutdown_32px1;
            this.btnShutDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutDown.Location = new System.Drawing.Point(1074, 0);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(86, 50);
            this.btnShutDown.TabIndex = 6;
            this.btnShutDown.Text = "종료";
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnWCSelect
            // 
            this.btnWCSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWCSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWCSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWCSelect.FlatAppearance.BorderSize = 0;
            this.btnWCSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWCSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWCSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWCSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWCSelect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnWCSelect.ForeColor = System.Drawing.Color.White;
            this.btnWCSelect.Image = global::MESProject.Properties.Resources.icons8_purchase_order_32px1;
            this.btnWCSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWCSelect.Location = new System.Drawing.Point(668, 0);
            this.btnWCSelect.Name = "btnWCSelect";
            this.btnWCSelect.Size = new System.Drawing.Size(130, 50);
            this.btnWCSelect.TabIndex = 5;
            this.btnWCSelect.Text = "결과조회";
            this.btnWCSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWCSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWCSelect.UseVisualStyleBackColor = false;
            this.btnWCSelect.Click += new System.EventHandler(this.btnWCSelect_Click);
            // 
            // btnWOSelect
            // 
            this.btnWOSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWOSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWOSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWOSelect.FlatAppearance.BorderSize = 0;
            this.btnWOSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWOSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWOSelect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnWOSelect.ForeColor = System.Drawing.Color.White;
            this.btnWOSelect.Image = global::MESProject.Properties.Resources.icons8_factory_32px1;
            this.btnWOSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWOSelect.Location = new System.Drawing.Point(538, 0);
            this.btnWOSelect.Name = "btnWOSelect";
            this.btnWOSelect.Size = new System.Drawing.Size(130, 50);
            this.btnWOSelect.TabIndex = 4;
            this.btnWOSelect.Text = "지시서조회";
            this.btnWOSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWOSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWOSelect.UseVisualStyleBackColor = false;
            this.btnWOSelect.Click += new System.EventHandler(this.btnWOSelect_Click);
            // 
            // btnWOinsert
            // 
            this.btnWOinsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWOinsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWOinsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWOinsert.FlatAppearance.BorderSize = 0;
            this.btnWOinsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOinsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWOinsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOinsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWOinsert.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnWOinsert.ForeColor = System.Drawing.Color.White;
            this.btnWOinsert.Image = global::MESProject.Properties.Resources.icons8_create_32px;
            this.btnWOinsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWOinsert.Location = new System.Drawing.Point(408, 0);
            this.btnWOinsert.Name = "btnWOinsert";
            this.btnWOinsert.Size = new System.Drawing.Size(130, 50);
            this.btnWOinsert.TabIndex = 3;
            this.btnWOinsert.Text = "지시서입력";
            this.btnWOinsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWOinsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWOinsert.UseVisualStyleBackColor = false;
            this.btnWOinsert.Click += new System.EventHandler(this.btnWOinsert_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::MESProject.Properties.Resources.icons8_home_32px_12;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(278, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "홈";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MESProject.Properties.Resources.program_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnLeft);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnWCSelect;
        private System.Windows.Forms.Button btnWOSelect;
        private System.Windows.Forms.Button btnWOinsert;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnCenter;
        private View.UCInsertWorkOrder ucInsertWorkOrder1;
        private View.UCSelectWorkOrder ucSelectWorkOrder1;
        private View.UCSelectWorkComplete ucSelectWorkComplete1;
        private View.UCMainHome ucMainHome1;
        private System.Windows.Forms.Label lbDBIP;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbIPNum;
        private System.Windows.Forms.Label lbNowDate;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbProgramName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

