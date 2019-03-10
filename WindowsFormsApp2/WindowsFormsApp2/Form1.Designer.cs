namespace WindowsFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comFont = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.rdoBaseball = new System.Windows.Forms.RadioButton();
            this.rdoBasketball = new System.Windows.Forms.RadioButton();
            this.rdoTkd = new System.Windows.Forms.RadioButton();
            this.lblSports = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoopCount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.prb1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comFont);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "폰트 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.rdoTkd);
            this.groupBox2.Controls.Add(this.rdoBasketball);
            this.groupBox2.Controls.Add(this.rdoBaseball);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(24, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좋아하는 스포츠 하나만";
            // 
            // comFont
            // 
            this.comFont.FormattingEnabled = true;
            this.comFont.Location = new System.Drawing.Point(55, 24);
            this.comFont.Name = "comFont";
            this.comFont.Size = new System.Drawing.Size(270, 20);
            this.comFont.TabIndex = 1;
            this.comFont.SelectedIndexChanged += new System.EventHandler(this.comFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(344, 28);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(398, 28);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(72, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이텔릭체";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(20, 57);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(450, 21);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "오라클자바커뮤니티";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "폰트";
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(18, 30);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(47, 16);
            this.rdoSoccer.TabIndex = 0;
            this.rdoSoccer.TabStop = true;
            this.rdoSoccer.Text = "축구";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            this.rdoSoccer.CheckedChanged += new System.EventHandler(this.rdoSoccer_CheckedChanged);
            // 
            // rdoBaseball
            // 
            this.rdoBaseball.AutoSize = true;
            this.rdoBaseball.Location = new System.Drawing.Point(143, 30);
            this.rdoBaseball.Name = "rdoBaseball";
            this.rdoBaseball.Size = new System.Drawing.Size(47, 16);
            this.rdoBaseball.TabIndex = 1;
            this.rdoBaseball.TabStop = true;
            this.rdoBaseball.Text = "야구";
            this.rdoBaseball.UseVisualStyleBackColor = true;
            this.rdoBaseball.CheckedChanged += new System.EventHandler(this.rdoBaseball_CheckedChanged);
            // 
            // rdoBasketball
            // 
            this.rdoBasketball.AutoSize = true;
            this.rdoBasketball.Location = new System.Drawing.Point(268, 30);
            this.rdoBasketball.Name = "rdoBasketball";
            this.rdoBasketball.Size = new System.Drawing.Size(47, 16);
            this.rdoBasketball.TabIndex = 2;
            this.rdoBasketball.TabStop = true;
            this.rdoBasketball.Text = "농구";
            this.rdoBasketball.UseVisualStyleBackColor = true;
            this.rdoBasketball.CheckedChanged += new System.EventHandler(this.rdoBasketball_CheckedChanged);
            // 
            // rdoTkd
            // 
            this.rdoTkd.AutoSize = true;
            this.rdoTkd.Location = new System.Drawing.Point(393, 30);
            this.rdoTkd.Name = "rdoTkd";
            this.rdoTkd.Size = new System.Drawing.Size(59, 16);
            this.rdoTkd.TabIndex = 3;
            this.rdoTkd.TabStop = true;
            this.rdoTkd.Text = "태권도";
            this.rdoTkd.UseVisualStyleBackColor = true;
            this.rdoTkd.CheckedChanged += new System.EventHandler(this.rdoTkd_CheckedChanged);
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(16, 71);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(149, 12);
            this.lblSports.TabIndex = 4;
            this.lblSports.Text = "선택한 스포츠가 없습니다.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prb1);
            this.groupBox3.Controls.Add(this.trb1);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.txtLoopCount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(24, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "반복횟수";
            // 
            // txtLoopCount
            // 
            this.txtLoopCount.Location = new System.Drawing.Point(154, 34);
            this.txtLoopCount.Name = "txtLoopCount";
            this.txtLoopCount.Size = new System.Drawing.Size(107, 21);
            this.txtLoopCount.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(334, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(18, 70);
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(450, 45);
            this.trb1.TabIndex = 3;
            this.trb1.Scroll += new System.EventHandler(this.trb1_Scroll);
            // 
            // prb1
            // 
            this.prb1.Location = new System.Drawing.Point(18, 121);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(450, 15);
            this.prb1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox comFont;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton rdoTkd;
        private System.Windows.Forms.RadioButton rdoBasketball;
        private System.Windows.Forms.RadioButton rdoBaseball;
        private System.Windows.Forms.RadioButton rdoSoccer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar prb1;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLoopCount;
        private System.Windows.Forms.Label label1;
    }
}

