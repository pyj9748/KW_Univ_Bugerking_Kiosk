
namespace KW_Univ_BurgerKing_Kiosk
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "추천";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(98, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "세트";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(184, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "단품";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(270, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "사이드";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 78);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 435);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Turquoise;
            this.imageList1.Images.SetKeyName(0, "0기네스콰트로치즈와퍼.jpg");
            this.imageList1.Images.SetKeyName(1, "1기네스와퍼.jpg");
            this.imageList1.Images.SetKeyName(2, "2기네스머쉬룸와퍼.jpg");
            this.imageList1.Images.SetKeyName(3, "3몬스터x.jpg");
            this.imageList1.Images.SetKeyName(4, "4몬스터와퍼.jpg");
            this.imageList1.Images.SetKeyName(5, "5콰트로치즈x.jpg");
            this.imageList1.Images.SetKeyName(6, "6콰트로치즈 와퍼.jpg");
            this.imageList1.Images.SetKeyName(7, "7트러플 머쉬룸 x.jpg");
            this.imageList1.Images.SetKeyName(8, "8트러플 머쉬룸 와퍼.jpg");
            this.imageList1.Images.SetKeyName(9, "9통새우스테이크버거.jpg");
            this.imageList1.Images.SetKeyName(10, "10통새우 와퍼.jpg");
            this.imageList1.Images.SetKeyName(11, "11바삭킹4조각.jpg");
            this.imageList1.Images.SetKeyName(12, "12치즈스틱.jpg");
            this.imageList1.Images.SetKeyName(13, "13너겟킹 8조각.jpg");
            this.imageList1.Images.SetKeyName(14, "14프렌치프라이.jpg");
            this.imageList1.Images.SetKeyName(15, "15어니언링.jpg");
            this.imageList1.Images.SetKeyName(16, "16코카콜라.jpg");
            this.imageList1.Images.SetKeyName(17, "17스프라이트.jpg");
            this.imageList1.Images.SetKeyName(18, "18미닛메이드 오렌지.jpg");
            this.imageList1.Images.SetKeyName(19, "19아메리카노.jpg");
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(12, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "장바구니";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(252, 519);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 80);
            this.button6.TabIndex = 6;
            this.button6.Text = "결제";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
    }
}

