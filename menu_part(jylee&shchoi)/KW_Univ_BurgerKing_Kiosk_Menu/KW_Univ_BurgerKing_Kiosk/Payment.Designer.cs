
namespace KW_Univ_BurgerKing_Kiosk
{
    partial class Payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kakao_radioButton = new System.Windows.Forms.RadioButton();
            this.credit_radioButton = new System.Windows.Forms.RadioButton();
            this.cash_radioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kakao_radioButton);
            this.groupBox1.Controls.Add(this.credit_radioButton);
            this.groupBox1.Controls.Add(this.cash_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(31, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결제 수단";
            // 
            // kakao_radioButton
            // 
            this.kakao_radioButton.AutoSize = true;
            this.kakao_radioButton.Location = new System.Drawing.Point(7, 67);
            this.kakao_radioButton.Name = "kakao_radioButton";
            this.kakao_radioButton.Size = new System.Drawing.Size(87, 16);
            this.kakao_radioButton.TabIndex = 2;
            this.kakao_radioButton.TabStop = true;
            this.kakao_radioButton.Text = "카카오 페이";
            this.kakao_radioButton.UseVisualStyleBackColor = true;
            this.kakao_radioButton.CheckedChanged += new System.EventHandler(this.kakao_radioButton_CheckedChanged);
            // 
            // credit_radioButton
            // 
            this.credit_radioButton.AutoSize = true;
            this.credit_radioButton.Location = new System.Drawing.Point(7, 44);
            this.credit_radioButton.Name = "credit_radioButton";
            this.credit_radioButton.Size = new System.Drawing.Size(75, 16);
            this.credit_radioButton.TabIndex = 1;
            this.credit_radioButton.TabStop = true;
            this.credit_radioButton.Text = "신용 카드";
            this.credit_radioButton.UseVisualStyleBackColor = true;
            this.credit_radioButton.CheckedChanged += new System.EventHandler(this.credit_radioButton_CheckedChanged);
            // 
            // cash_radioButton
            // 
            this.cash_radioButton.AutoSize = true;
            this.cash_radioButton.Location = new System.Drawing.Point(7, 21);
            this.cash_radioButton.Name = "cash_radioButton";
            this.cash_radioButton.Size = new System.Drawing.Size(47, 16);
            this.cash_radioButton.TabIndex = 0;
            this.cash_radioButton.TabStop = true;
            this.cash_radioButton.Text = "현금";
            this.cash_radioButton.UseVisualStyleBackColor = true;
            this.cash_radioButton.CheckedChanged += new System.EventHandler(this.cash_radioButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 236);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(31, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 88);
            this.button1.TabIndex = 2;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(250, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 88);
            this.button2.TabIndex = 3;
            this.button2.Text = "나가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "결제 금액 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(213, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(153, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "주문 번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(342, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 7;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kakao_radioButton;
        private System.Windows.Forms.RadioButton credit_radioButton;
        private System.Windows.Forms.RadioButton cash_radioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}