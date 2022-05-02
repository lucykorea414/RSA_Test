
namespace RSA_Test
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priKeyTxt = new System.Windows.Forms.TextBox();
            this.pubKeyTxt = new System.Windows.Forms.TextBox();
            this.keyGenerateBtn = new System.Windows.Forms.Button();
            this.PlnTxt = new System.Windows.Forms.TextBox();
            this.EncTxt = new System.Windows.Forms.TextBox();
            this.DecTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EncBtn = new System.Windows.Forms.Button();
            this.DecBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priKeyTxt);
            this.groupBox1.Controls.Add(this.pubKeyTxt);
            this.groupBox1.Controls.Add(this.keyGenerateBtn);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public Key";
            // 
            // priKeyTxt
            // 
            this.priKeyTxt.Location = new System.Drawing.Point(9, 112);
            this.priKeyTxt.Multiline = true;
            this.priKeyTxt.Name = "priKeyTxt";
            this.priKeyTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.priKeyTxt.Size = new System.Drawing.Size(767, 42);
            this.priKeyTxt.TabIndex = 3;
            // 
            // pubKeyTxt
            // 
            this.pubKeyTxt.Location = new System.Drawing.Point(9, 42);
            this.pubKeyTxt.Multiline = true;
            this.pubKeyTxt.Name = "pubKeyTxt";
            this.pubKeyTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pubKeyTxt.Size = new System.Drawing.Size(769, 42);
            this.pubKeyTxt.TabIndex = 3;
            // 
            // keyGenerateBtn
            // 
            this.keyGenerateBtn.Location = new System.Drawing.Point(648, 15);
            this.keyGenerateBtn.Name = "keyGenerateBtn";
            this.keyGenerateBtn.Size = new System.Drawing.Size(128, 20);
            this.keyGenerateBtn.TabIndex = 2;
            this.keyGenerateBtn.Text = "Key Generate";
            this.keyGenerateBtn.UseVisualStyleBackColor = true;
            this.keyGenerateBtn.Click += new System.EventHandler(this.keyGenerateBtn_Click);
            // 
            // PlnTxt
            // 
            this.PlnTxt.Location = new System.Drawing.Point(5, 206);
            this.PlnTxt.Multiline = true;
            this.PlnTxt.Name = "PlnTxt";
            this.PlnTxt.Size = new System.Drawing.Size(784, 78);
            this.PlnTxt.TabIndex = 8;
            // 
            // EncTxt
            // 
            this.EncTxt.Location = new System.Drawing.Point(5, 324);
            this.EncTxt.Multiline = true;
            this.EncTxt.Name = "EncTxt";
            this.EncTxt.Size = new System.Drawing.Size(784, 78);
            this.EncTxt.TabIndex = 8;
            // 
            // DecTxt
            // 
            this.DecTxt.Location = new System.Drawing.Point(5, 445);
            this.DecTxt.Multiline = true;
            this.DecTxt.Name = "DecTxt";
            this.DecTxt.Size = new System.Drawing.Size(784, 78);
            this.DecTxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "평문";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "암호문";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "복호문";
            // 
            // EncBtn
            // 
            this.EncBtn.Location = new System.Drawing.Point(694, 290);
            this.EncBtn.Name = "EncBtn";
            this.EncBtn.Size = new System.Drawing.Size(86, 28);
            this.EncBtn.TabIndex = 11;
            this.EncBtn.Text = "암호화";
            this.EncBtn.UseVisualStyleBackColor = true;
            this.EncBtn.Click += new System.EventHandler(this.EncBtn_Click);
            // 
            // DecBtn
            // 
            this.DecBtn.Location = new System.Drawing.Point(694, 411);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Size = new System.Drawing.Size(86, 28);
            this.DecBtn.TabIndex = 11;
            this.DecBtn.Text = "복호화";
            this.DecBtn.UseVisualStyleBackColor = true;
            this.DecBtn.Click += new System.EventHandler(this.DecBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 535);
            this.Controls.Add(this.DecBtn);
            this.Controls.Add(this.EncBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecTxt);
            this.Controls.Add(this.EncTxt);
            this.Controls.Add(this.PlnTxt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priKeyTxt;
        private System.Windows.Forms.TextBox pubKeyTxt;
        private System.Windows.Forms.Button keyGenerateBtn;
        private System.Windows.Forms.TextBox PlnTxt;
        private System.Windows.Forms.TextBox EncTxt;
        private System.Windows.Forms.TextBox DecTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EncBtn;
        private System.Windows.Forms.Button DecBtn;
    }
}

