namespace KW_Univ_BurgerKing_Kiosk
{
    partial class Cart
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnu1_name = new System.Windows.Forms.Label();
            this.mnu1_detail = new System.Windows.Forms.Label();
            this.mnu1_price = new System.Windows.Forms.Label();
            this.mnu1_count = new System.Windows.Forms.Label();
            this.mnu1_minus = new System.Windows.Forms.Button();
            this.mnu1_plus = new System.Windows.Forms.Button();
            this.mnu1_delete = new System.Windows.Forms.Button();
            this.divider1 = new System.Windows.Forms.Label();
            this.hapgye = new System.Windows.Forms.Label();
            this.price_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(190, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "주문표";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 2);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // mnu1_name
            // 
            this.mnu1_name.Font = new System.Drawing.Font("굴림", 12F);
            this.mnu1_name.Location = new System.Drawing.Point(54, 88);
            this.mnu1_name.Name = "mnu1_name";
            this.mnu1_name.Size = new System.Drawing.Size(199, 16);
            this.mnu1_name.TabIndex = 10;
            this.mnu1_name.Text = "샘플 메뉴 이름1";
            this.mnu1_name.Visible = false;
            // 
            // mnu1_detail
            // 
            this.mnu1_detail.Location = new System.Drawing.Point(54, 123);
            this.mnu1_detail.Name = "mnu1_detail";
            this.mnu1_detail.Size = new System.Drawing.Size(257, 15);
            this.mnu1_detail.TabIndex = 11;
            this.mnu1_detail.Text = "샘플 메뉴 상세1";
            this.mnu1_detail.Visible = false;
            // 
            // mnu1_price
            // 
            this.mnu1_price.Font = new System.Drawing.Font("굴림", 12F);
            this.mnu1_price.Location = new System.Drawing.Point(300, 88);
            this.mnu1_price.Name = "mnu1_price";
            this.mnu1_price.Size = new System.Drawing.Size(118, 16);
            this.mnu1_price.TabIndex = 12;
            this.mnu1_price.Text = "0000원";
            this.mnu1_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnu1_price.Visible = false;
            // 
            // mnu1_count
            // 
            this.mnu1_count.Font = new System.Drawing.Font("굴림", 12F);
            this.mnu1_count.Location = new System.Drawing.Point(313, 162);
            this.mnu1_count.Name = "mnu1_count";
            this.mnu1_count.Size = new System.Drawing.Size(54, 24);
            this.mnu1_count.TabIndex = 13;
            this.mnu1_count.Text = "0";
            this.mnu1_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mnu1_count.Visible = false;
            // 
            // mnu1_minus
            // 
            this.mnu1_minus.Location = new System.Drawing.Point(270, 157);
            this.mnu1_minus.Name = "mnu1_minus";
            this.mnu1_minus.Size = new System.Drawing.Size(39, 32);
            this.mnu1_minus.TabIndex = 14;
            this.mnu1_minus.Text = "-";
            this.mnu1_minus.UseVisualStyleBackColor = true;
            this.mnu1_minus.Visible = false;
            this.mnu1_minus.Click += new System.EventHandler(this.mnu_minus_Click);
            // 
            // mnu1_plus
            // 
            this.mnu1_plus.Location = new System.Drawing.Point(370, 157);
            this.mnu1_plus.Name = "mnu1_plus";
            this.mnu1_plus.Size = new System.Drawing.Size(49, 32);
            this.mnu1_plus.TabIndex = 15;
            this.mnu1_plus.Text = "+";
            this.mnu1_plus.UseVisualStyleBackColor = true;
            this.mnu1_plus.Visible = false;
            this.mnu1_plus.Click += new System.EventHandler(this.mnu_plus_Click);
            // 
            // mnu1_delete
            // 
            this.mnu1_delete.Location = new System.Drawing.Point(54, 157);
            this.mnu1_delete.Name = "mnu1_delete";
            this.mnu1_delete.Size = new System.Drawing.Size(60, 32);
            this.mnu1_delete.TabIndex = 16;
            this.mnu1_delete.Text = "삭제";
            this.mnu1_delete.UseVisualStyleBackColor = true;
            this.mnu1_delete.Visible = false;
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(11, 211);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(457, 2);
            this.divider1.TabIndex = 17;
            this.divider1.Text = "label3";
            this.divider1.Visible = false;
            // 
            // hapgye
            // 
            this.hapgye.AutoSize = true;
            this.hapgye.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold);
            this.hapgye.Location = new System.Drawing.Point(50, 567);
            this.hapgye.Name = "hapgye";
            this.hapgye.Size = new System.Drawing.Size(81, 32);
            this.hapgye.TabIndex = 34;
            this.hapgye.Text = "합계";
            // 
            // price_result
            // 
            this.price_result.Font = new System.Drawing.Font("굴림", 24F);
            this.price_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.price_result.Location = new System.Drawing.Point(252, 566);
            this.price_result.Name = "price_result";
            this.price_result.Size = new System.Drawing.Size(192, 35);
            this.price_result.TabIndex = 35;
            this.price_result.Text = "0000원";
            this.price_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 2);
            this.label4.TabIndex = 36;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price_result);
            this.Controls.Add(this.hapgye);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.mnu1_delete);
            this.Controls.Add(this.mnu1_plus);
            this.Controls.Add(this.mnu1_minus);
            this.Controls.Add(this.mnu1_count);
            this.Controls.Add(this.mnu1_price);
            this.Controls.Add(this.mnu1_detail);
            this.Controls.Add(this.mnu1_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mnu1_name;
        private System.Windows.Forms.Label mnu1_detail;
        private System.Windows.Forms.Label mnu1_price;
        private System.Windows.Forms.Label mnu1_count;
        private System.Windows.Forms.Button mnu1_minus;
        private System.Windows.Forms.Button mnu1_plus;
        private System.Windows.Forms.Button mnu1_delete;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label hapgye;
        private System.Windows.Forms.Label price_result;
        private System.Windows.Forms.Label label4;
    }
}